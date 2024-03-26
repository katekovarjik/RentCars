using RentCars.BusinessLogic.Interfaces;
using RentCars.Domain.Entities.Calculation;
using RentCars.BusinessLogic.Core.Levels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.MainBL
{
    public class CalculationBL:ICalculation
    {
        public int CalculateDays(CalcDataDays days)
        {
            // логика вычесть дни 
            TimeSpan difference = days.returnDay - days.takeDay;

            // Количество дней в разнице
            int daysDifference = (int)difference.TotalDays;

            return daysDifference;
        }
    }
}
