using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Home3__MVC.Models
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("IdentityDb")
        {
            Database.SetInitializer<ApplicationContext>(new CustomInitializer<ApplicationContext>());
        }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ItemOrder> ItemOrders { get; set; }
        public virtual DbSet<ContactInfo> ContactInfos { get; set; }
    }
}