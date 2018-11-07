using System.ComponentModel.DataAnnotations;

namespace Home3__MVC.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter login")]
        [EmailAddress(ErrorMessage = "Login is no valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        //[StringLength(20, MinimumLength = 5, ErrorMessage = "The quantity of the characters must be in the range of 5 to 20 symbols")]
        public string Password { get; set; }
    }
}