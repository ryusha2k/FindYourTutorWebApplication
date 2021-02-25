using System.ComponentModel.DataAnnotations;

namespace FindYourTutorWebApp.Models.ViewModels
{
    public class LoginViewModel : AccountViewModel
    {
        [Required]
        public bool RememberUser { get; set; }
    }
}
