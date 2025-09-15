using System.Text.Json.Serialization;

namespace backend.Models
{
    public class Record
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LevelId { get; set; }
        public int Rounds { get; set; }
        public int Time { get; set; }
        [JsonIgnore]
        public User? User { get; set; }
        [JsonIgnore]
        public Level? Level { get; set; }
    }

}