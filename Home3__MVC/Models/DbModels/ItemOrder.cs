﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home3__MVC.Models
{
    public class ItemOrder
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}