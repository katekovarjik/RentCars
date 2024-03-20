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

        public ActionResult Car()
        {
            if (Session["UserName"] != null)
            {
                ViewData["UserName"] = Session["UserName"];
            }
            Car car = new Car();
            car.Name = "WWW";
            car.Cars = new List<string> { "Grand Sedan Cheverolet", "Range Rover Subaru", "Mercedes Grand Sedan Cheverolet" };
            return View(car);
        }
        [HttpPost]
        public ActionResult Car(string btn)
        {
            return RedirectToAction("CarSingle", "Home", new {@p = btn});

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