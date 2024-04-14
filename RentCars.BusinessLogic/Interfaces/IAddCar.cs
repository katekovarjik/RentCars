using RentCars.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.Interfaces
{
    public interface IAddCar
    {
        void CreateNewProduct(CarProductData CarInfo); //Метод добавления в базу данных


    }
}
