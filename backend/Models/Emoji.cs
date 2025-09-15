namespace backend.Models
{
    public class Emoji
    {
        public int Id { get; set; }
        public string Symbol { get; set; }  // nvarchar(max) i SQL
        public string Description { get; set; } // nvarchar(max)
        public int LevelId { get; set; }
        public Level Level { get; set; }
    }
}