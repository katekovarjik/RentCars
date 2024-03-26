using RentCars.Domain.Entities.Calculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.Interfaces
{
    public interface ICalculation
    {
        int CalculateDays(CalcDataDays days);
       
    }
}
