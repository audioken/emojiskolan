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
                new Emoji { Id = 1, Symbol = "🙂", Description = "Glad", LevelId = 1 },
                new Emoji { Id = 2, Symbol = "😢", Description = "Ledsen", LevelId = 1 },
                new Emoji { Id = 3, Symbol = "😠", Description = "Arg", LevelId = 1 },
                new Emoji { Id = 4, Symbol = "😍", Description = "Kär", LevelId = 1 },
                new Emoji { Id = 5, Symbol = "😮", Description = "Förvånad", LevelId = 1 },
                new Emoji { Id = 6, Symbol = "😉", Description = "Blinkar", LevelId = 1 },
                new Emoji { Id = 7, Symbol = "😎", Description = "Cool", LevelId = 1 },
                new Emoji { Id = 8, Symbol = "😂", Description = "Skrattar", LevelId = 1 },
                new Emoji { Id = 9, Symbol = "😇", Description = "Snäll", LevelId = 1 },
                new Emoji { Id = 10, Symbol = "😴", Description = "Sover", LevelId = 1 },
                new Emoji { Id = 11, Symbol = "😊", Description = "Nöjd", LevelId = 2 },
                new Emoji { Id = 12, Symbol = "🤔", Description = "Tänker", LevelId = 2 },
                new Emoji { Id = 13, Symbol = "😃", Description = "Entusiastisk", LevelId = 2 },
                new Emoji { Id = 14, Symbol = "😕", Description = "Förvirrad", LevelId = 2 },
                new Emoji { Id = 15, Symbol = "😅", Description = "Nervös", LevelId = 2 },
                new Emoji { Id = 16, Symbol = "🙃", Description = "Upp och ner", LevelId = 2 },
                new Emoji { Id = 17, Symbol = "😌", Description = "Lugn", LevelId = 2 },
                new Emoji { Id = 18, Symbol = "🤗", Description = "Kram", LevelId = 2 },
                new Emoji { Id = 19, Symbol = "😋", Description = "Gott", LevelId = 2 },
                new Emoji { Id = 20, Symbol = "😏", Description = "Flinar", LevelId = 2 }
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