using System.ComponentModel.DataAnnotations;

namespace Crito.Models.Entity
{
    public class ContactUsEntity
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string Message { get; set; } = string.Empty;
    }
}
