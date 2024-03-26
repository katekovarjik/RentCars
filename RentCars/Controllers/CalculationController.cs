using RentCars.BusinessLogic.Interfaces;
using RentCars.Domain.Entities.Calculation;
using RentCars.Domain.Entities.GeneralResponses;
using RentCars.Domain.Entities.User;
using RentCars.Models;
using System;
using System.Collections.Generic;
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
            var calcData = new CalcDataDays
            {
                takeDay = data.takeDayPr,
                returnDay = data.returnDayPr,
            };
            int responce = _calculation.CalculateDays(calcData);
            return View();
        }


        
    }
}