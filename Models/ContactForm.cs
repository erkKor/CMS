using System.ComponentModel.DataAnnotations;

namespace Crito.Models;

public class ContactForm
{
	[Required(ErrorMessage = "You must enter a name")]
	[MinLength(2, ErrorMessage = "Name must contain atleast 2 characters")]
	public string Name { get; set; } = null!;

	[Required(ErrorMessage = "You must enter an email")]
	[EmailAddress]
	[RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "You must enter a valid emailadress")]
	public string Email { get; set; } = null!;

    [Required(ErrorMessage = "You must enter a message")]
	[MinLength(10, ErrorMessage = "Your message must be atleast 10 characters long")]
	public string Message { get; set; } = null!;

    public string RedirectUrl { get; set; } = "/contact";
}
