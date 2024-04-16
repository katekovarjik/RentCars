using RentCars.BusinessLogic.DBModel.Seed;
using RentCars.Domain.Entities.Product.DB;
using RentCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentCars.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About() 
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }


        public ActionResult Contact()
        {
            Contact user1 = new Contact();
            user1.UserName = "Test";
            user1.Email = "Test";
            user1.Subject = "Test";
            user1.Message = "TestM";
            return View(user1);
        }

        [HttpPost]
        public ActionResult Check(string buttom) { 
            return RedirectToAction("Index", "Home", new { buttom });
        }

        public ActionResult Pricing()
        {
            return View();
        }
        /*public ActionResult Cars()
        {
            return View();
        }*/

        /* public ActionResult Cars()
         {
             List<ProductDbTable> cars;

             using (var dbContext = new ProductContext())
             {
                 cars = dbContext.Products.ToList();
             }

             return View(cars);
         }*/

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult BlogSingle()
        {
            return View();
        }
        public ActionResult CarSingle()
        {
            return View();
        }

      
    }
}