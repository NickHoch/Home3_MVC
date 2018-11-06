using Home3__MVC.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Home3__MVC.Controllers
{
    public class HomeController : Controller
    {
        public static ApplicationContext _ctx = new ApplicationContext();

        private ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }
        public async Task<ActionResult> Index()
        {            
            HomeViewModel model = new HomeViewModel(_ctx.Products.ToList());
            model.OrderList = Session["OrderList"] as string;
            model.TotalSum = Session["TotalSum"] as string;
            ApplicationUser user = await UserManager.FindByNameAsync(User.Identity.Name);
            if(user != null)
            {
                model.Address = user.Address;
                model.PhoneNumber = user.PhoneNumber;
            }

            if (Session["Bucket"] != null)
            {
                var bucket = Session["Bucket"] as List<ItemOrder>;
                Session["Bucket"] = null;
                Session["Bucket"] = bucket;
            }
            return View(model);
        }

        public void MakeOrder(string clientName, string clientNumber)
        {
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
        }

        public void AddToBucket(int? id, int? quantity, string orderItem, string totalSum)
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
        }

        public bool CheckEmail(string email)
        {
            return false;
            //return _ctx.Users.Any(x => x.Email == email);
        }
    }
}