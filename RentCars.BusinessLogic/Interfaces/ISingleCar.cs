using RentCars.Domain.Entities.Calculation;
using RentCars.Domain.Entities.Product.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.Interfaces
{
    public interface ISingleCar
    {
        ProductDbTable GetCarById(int id);
        Task<(int, int)> CalculateDays(CalcDataDays days, int price);

    }
}
