using System.ComponentModel.DataAnnotations;

namespace Blog.BlazorServer.ViewModels.Auth
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Username must be between 2 and 15 characters")]
        public string Username { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Confrim password must be at least 6 characters long")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
