using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Home3__MVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Gender { get; set; }
        public string Address { get; set; }
        public ApplicationUser() {}

        
    }


    //public static class ApplicationUserHelepr
    //{
    //   public static LocalUserModel Select(this ApplicationUser appUser)
    //    {
    //        return new LocalUserModel
    //        {
    //            Name = appUser.UserName,
    //            Address = appUser.Address,
    //            Phone = appUser.PhoneNumber
    //        };
    //    }
    //}

    //public class LocalUserModel
    //{
    //    public string Name { get; set; }
    //    public string Address { get; set; }
    //    public string Phone { get; set; }
    //}
}