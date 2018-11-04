using Home3__MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home3__MVC.Controllers
{
    public class HomeController : Controller
    {
        public static ApplicationContext _ctx = new ApplicationContext();
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel(_ctx.Products.ToList());
            model.OrderList = Session["OrderList"] as string;
            model.TotalSum = Session["TotalSum"] as string;
            if (Session["Bucket"] != null)
            {
                var bucket = Session["Bucket"] as List<ItemOrder>;
                Session["Bucket"] = null;
                Session["Bucket"] = bucket;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult MakeOrder(string clientName, string clientNumber)
        {
            HomeViewModel model = new HomeViewModel(_ctx.Products.ToList());
            Order order = new Order
            {
                Info = new ContactInfo
                {
                    Name = clientName,
                    PhoneNumber = clientNumber
                },
                Items = Session["Bucket"] as List<ItemOrder>
            };
            _ctx.Orders.Add(order);
            _ctx.SaveChanges();
            Session["OrderList"] = null;
            Session["TotalSum"] = null;
            return View("Index", model);
        }

        [HttpPost]
        public ActionResult AddToBucket(int? id, int? quantity, string orderItem, string totalSum)
        {
            if (id != null && quantity != null)
            {
                Session["TotalSum"] = null;
                Session["TotalSum"] = totalSum;
                Session["OrderList"] += orderItem;

                if (Session["Bucket"] == null)
                {
                    Session["Bucket"] = new List<ItemOrder>
                    {
                        new ItemOrder
                        {
                            Product = _ctx.Products.SingleOrDefault(x => x.Id == id),
                            Quantity = (int)quantity
                        }
                    };
                }
                else
                {
                    var bucket = Session["Bucket"];
                    var bucketList = bucket as List<ItemOrder>;
                    bucketList.Add(new ItemOrder
                    {
                        Product = _ctx.Products.SingleOrDefault(x => x.Id == id),
                        Quantity = (int)quantity
                    });
                    Session["Bucket"] = null;
                    Session["Bucket"] = bucketList;
                }
            }
            HomeViewModel model = new HomeViewModel(_ctx.Products.ToList());
            return View("Index", model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}