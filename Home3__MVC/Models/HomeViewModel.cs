using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home3__MVC.Models
{
    public class HomeViewModel
    {
        public HomeViewModel(List<Product> products)
        {
            Products = products;
            Order = new Order();
        }
        public Order Order { get; set; }
        public List<Product> Products { get; set; }
        public string OrderList { get; set; }
        public string TotalSum { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}