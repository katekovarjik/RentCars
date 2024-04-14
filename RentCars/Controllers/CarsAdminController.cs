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
            return View();
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
                return RedirectToAction("LogIn", "Login");
            }

            // Если модель не валидна, возвращаем представление с ошибками
            return View(Model);
        }
    }
}