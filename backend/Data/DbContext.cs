using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Emoji> Emojis { get; set; }
        public DbSet<Level> Levels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Auto-generera Id för User och Record
            modelBuilder.Entity<User>()
                .Property(u => u.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Record>()
                .Property(r => r.Id)
                .ValueGeneratedOnAdd();

            // Relation User -> Records
            modelBuilder.Entity<User>()
                .HasMany(u => u.Records)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId);

            // Relation Emoji -> Level
            modelBuilder.Entity<Emoji>()
                .HasOne(e => e.Level)
                .WithMany(l => l.Emojis)
                .HasForeignKey(e => e.LevelId);

            // Seed Levels
            modelBuilder.Entity<Level>().HasData(
                new Level { Id = 1, Number = 1 },
                new Level { Id = 2, Number = 2 },
                new Level { Id = 3, Number = 3 },
                new Level { Id = 4, Number = 4 },
                new Level { Id = 5, Number = 5 },
                new Level { Id = 6, Number = 6 },
                new Level { Id = 7, Number = 7 },
                new Level { Id = 8, Number = 8 },
                new Level { Id = 9, Number = 9 },
                new Level { Id = 10, Number = 10 }
            );

            // Seed Emojis
            modelBuilder.Entity<Emoji>().HasData(
                // Level 1 (Animals)
                new Emoji { Id = 1, Symbol = "🐶", Description = "Hund", LevelId = 1 },
                new Emoji { Id = 2, Symbol = "🐱", Description = "Katt", LevelId = 1 },
                new Emoji { Id = 3, Symbol = "🐭", Description = "Mus", LevelId = 1 },
                new Emoji { Id = 4, Symbol = "🐰", Description = "Kanin", LevelId = 1 },
                new Emoji { Id = 5, Symbol = "🦊", Description = "Räv", LevelId = 1 },
                new Emoji { Id = 6, Symbol = "🐻", Description = "Björn", LevelId = 1 },
                new Emoji { Id = 7, Symbol = "🐼", Description = "Panda", LevelId = 1 },
                new Emoji { Id = 8, Symbol = "🐨", Description = "Koala", LevelId = 1 },
                new Emoji { Id = 9, Symbol = "🦁", Description = "Lejon", LevelId = 1 },
                new Emoji { Id = 10, Symbol = "🐮", Description = "Ko", LevelId = 1 },
                new Emoji { Id = 11, Symbol = "🐷", Description = "Gris", LevelId = 1 },
                new Emoji { Id = 12, Symbol = "🐸", Description = "Groda", LevelId = 1 },
                new Emoji { Id = 13, Symbol = "🐵", Description = "Apa", LevelId = 1 },
                new Emoji { Id = 14, Symbol = "🦄", Description = "Enhörning", LevelId = 1 },
                new Emoji { Id = 15, Symbol = "🐔", Description = "Kyckling", LevelId = 1 },

                // Level 2 (Food & Drink)
                new Emoji { Id = 16, Symbol = "🍎", Description = "Äpple", LevelId = 2 },
                new Emoji { Id = 17, Symbol = "🍕", Description = "Pizza", LevelId = 2 },
                new Emoji { Id = 18, Symbol = "🍔", Description = "Hamburgare", LevelId = 2 },
                new Emoji { Id = 19, Symbol = "🍦", Description = "Glass", LevelId = 2 },
                new Emoji { Id = 20, Symbol = "🍩", Description = "Munk", LevelId = 2 },
                new Emoji { Id = 21, Symbol = "🍉", Description = "Vattenmelon", LevelId = 2 },
                new Emoji { Id = 22, Symbol = "🍟", Description = "Pommes", LevelId = 2 },
                new Emoji { Id = 23, Symbol = "🍰", Description = "Tårta", LevelId = 2 },
                new Emoji { Id = 24, Symbol = "🍫", Description = "Choklad", LevelId = 2 },
                new Emoji { Id = 25, Symbol = "🍺", Description = "Öl", LevelId = 2 },
                new Emoji { Id = 26, Symbol = "🍵", Description = "Te", LevelId = 2 },
                new Emoji { Id = 27, Symbol = "🍿", Description = "Popcorn", LevelId = 2 },
                new Emoji { Id = 28, Symbol = "🍆", Description = "Aubergine", LevelId = 2 },
                new Emoji { Id = 29, Symbol = "🍓", Description = "Jordgubb", LevelId = 2 },
                new Emoji { Id = 30, Symbol = "🍑", Description = "Persika", LevelId = 2 },

                // Level 3 (Leisure & Sports)
                new Emoji { Id = 31, Symbol = "⚽", Description = "Fotboll", LevelId = 3 },
                new Emoji { Id = 32, Symbol = "🏀", Description = "Basket", LevelId = 3 },
                new Emoji { Id = 33, Symbol = "🏈", Description = "Rugby", LevelId = 3 },
                new Emoji { Id = 34, Symbol = "🎾", Description = "Tennis", LevelId = 3 },
                new Emoji { Id = 35, Symbol = "🏓", Description = "Pingis", LevelId = 3 },
                new Emoji { Id = 36, Symbol = "🏸", Description = "Badminton", LevelId = 3 },
                new Emoji { Id = 37, Symbol = "🏊", Description = "Simning", LevelId = 3 },
                new Emoji { Id = 38, Symbol = "🚴", Description = "Cykling", LevelId = 3 },
                new Emoji { Id = 39, Symbol = "🧗", Description = "Klättring", LevelId = 3 },
                new Emoji { Id = 40, Symbol = "🏄", Description = "Surfing", LevelId = 3 },
                new Emoji { Id = 41, Symbol = "🏂", Description = "Snowboard", LevelId = 3 },
                new Emoji { Id = 42, Symbol = "🏒", Description = "Hockey", LevelId = 3 },
                new Emoji { Id = 43, Symbol = "🥊", Description = "Boxning", LevelId = 3 },
                new Emoji { Id = 44, Symbol = "🤸", Description = "Gymnastik", LevelId = 3 },
                new Emoji { Id = 45, Symbol = "🤾", Description = "Handboll", LevelId = 3 },

                // Level 4 (Jobs & Work)
                new Emoji { Id = 46, Symbol = "👨‍⚕️", Description = "Läkare", LevelId = 4 },
                new Emoji { Id = 47, Symbol = "👩‍🏫", Description = "Lärare", LevelId = 4 },
                new Emoji { Id = 48, Symbol = "👨‍🍳", Description = "Kock", LevelId = 4 },
                new Emoji { Id = 49, Symbol = "👩‍🔧", Description = "Mekaniker", LevelId = 4 },
                new Emoji { Id = 50, Symbol = "👨‍🚒", Description = "Brandman", LevelId = 4 },
                new Emoji { Id = 51, Symbol = "👩‍✈️", Description = "Pilot", LevelId = 4 },
                new Emoji { Id = 52, Symbol = "👨‍⚖️", Description = "Domare", LevelId = 4 },
                new Emoji { Id = 53, Symbol = "👩‍🎨", Description = "Konstnär", LevelId = 4 },
                new Emoji { Id = 54, Symbol = "👨‍🔬", Description = "Forskare", LevelId = 4 },
                new Emoji { Id = 55, Symbol = "👩‍💻", Description = "Programmerare", LevelId = 4 },
                new Emoji { Id = 56, Symbol = "👨‍🏭", Description = "Svetsare", LevelId = 4 },
                new Emoji { Id = 57, Symbol = "👩‍🚀", Description = "Astronaut", LevelId = 4 },
                new Emoji { Id = 58, Symbol = "👨‍🎤", Description = "Artist", LevelId = 4 },
                new Emoji { Id = 59, Symbol = "👩‍🌾", Description = "Bonde", LevelId = 4 },
                new Emoji { Id = 60, Symbol = "👮", Description = "Polis", LevelId = 4 },

                // Level 5 (Transport & Vehicles)
                new Emoji { Id = 61, Symbol = "🚗", Description = "Bil", LevelId = 5 },
                new Emoji { Id = 62, Symbol = "🚕", Description = "Taxi", LevelId = 5 },
                new Emoji { Id = 63, Symbol = "🚌", Description = "Buss", LevelId = 5 },
                new Emoji { Id = 64, Symbol = "🚎", Description = "Spårvagn", LevelId = 5 },
                new Emoji { Id = 65, Symbol = "🚓", Description = "Polisbil", LevelId = 5 },
                new Emoji { Id = 66, Symbol = "🚑", Description = "Ambulans", LevelId = 5 },
                new Emoji { Id = 67, Symbol = "🚒", Description = "Brandbil", LevelId = 5 },
                new Emoji { Id = 68, Symbol = "🚐", Description = "Van", LevelId = 5 },
                new Emoji { Id = 69, Symbol = "🚚", Description = "Lastbil", LevelId = 5 },
                new Emoji { Id = 70, Symbol = "🚲", Description = "Cykel", LevelId = 5 },
                new Emoji { Id = 71, Symbol = "🛴", Description = "Sparkcykel", LevelId = 5 },
                new Emoji { Id = 72, Symbol = "🛵", Description = "Moped", LevelId = 5 },
                new Emoji { Id = 73, Symbol = "🏍️", Description = "Motorcykel", LevelId = 5 },
                new Emoji { Id = 74, Symbol = "🚂", Description = "Tåg", LevelId = 5 },
                new Emoji { Id = 75, Symbol = "✈️", Description = "Flygplan", LevelId = 5 },

                // Level 6 (Nature & Weather)
                new Emoji { Id = 76, Symbol = "🌞", Description = "Sol", LevelId = 6 },
                new Emoji { Id = 77, Symbol = "🌧️", Description = "Regn", LevelId = 6 },
                new Emoji { Id = 78, Symbol = "⛈️", Description = "Oväder", LevelId = 6 },
                new Emoji { Id = 79, Symbol = "🌈", Description = "Regnbåge", LevelId = 6 },
                new Emoji { Id = 80, Symbol = "🌪️", Description = "Tornado", LevelId = 6 },
                new Emoji { Id = 81, Symbol = "🌻", Description = "Solros", LevelId = 6 },
                new Emoji { Id = 82, Symbol = "🌳", Description = "Träd", LevelId = 6 },
                new Emoji { Id = 83, Symbol = "🌲", Description = "Gran", LevelId = 6 },
                new Emoji { Id = 84, Symbol = "🌵", Description = "Kaktus", LevelId = 6 },
                new Emoji { Id = 85, Symbol = "🌴", Description = "Palm", LevelId = 6 },
                new Emoji { Id = 86, Symbol = "🌸", Description = "Blomma", LevelId = 6 },
                new Emoji { Id = 87, Symbol = "🌙", Description = "Måne", LevelId = 6 },
                new Emoji { Id = 88, Symbol = "🍂", Description = "Löv", LevelId = 6 },
                new Emoji { Id = 89, Symbol = "🦋", Description = "Fjäril", LevelId = 6 },
                new Emoji { Id = 90, Symbol = "❄️", Description = "Snö", LevelId = 6 },

                // Level 7 (Places & Buildings)
                new Emoji { Id = 91, Symbol = "🏟️", Description = "Arena", LevelId = 7 },
                new Emoji { Id = 92, Symbol = "🏡", Description = "Villa", LevelId = 7 },
                new Emoji { Id = 93, Symbol = "🏖️", Description = "Strand", LevelId = 7 },
                new Emoji { Id = 94, Symbol = "🏝️", Description = "Ö", LevelId = 7 },
                new Emoji { Id = 95, Symbol = "🏤", Description = "Station", LevelId = 7 },
                new Emoji { Id = 96, Symbol = "🏥", Description = "Sjukhus", LevelId = 7 },
                new Emoji { Id = 97, Symbol = "🏦", Description = "Bank", LevelId = 7 },
                new Emoji { Id = 98, Symbol = "🏨", Description = "Hotell", LevelId = 7 },
                new Emoji { Id = 99, Symbol = "🏞️", Description = "Park", LevelId = 7 },
                new Emoji { Id = 100, Symbol = "🏪", Description = "Butik", LevelId = 7 },
                new Emoji { Id = 101, Symbol = "🏫", Description = "Skola", LevelId = 7 },
                new Emoji { Id = 102, Symbol = "🏬", Description = "Köpcenter", LevelId = 7 },
                new Emoji { Id = 103, Symbol = "🏭", Description = "Fabrik", LevelId = 7 },
                new Emoji { Id = 104, Symbol = "🏯", Description = "Tempel", LevelId = 7 },
                new Emoji { Id = 105, Symbol = "🏰", Description = "Slott", LevelId = 7 },

                // Level 8 (Emotions)
                new Emoji { Id = 106, Symbol = "🙂", Description = "Glad", LevelId = 8 },
                new Emoji { Id = 107, Symbol = "😢", Description = "Ledsen", LevelId = 8 },
                new Emoji { Id = 108, Symbol = "😠", Description = "Arg", LevelId = 8 },
                new Emoji { Id = 109, Symbol = "😍", Description = "Kär", LevelId = 8 }, 
                new Emoji { Id = 110, Symbol = "😮", Description = "Förvånad", LevelId = 8 },
                new Emoji { Id = 111, Symbol = "😬", Description = "Spänd", LevelId = 8 },
                new Emoji { Id = 112, Symbol = "😲", Description = "Chockad", LevelId = 8 },
                new Emoji { Id = 113, Symbol = "😤", Description = "Frustrerad", LevelId = 8 },
                new Emoji { Id = 114, Symbol = "😡", Description = "Ilska", LevelId = 8 },
                new Emoji { Id = 115, Symbol = "😊", Description = "Nöjd", LevelId = 8 }, 
                new Emoji { Id = 116, Symbol = "😃", Description = "Entusiastisk", LevelId = 8 },
                new Emoji { Id = 117, Symbol = "😕", Description = "Förvirrad", LevelId = 8 },
                new Emoji { Id = 118, Symbol = "😅", Description = "Nervös", LevelId = 8 },
                new Emoji { Id = 119, Symbol = "😌", Description = "Lugn", LevelId = 8 },
                new Emoji { Id = 120, Symbol = "😱", Description = "Rädd", LevelId = 8 },

                // Level 9 (Expressions)
                new Emoji { Id = 121, Symbol = "😉", Description = "Blinkar", LevelId = 9 },
                new Emoji { Id = 122, Symbol = "😏", Description = "Flinar", LevelId = 9 },
                new Emoji { Id = 123, Symbol = "🙃", Description = "Oseriös", LevelId = 9 },
                new Emoji { Id = 124, Symbol = "🤔", Description = "Tänker", LevelId = 9 },
                new Emoji { Id = 125, Symbol = "😋", Description = "Njuter", LevelId = 9 },
                new Emoji { Id = 126, Symbol = "😜", Description = "Busig", LevelId = 9 },
                new Emoji { Id = 127, Symbol = "🤭", Description = "Fnissar", LevelId = 9 },
                new Emoji { Id = 128, Symbol = "😛", Description = "Skämtar", LevelId = 9 },
                new Emoji { Id = 129, Symbol = "😎", Description = "Cool", LevelId = 9 },
                new Emoji { Id = 130, Symbol = "😂", Description = "Skrattar", LevelId = 9 },
                new Emoji { Id = 131, Symbol = "🤩", Description = "Imponerad", LevelId = 9 },
                new Emoji { Id = 132, Symbol = "🥹", Description = "Rörd", LevelId = 9 },
                new Emoji { Id = 133, Symbol = "🤤", Description = "Dreglar", LevelId = 9 },
                new Emoji { Id = 134, Symbol = "🫠", Description = "Smälter", LevelId = 9 },
                new Emoji { Id = 135, Symbol = "🤮", Description = "Kräks", LevelId = 9 },

                // Level 10 (Symbols & Shapes)
                new Emoji { Id = 136, Symbol = "❤️", Description = "Hjärta", LevelId = 10 },
                new Emoji { Id = 137, Symbol = "💔", Description = "Brusten", LevelId = 10 },
                new Emoji { Id = 138, Symbol = "⭐", Description = "Stjärna", LevelId = 10 },
                new Emoji { Id = 139, Symbol = "✨", Description = "Glans", LevelId = 10 },
                new Emoji { Id = 140, Symbol = "⚡", Description = "Blixt", LevelId = 10 },
                new Emoji { Id = 141, Symbol = "🔥", Description = "Eld", LevelId = 10 },
                new Emoji { Id = 142, Symbol = "💧", Description = "Droppe", LevelId = 10 },
                new Emoji { Id = 143, Symbol = "❗", Description = "Utrop", LevelId = 10 },
                new Emoji { Id = 144, Symbol = "❓", Description = "Fråga", LevelId = 10 },
                new Emoji { Id = 145, Symbol = "✅", Description = "Klar", LevelId = 10 },
                new Emoji { Id = 146, Symbol = "❌", Description = "Fel", LevelId = 10 },
                new Emoji { Id = 147, Symbol = "➕", Description = "Plus", LevelId = 10 },
                new Emoji { Id = 148, Symbol = "➖", Description = "Minus", LevelId = 10 },
                new Emoji { Id = 149, Symbol = "➗", Description = "Division", LevelId = 10 },
                new Emoji { Id = 150, Symbol = "🔺", Description = "Triangel", LevelId = 10 }
            );

            // Seed Record
            modelBuilder.Entity<Record>().HasData(
                new Record
                {
                    Id = 1,
                    UserId = 1,
                    LevelId = 1,
                    Rounds = 12,
                    Time = 45
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}