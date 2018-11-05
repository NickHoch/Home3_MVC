using System;
using System.ComponentModel.DataAnnotations;

namespace Home3__MVC.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Email is no valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "The quantity of the characters must be in the range of 5 to 20 symbols")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password isn`t match")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "Please enter user name")] // change to regexp
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter phone number")] // change to regexp
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter gender")] // change to regexp
        public string Gender { get; set; }
    }
}