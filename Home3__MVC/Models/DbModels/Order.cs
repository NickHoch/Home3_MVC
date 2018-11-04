using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home3__MVC.Models
{
    public class Order
    {
        public Order()
        {
            Items = new List<ItemOrder>();
        }
        public int Id { get; set; }
        public virtual ContactInfo Info { get; set; }
        public virtual ICollection<ItemOrder> Items { get; set; }
    }
}