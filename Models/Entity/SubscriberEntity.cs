using System.ComponentModel.DataAnnotations;

namespace Crito.Models.Entity
{
    public class SubscriberEntity
    {
        [Key]
        public required string Email { get; set; } 
    }
}
