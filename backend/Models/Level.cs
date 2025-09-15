using System.Text.Json.Serialization;

namespace backend.Models
{
    public class Level
    {
        public int Id { get; set; }
        public int Number { get; set; }

        [JsonIgnore]
        public ICollection<Emoji> Emojis { get; set; }
    }
}