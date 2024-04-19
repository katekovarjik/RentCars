using RentCars.BusinessLogic.Interfaces;
using RentCars.Domain.Entities.Calculation;
using RentCars.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RentCars.Controllers
{
    public class SingleCarController : Controller
    {
        // GET: SingleCar
        private readonly ISingleCar _carService;

        public SingleCarController()
        {
            var logicBl = new BusinessLogic.BusinessLogic();
            _carService = logicBl.GetSingleCarBL();
        }

         [HttpGet]
         public ActionResult SingleCar(int id)
         {
             
             // Получаем данные о машине по идентификатору
             var car = _carService.GetCarById(id);
        
             // Передаем модель машины в представление
             return View(car);
         }
        [HttpPost]
        
        public async Task<JsonResult> Calculation(DaysData data, int pr)
        {

            var calcData = new CalcDataDays();
            try
            {
                calcData.takeDay = DateTime.ParseExact(data.PickUpDate, "M/d/yyyy", CultureInfo.InvariantCulture);
                calcData.returnDay = DateTime.ParseExact(data.DropOffDate, "M/d/yyyy", CultureInfo.InvariantCulture);
            }
            catch (FormatException ex)
            {
                // Обработка ошибки парсинга даты
                // Например, возврат пользователю сообщения об ошибке
                return Json(new { success = false, message = "Invalid date format. Please enter dates in the format 'M/d/yyyy'." });

            }

            // Продолжайте с вашей логикой
            (int, int) response = await _carService.CalculateDays(calcData, pr);
            

            if (response != (0, 0))
            {
                return Json(new { success = true, calculatedDays = response });

            }
            return Json(new { success = false, message = "Failed to calculate days." });

            
        }



        // public ActionResult SingleCar()
        // {
        //     return RedirectToAction("Cars", "Cars"); ;
        // }
        /*[HttpPost]
        public ActionResult SingleCar(int id)
        {
            return RedirectToAction("SingleCar", new { id });
        }*/
    }
}