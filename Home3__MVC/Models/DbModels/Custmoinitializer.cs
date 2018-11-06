using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;




using Microsoft.AspNet.Identity.Owin;


namespace Home3__MVC.Models
{
    internal class CustomInitializer<T> : DropCreateDatabaseAlways<ApplicationContext>
    {
        private ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }
        protected override void Seed(ApplicationContext _ctx)
        {
            _ctx.Products.AddRange(new List<Product>
            {
                new Product("Paperoni", 70, "Pepperoni sausages, mozzarella cheese, olive oil, basil, tomato sauce", "https://images.pizza33.ua/products/product/POCpLYdcgVA34bcde4pK8JEjSWITKbtk.jpg"),
                new Product("Chipollo", 80, "Pepperoni sausages, mozzarella cheese, olive oil, basil, tomato sauce", "https://images.pizza33.ua/products/product/yQfkJqZweoLn9omo68oz5BnaGzaIE0UJ.jpg"),
                new Product("Diablo", 90, "Pepperoni sausages, mozzarella cheese, olive oil, basil, tomato sauce", "https://images.pizza33.ua/products/product/yQfkJqZweoLn9omo68oz5BnaGzaIE0UJ.jpg")
            });
            ApplicationUser user = new ApplicationUser { UserName = "test", Email = "test@test.test", PhoneNumber = "+380988545888", Address = "testAddr", Gender = "male" };
            UserManager.CreateAsync(user, "Qwerty_123");
            _ctx.SaveChanges();
        }
    }
}