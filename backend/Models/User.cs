using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace backend.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? PasswordHash { get; set; }
        [Required]
        public int AvatarId { get; set; }
        public List<Record>? Records { get; set; } = new();
    }

}