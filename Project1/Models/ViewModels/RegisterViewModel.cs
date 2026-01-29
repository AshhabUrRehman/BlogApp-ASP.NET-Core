using System.ComponentModel.DataAnnotations;

namespace Project1.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email is a Required Field")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is a Required Field")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password must match the ConfirmPassword")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
