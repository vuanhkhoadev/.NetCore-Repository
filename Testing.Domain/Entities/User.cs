using System.ComponentModel.DataAnnotations;

namespace Testing.Domain.Entities
{
    public class User: BaseEntity
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public byte[] PasswordHash { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }
    }
}
