using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Home3__MVC.Models
{
    internal class CustomInitializer<T> : DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext _ctx)
        {
            _ctx.Products.AddRange(new List<Product>
            {
                new Product("Paperoni", 70, "Pepperoni sausages, mozzarella cheese, olive oil, basil, tomato sauce", "https://images.pizza33.ua/products/product/POCpLYdcgVA34bcde4pK8JEjSWITKbtk.jpg"),
                new Product("Chipollo", 80, "Pepperoni sausages, mozzarella cheese, olive oil, basil, tomato sauce", "https://images.pizza33.ua/products/product/yQfkJqZweoLn9omo68oz5BnaGzaIE0UJ.jpg"),
                new Product("Diablo", 90, "Pepperoni sausages, mozzarella cheese, olive oil, basil, tomato sauce", "https://images.pizza33.ua/products/product/yQfkJqZweoLn9omo68oz5BnaGzaIE0UJ.jpg")
            });
            //_ctx.Users.Add(new ApplicationUser { Email="qwe@qwe.com",  Gender = "male", Address = "Rivne, str.Soborna", PhoneNumber = "+380987898455" });
            _ctx.SaveChanges();
        }
    }
}