using System.ComponentModel.DataAnnotations;

namespace FindYourTutorWebApp.Models.ViewModels
{
    public abstract class AccountViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}