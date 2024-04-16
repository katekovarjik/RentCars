using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentCars.BusinessLogic.DBModel.Seed;
using RentCars.Domain.Entities.Product;
using RentCars.Domain.Entities.Product.DB;

namespace RentCars.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Cars()
        {
            List<ProductDbTable> cars;

            using (var dbContext = new ProductContext())
            {
                cars = dbContext.Products.ToList();
            }

            return View(cars);
        }

    }
}