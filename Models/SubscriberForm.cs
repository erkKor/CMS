using System.ComponentModel.DataAnnotations;

namespace Crito.Models;

public class SubscriberForm
{
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email adress")]
    public string Email { get; set; } = null!;
}
