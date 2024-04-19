using RentCars.BusinessLogic.Interfaces;
using RentCars.Domain.Entities.Calculation;
using RentCars.Domain.Entities.GeneralResponses;
using RentCars.Domain.Entities.User;
using RentCars.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace RentCars.Controllers
{
    public class CalculationController : Controller
    {
        internal ICalculation _calculation;
        public CalculationController()
        {
            var logicBl = new BusinessLogic.BusinessLogic();
            _calculation = logicBl.GetCalculationBL(); // можем "тянуть функционал из бизнес логики"

        }
        // GET: Calculation
        public ActionResult Index() //calc
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculation(DaysData data)
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
                ModelState.AddModelError("", "Invalid date format. Please enter dates in the format 'M/d/yyyy'.");
                return View();
            }

            // Продолжайте с вашей логикой
            int response = _calculation.CalculateDays(calcData);



            if (response != 0)
            {
                ViewData["CalculatedDays"] = response;
                return View();
            }
            return View();
        }


        
    }
}