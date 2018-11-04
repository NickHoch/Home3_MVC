using Microsoft.AspNet.Identity.EntityFramework;

namespace Home3__MVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Gender { get; set; }
        public string Address { get; set; }
        public ApplicationUser() {}
    }
}