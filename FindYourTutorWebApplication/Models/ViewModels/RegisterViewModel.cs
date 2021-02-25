using System.ComponentModel.DataAnnotations;

namespace FindYourTutorWebApp.Models.ViewModels
{
    public class RegisterViewModel : AccountViewModel
    {
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердите пароль")]
        [Compare("Password",
            ErrorMessage = "Пароли должны совпадать")]
        public string ConfirmPassword { get; set; }
    }
}