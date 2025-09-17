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
                // Level 1 (Emotions)
                new Emoji { Id = 1, Symbol = "🙂", Description = "Glad", LevelId = 1 },
                new Emoji { Id = 2, Symbol = "😢", Description = "Ledsen", LevelId = 1 },
                new Emoji { Id = 3, Symbol = "😠", Description = "Arg", LevelId = 1 },
                new Emoji { Id = 4, Symbol = "😍", Description = "Kär", LevelId = 1 }, 
                new Emoji { Id = 5, Symbol = "😮", Description = "Förvånad", LevelId = 1 },
                new Emoji { Id = 6, Symbol = "😬", Description = "Spänd", LevelId = 1 },
                new Emoji { Id = 7, Symbol = "😲", Description = "Chockad", LevelId = 1 },
                new Emoji { Id = 8, Symbol = "😤", Description = "Frustrerad", LevelId = 1 },
                new Emoji { Id = 9, Symbol = "😡", Description = "Ilska", LevelId = 1 },
                new Emoji { Id = 10, Symbol = "😊", Description = "Nöjd", LevelId = 1 }, 
                new Emoji { Id = 11, Symbol = "😃", Description = "Entusiastisk", LevelId = 1 },
                new Emoji { Id = 12, Symbol = "😕", Description = "Förvirrad", LevelId = 1 },
                new Emoji { Id = 13, Symbol = "😅", Description = "Nervös", LevelId = 1 },
                new Emoji { Id = 14, Symbol = "😌", Description = "Lugn", LevelId = 1 },
                new Emoji { Id = 15, Symbol = "😱", Description = "Rädd", LevelId = 1 },

                // Level 2 (Animals)
                new Emoji { Id = 16, Symbol = "🐶", Description = "Hund", LevelId = 2 },
                new Emoji { Id = 17, Symbol = "🐱", Description = "Katt", LevelId = 2 },
                new Emoji { Id = 18, Symbol = "🐭", Description = "Mus", LevelId = 2 },
                new Emoji { Id = 19, Symbol = "🐰", Description = "Kanin", LevelId = 2 },
                new Emoji { Id = 20, Symbol = "🦊", Description = "Räv", LevelId = 2 },
                new Emoji { Id = 21, Symbol = "🐻", Description = "Björn", LevelId = 2 },
                new Emoji { Id = 22, Symbol = "🐼", Description = "Panda", LevelId = 2 },
                new Emoji { Id = 23, Symbol = "🐨", Description = "Koala", LevelId = 2 },
                new Emoji { Id = 24, Symbol = "🦁", Description = "Lejon", LevelId = 2 },
                new Emoji { Id = 25, Symbol = "🐮", Description = "Ko", LevelId = 2 },
                new Emoji { Id = 26, Symbol = "🐷", Description = "Gris", LevelId = 2 },
                new Emoji { Id = 27, Symbol = "🐸", Description = "Groda", LevelId = 2 },
                new Emoji { Id = 28, Symbol = "🐵", Description = "Apa", LevelId = 2 },
                new Emoji { Id = 29, Symbol = "🦄", Description = "Enhörning", LevelId = 2 },
                new Emoji { Id = 30, Symbol = "🐔", Description = "Kyckling", LevelId = 2 },

                // Level 3 (Expressions)
                new Emoji { Id = 31, Symbol = "😉", Description = "Blinkar", LevelId = 3 },
                new Emoji { Id = 32, Symbol = "😏", Description = "Flinar", LevelId = 3 },
                new Emoji { Id = 33, Symbol = "🙃", Description = "Oseriös", LevelId = 3 },
                new Emoji { Id = 34, Symbol = "🤔", Description = "Tänker", LevelId = 3 },
                new Emoji { Id = 35, Symbol = "😋", Description = "Njuter", LevelId = 3 },
                new Emoji { Id = 36, Symbol = "😜", Description = "Busig", LevelId = 3 },
                new Emoji { Id = 37, Symbol = "🤭", Description = "Fnissar", LevelId = 3 },
                new Emoji { Id = 38, Symbol = "😛", Description = "Skämtar", LevelId = 3 },
                new Emoji { Id = 39, Symbol = "😎", Description = "Cool", LevelId = 3 },
                new Emoji { Id = 40, Symbol = "😂", Description = "Skrattar", LevelId = 3 },
                new Emoji { Id = 41, Symbol = "🤩", Description = "Imponerad", LevelId = 3 },
                new Emoji { Id = 42, Symbol = "🥹", Description = "Rörd", LevelId = 3 },
                new Emoji { Id = 43, Symbol = "🤤", Description = "Dreglar", LevelId = 3 },
                new Emoji { Id = 44, Symbol = "🫠", Description = "Smälter", LevelId = 3 },
                new Emoji { Id = 45, Symbol = "🤮", Description = "Kräks", LevelId = 3 },

                // Level 4 (Food & Drink)
                new Emoji { Id = 46, Symbol = "🍎", Description = "Äpple", LevelId = 4 },
                new Emoji { Id = 47, Symbol = "🍕", Description = "Pizza", LevelId = 4 },
                new Emoji { Id = 48, Symbol = "🍔", Description = "Hamburgare", LevelId = 4 },
                new Emoji { Id = 49, Symbol = "🍦", Description = "Glass", LevelId = 4 },
                new Emoji { Id = 50, Symbol = "🍩", Description = "Munk", LevelId = 4 },
                new Emoji { Id = 51, Symbol = "🍉", Description = "Vattenmelon", LevelId = 4 },
                new Emoji { Id = 52, Symbol = "🍟", Description = "Pommes", LevelId = 4 },
                new Emoji { Id = 53, Symbol = "🍰", Description = "Tårta", LevelId = 4 },
                new Emoji { Id = 54, Symbol = "🍫", Description = "Choklad", LevelId = 4 },
                new Emoji { Id = 55, Symbol = "🍺", Description = "Öl", LevelId = 4 },
                new Emoji { Id = 56, Symbol = "🍵", Description = "Te", LevelId = 4 },
                new Emoji { Id = 57, Symbol = "🍿", Description = "Popcorn", LevelId = 4 },
                new Emoji { Id = 58, Symbol = "🍆", Description = "Aubergine", LevelId = 4 },
                new Emoji { Id = 59, Symbol = "🍓", Description = "Jordgubb", LevelId = 4 },
                new Emoji { Id = 60, Symbol = "🍑", Description = "Persika", LevelId = 4 },

                // Level 5 (Leisure & Sports)
                new Emoji { Id = 61, Symbol = "⚽", Description = "Fotboll", LevelId = 5 },
                new Emoji { Id = 62, Symbol = "🏀", Description = "Basket", LevelId = 5 },
                new Emoji { Id = 63, Symbol = "🏈", Description = "Rugby", LevelId = 5 },
                new Emoji { Id = 64, Symbol = "🎾", Description = "Tennis", LevelId = 5 },
                new Emoji { Id = 65, Symbol = "🏓", Description = "Pingis", LevelId = 5 },
                new Emoji { Id = 66, Symbol = "🏸", Description = "Badminton", LevelId = 5 },
                new Emoji { Id = 67, Symbol = "🏊", Description = "Simning", LevelId = 5 },
                new Emoji { Id = 68, Symbol = "🚴", Description = "Cykling", LevelId = 5 },
                new Emoji { Id = 69, Symbol = "🧗", Description = "Klättring", LevelId = 5 },
                new Emoji { Id = 70, Symbol = "🏄", Description = "Surfing", LevelId = 5 },
                new Emoji { Id = 71, Symbol = "🏂", Description = "Snowboard", LevelId = 5 },
                new Emoji { Id = 72, Symbol = "🏒", Description = "Hockey", LevelId = 5 },
                new Emoji { Id = 73, Symbol = "🥊", Description = "Boxning", LevelId = 5 },
                new Emoji { Id = 74, Symbol = "🤸", Description = "Gymnastik", LevelId = 5 },
                new Emoji { Id = 75, Symbol = "🤾", Description = "Handboll", LevelId = 5 },

                // Level 6 (Jobs & Work)
                new Emoji { Id = 76, Symbol = "👨‍⚕️", Description = "Läkare", LevelId = 6 },
                new Emoji { Id = 77, Symbol = "👩‍🏫", Description = "Lärare", LevelId = 6 },
                new Emoji { Id = 78, Symbol = "👨‍🍳", Description = "Kock", LevelId = 6 },
                new Emoji { Id = 79, Symbol = "👩‍🔧", Description = "Mekaniker", LevelId = 6 },
                new Emoji { Id = 80, Symbol = "👨‍🚒", Description = "Brandman", LevelId = 6 },
                new Emoji { Id = 81, Symbol = "👩‍✈️", Description = "Pilot", LevelId = 6 },
                new Emoji { Id = 82, Symbol = "👨‍⚖️", Description = "Domare", LevelId = 6 },
                new Emoji { Id = 83, Symbol = "👩‍🎨", Description = "Konstnär", LevelId = 6 },
                new Emoji { Id = 84, Symbol = "👨‍🔬", Description = "Forskare", LevelId = 6 },
                new Emoji { Id = 85, Symbol = "👩‍💻", Description = "Programmerare", LevelId = 6 },
                new Emoji { Id = 86, Symbol = "👨‍🏭", Description = "Svetsare", LevelId = 6 },
                new Emoji { Id = 87, Symbol = "👩‍🚀", Description = "Astronaut", LevelId = 6 },
                new Emoji { Id = 88, Symbol = "👨‍🎤", Description = "Artist", LevelId = 6 },
                new Emoji { Id = 89, Symbol = "👩‍🌾", Description = "Bonde", LevelId = 6 },
                new Emoji { Id = 90, Symbol = "👮", Description = "Polis", LevelId = 6 },

                // Level 7 (Transport & Vehicles)
                new Emoji { Id = 91, Symbol = "🚗", Description = "Bil", LevelId = 7 },
                new Emoji { Id = 92, Symbol = "🚕", Description = "Taxi", LevelId = 7 },
                new Emoji { Id = 93, Symbol = "🚌", Description = "Buss", LevelId = 7 },
                new Emoji { Id = 94, Symbol = "🚎", Description = "Spårvagn", LevelId = 7 },
                new Emoji { Id = 95, Symbol = "🚓", Description = "Polis", LevelId = 7 },
                new Emoji { Id = 96, Symbol = "🚑", Description = "Ambulans", LevelId = 7 },
                new Emoji { Id = 97, Symbol = "🚒", Description = "Brandbil", LevelId = 7 },
                new Emoji { Id = 98, Symbol = "🚐", Description = "Van", LevelId = 7 },
                new Emoji { Id = 99, Symbol = "🚚", Description = "Lastbil", LevelId = 7 },
                new Emoji { Id = 100, Symbol = "🚲", Description = "Cykel", LevelId = 7 },
                new Emoji { Id = 101, Symbol = "🛴", Description = "Sparkcykel", LevelId = 7 },
                new Emoji { Id = 102, Symbol = "🛵", Description = "Moped", LevelId = 7 },
                new Emoji { Id = 103, Symbol = "🏍️", Description = "Motorcykel", LevelId = 7 },
                new Emoji { Id = 104, Symbol = "🚂", Description = "Tåg", LevelId = 7 },
                new Emoji { Id = 105, Symbol = "✈️", Description = "Flygplan", LevelId = 7 },

                // Level 8 (Nature & Weather)
                new Emoji { Id = 106, Symbol = "🌞", Description = "Sol", LevelId = 8 },
                new Emoji { Id = 107, Symbol = "🌧️", Description = "Regn", LevelId = 8 },
                new Emoji { Id = 108, Symbol = "⛈️", Description = "Oväder", LevelId = 8 },
                new Emoji { Id = 109, Symbol = "🌈", Description = "Regnbåge", LevelId = 8 },
                new Emoji { Id = 110, Symbol = "🌪️", Description = "Tornado", LevelId = 8 },
                new Emoji { Id = 111, Symbol = "🌻", Description = "Solros", LevelId = 8 },
                new Emoji { Id = 112, Symbol = "🌳", Description = "Träd", LevelId = 8 },
                new Emoji { Id = 113, Symbol = "🌲", Description = "Gran", LevelId = 8 },
                new Emoji { Id = 114, Symbol = "🌵", Description = "Kaktus", LevelId = 8 },
                new Emoji { Id = 115, Symbol = "🌴", Description = "Palm", LevelId = 8 },
                new Emoji { Id = 116, Symbol = "🌸", Description = "Blomma", LevelId = 8 },
                new Emoji { Id = 117, Symbol = "🌙", Description = "Måne", LevelId = 8 },
                new Emoji { Id = 118, Symbol = "🍂", Description = "Löv", LevelId = 8 },
                new Emoji { Id = 119, Symbol = "🦋", Description = "Fjäril", LevelId = 8 },
                new Emoji { Id = 120, Symbol = "❄️", Description = "Snö", LevelId = 8 },

                // Level 9 (Places & Buildings)
                new Emoji { Id = 121, Symbol = "🏟️", Description = "Arena", LevelId = 9 },
                new Emoji { Id = 122, Symbol = "🏡", Description = "Villa", LevelId = 9 },
                new Emoji { Id = 123, Symbol = "🏖️", Description = "Strand", LevelId = 9 },
                new Emoji { Id = 124, Symbol = "🏝️", Description = "Ö", LevelId = 9 },
                new Emoji { Id = 125, Symbol = "🏤", Description = "Station", LevelId = 9 },
                new Emoji { Id = 126, Symbol = "🏥", Description = "Sjukhus", LevelId = 9 },
                new Emoji { Id = 127, Symbol = "🏦", Description = "Bank", LevelId = 9 },
                new Emoji { Id = 128, Symbol = "🏨", Description = "Hotell", LevelId = 9 },
                new Emoji { Id = 129, Symbol = "🏞️", Description = "Park", LevelId = 9 },
                new Emoji { Id = 130, Symbol = "🏪", Description = "Butik", LevelId = 9 },
                new Emoji { Id = 131, Symbol = "🏫", Description = "Skola", LevelId = 9 },
                new Emoji { Id = 132, Symbol = "🏬", Description = "Köpcenter", LevelId = 9 },
                new Emoji { Id = 133, Symbol = "🏭", Description = "Fabrik", LevelId = 9 },
                new Emoji { Id = 134, Symbol = "🏯", Description = "Tempel", LevelId = 9 },
                new Emoji { Id = 135, Symbol = "🏰", Description = "Slott", LevelId = 9 },

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