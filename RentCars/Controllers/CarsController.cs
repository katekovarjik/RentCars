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
        public ActionResult Cars(string productBrand)
        {
            List<ProductDbTable> cars;
            if(productBrand == null)
            {
                using (var dbContext = new ProductContext())
                {
                    cars = dbContext.Products.ToList();
                }
                return View(cars);
            }

            else
            {
                using (var dbContext = new ProductContext())
                {
                    var carsByBrand = dbContext.Products
                        .Where(car => car.Brand == productBrand)
                        .ToList();
                
                    return View(carsByBrand);
                }
            }

            
        }
        [HttpPost]
        public ActionResult SearchCar(string productBrand)
        {
            return RedirectToAction("Cars", new { productBrand });
        }
       

    }
}