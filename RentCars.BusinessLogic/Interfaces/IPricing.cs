using RentCars.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.Interfaces
{
    public interface IPricing
    {
        List<CarProductData> SortProducts(string SOrder); // возвращает модель с домэйна
        List<CarProductData> GetAllCars();
    }
}
