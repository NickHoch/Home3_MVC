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
        //[StringLength(20, MinimumLength = 5, ErrorMessage = "The quantity of the characters must be in the range of 5 to 20 symbols")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password isn`t match")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "Please enter user name")]
        [RegularExpression(@"\w+", ErrorMessage = "Please use only letters, numbers and underscore symbols")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter phone number")]
        [RegularExpression(@"\+380\d{9}", ErrorMessage = "Phone number is not valid. Example: +380XX-XX-XX-XXX")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please select gender")]
        //[RegularExpression(@"male|female", ErrorMessage = "Gender is not valid. Example: male/female")]
        public bool Gender { get; set; }
    }
}