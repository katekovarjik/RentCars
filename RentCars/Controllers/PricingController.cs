using RentCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentCars.BusinessLogic.Interfaces;
using RentCars.BusinessLogic.DBModel.Seed;
using RentCars.Domain.Entities.Product;


namespace RentCars.Controllers
{
    public class PricingController : Controller
    {
        private readonly IPricing _pricing;
        public PricingController()
        {
            var logicBl = new BusinessLogic.BusinessLogic();
            _pricing = logicBl.GetPricingBL();
        }
        // GET: Pricing
        

        public ActionResult Pricing(string sortOrder)
        {
            List<CarProductData> sortedCars;

            if (sortOrder == null)
            {
               sortedCars  = _pricing.GetAllCars();
            }
            else
            {
                sortedCars = _pricing.SortProducts(sortOrder);
            }
            //var sortedCars = _pricing.SortProducts(sortOrder);
            var viewModelList = new List<CarProductModel>();
            foreach (var carProduct in sortedCars)
            {
                var viewModel = new CarProductModel
                {
                    ProductName = carProduct.ProductName,
                    ProductBrand = carProduct.ProductBrand,
                    ProductPrice = carProduct.ProductPrice,
                    ProductYear = carProduct.ProductYear,
                    ProductImage =carProduct.Image,
                };
                viewModelList.Add(viewModel);

            }

           
            return View(viewModelList);
        }
    }
}