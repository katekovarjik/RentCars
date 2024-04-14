using RentCars.BusinessLogic.Interfaces;
using RentCars.Domain.Entities.Product;
using RentCars.Domain.Entities.User;
using RentCars.Models;
using RentCars.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentCars.BusinessLogic.DBModel.Seed;
using RentCars.Domain.Entities.Product.DB;

namespace RentCars.Controllers
{
    public class CarsAdminController : Controller
    {

        private readonly IAddCar _addcar;

        public CarsAdminController() 
        {
            var logicBl = new BusinessLogic.BusinessLogic();
            _addcar = logicBl.GetAddCarBL();
        }
        

        // GET: CarsAdmin
        public ActionResult CarsAdmin()
        {
            List<ProductDbTable> cars;

            using (var dbContext = new ProductContext())
            {
                cars = dbContext.Products.ToList();
            }

            return View(cars);
        }

        [HttpPost]
        public ActionResult DeleteCar(int carId)
        {
            using (var dbContext = new ProductContext())
            {
                var carToDelete = dbContext.Products.FirstOrDefault(c => c.Id == carId);
                if (carToDelete != null)
                {
                    dbContext.Products.Remove(carToDelete);
                    dbContext.SaveChanges();
                }
            }

            return RedirectToAction("CarsAdmin"); // Перенаправление на страницу со списком товаров после удаления
        }





        public ActionResult AddCar() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCar(CarProductModel Model) 
        {
            if (ModelState.IsValid) // проверка если вся форма заполнена правильно
            {

                CarProductData CarInfo = new CarProductData()
                {

                    ProductName = Model.ProductName,
                    ProductPrice = Model.ProductPrice,
                    ProductBrand = Model.ProductBrand,
                    ProductYear = Model.ProductYear,

                };


                _addcar.CreateNewProduct(CarInfo);
                // Перенаправляем пользователя на страницу входа после успешной регистрации
                return RedirectToAction("CarsAdmin", "CarsAdmin");
            }

            // Если модель не валидна, возвращаем представление с ошибками
            return View(Model);
        }
    }
}