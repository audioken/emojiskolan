using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Models;
using backend.Data;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.Include(u => u.Records).ToListAsync();
        }

        // GET: api/users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.Include(u => u.Records)
                                           .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // POST: api/users
        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        // PUT: api/users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] User user)
        {
            if (id != user.Id)
                return BadRequest();

            var existingUser = await _context.Users.FindAsync(id);
            if (existingUser == null)
                return NotFound();

            // Uppdatera bara de fält som ska ändras
            existingUser.Username = user.Username ?? existingUser.Username;
            existingUser.Email = user.Email ?? existingUser.Email;
            existingUser.AvatarId = user.AvatarId != 0 ? user.AvatarId : existingUser.AvatarId;
            Console.WriteLine($"Updating user ID {id}: Username={existingUser.Username}, Email={existingUser.Email}, AvatarId={existingUser.AvatarId}");

            // Endast om lösenord skickas med
            if (!string.IsNullOrEmpty(user.PasswordHash))
                existingUser.PasswordHash = user.PasswordHash;

            // Om du vill tillåta att Level ändras, lägg till:
            // existingUser.Level = user.Level != 0 ? user.Level : existingUser.Level;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                    return NotFound();
                else
                    throw;
            }

            // Returnera uppdaterad användare (om frontend vill ha det)
            return Ok(existingUser);
        }

        // PUT: api/users/5
        [HttpPut("{id}/password")]
        public async Task<IActionResult> UpdatePassword(int id, [FromBody] Dictionary<string, object> updates)
        {
            var user = await _context.Users.FindAsync(id);
            Console.WriteLine($"Updating password for user ID {id}");
            if (user == null)
                return NotFound();

            // Endast lösenordsbyte
            if (updates.ContainsKey("passwordHash"))
            {
                user.PasswordHash = updates["passwordHash"]?.ToString();

                await _context.SaveChangesAsync();
                return NoContent();
            }

            // Annars: kräver hela User-objektet (eller hantera fler fält här)
            return BadRequest("Endast lösenordsbyte stöds i denna PUT.");
        }

        // DELETE: api/users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        // POST: api/users/{userId}/records - Create new record only
        [HttpPost("{userId}/records")]
        public async Task<ActionResult<Record>> CreateRecord(int userId, [FromBody] Record record)
        {
            if (record == null)
            {
                return BadRequest("Record data is required");
            }

            var user = await _context.Users.FindAsync(userId);
            if (user == null)
            {
                return NotFound("User not found");
            }

            // Validate that level exists
            var level = await _context.Levels.FindAsync(record.LevelId);
            if (level == null)
            {
                return BadRequest("Invalid level");
            }

            // Check if user already has a record for this level
            var existingRecord = await _context.Records
                .FirstOrDefaultAsync(r => r.UserId == userId && r.LevelId == record.LevelId);

            if (existingRecord != null)
            {
                return Conflict(new { message = "Record already exists for this level", existingRecord });
            }

            // Create new record
            var newRecord = new Record
            {
                UserId = userId,
                LevelId = record.LevelId,
                Rounds = record.Rounds,
                Time = record.Time
            };

            Console.WriteLine($"Creating new record: UserId={newRecord.UserId}, LevelId={newRecord.LevelId}, Rounds={newRecord.Rounds}, Time={newRecord.Time}");

            _context.Records.Add(newRecord);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = userId }, newRecord);
        }

        // PUT: api/users/{userId}/records/{levelId} - Update existing record
        [HttpPut("{userId}/records/{levelId}")]
        public async Task<ActionResult<Record>> UpdateRecord(int userId, int levelId, [FromBody] Record record)
        {
            if (record == null)
            {
                return BadRequest("Record data is required");
            }

            var user = await _context.Users.FindAsync(userId);
            if (user == null)
            {
                return NotFound("User not found");
            }

            // Validate that level exists
            var level = await _context.Levels.FindAsync(levelId);
            if (level == null)
            {
                return BadRequest("Invalid level");
            }

            // Find existing record
            var existingRecord = await _context.Records
                .FirstOrDefaultAsync(r => r.UserId == userId && r.LevelId == levelId);

            if (existingRecord == null)
            {
                return NotFound("No record found for this user and level");
            }

            // Check if new result is better (fewer rounds, or same rounds but faster time)
            bool isBetter = record.Rounds < existingRecord.Rounds ||
                           (record.Rounds == existingRecord.Rounds && record.Time < existingRecord.Time);

            if (!isBetter)
            {
                // New result is not better, return existing record
                Console.WriteLine($"New result is not better. Existing: {existingRecord.Rounds} rounds, {existingRecord.Time}s. New: {record.Rounds} rounds, {record.Time}s");
                return Ok(new { message = "New result is not better than existing record", record = existingRecord });
            }

            // Update existing record with better result
            existingRecord.Rounds = record.Rounds;
            existingRecord.Time = record.Time;

            Console.WriteLine($"Updating existing record: UserId={existingRecord.UserId}, LevelId={existingRecord.LevelId}, Rounds={existingRecord.Rounds}, Time={existingRecord.Time}");

            await _context.SaveChangesAsync();
            return Ok(existingRecord);
        }

    }
}