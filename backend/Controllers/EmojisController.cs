using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Models;
using backend.Data;
namespace backend.Controllers
{
    [ApiController]
    [Route("api/emojis")]
    public class EmojisController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmojisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/emojis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Emoji>>> GetEmojis()
        {
            return await _context.Emojis.Include(e => e.Level).ToListAsync();
        }

        // GET: api/emojis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Emoji>> GetEmoji(int id)
        {
            var emoji = await _context.Emojis.Include(e => e.Level)
                                             .FirstOrDefaultAsync(e => e.Id == id);

            if (emoji == null)
            {
                return NotFound();
            }

            return emoji;
        }

        // POST: api/emojis
        [HttpPost]
        public async Task<ActionResult<Emoji>> CreateEmoji(Emoji emoji)
        {
            _context.Emojis.Add(emoji);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmoji), new { id = emoji.Id }, emoji);
        }

        // PUT: api/emojis/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmoji(int id, Emoji emoji)
        {
            if (id != emoji.Id)
            {
                return BadRequest();
            }

            _context.Entry(emoji).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmojiExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/emojis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmoji(int id)
        {
            var emoji = await _context.Emojis.FindAsync(id);
            if (emoji == null)
            {
                return NotFound();
            }

            _context.Emojis.Remove(emoji);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmojiExists(int id)
        {
            return _context.Emojis.Any(e => e.Id == id);
        }
    }
}