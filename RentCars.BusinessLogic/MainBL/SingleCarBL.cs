using RentCars.BusinessLogic.Core.Levels;
using RentCars.BusinessLogic.DBModel.Seed;
using RentCars.BusinessLogic.Interfaces;
using RentCars.Domain.Entities.Calculation;
using RentCars.Domain.Entities.Product.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.MainBL
{
    public class SingleCarBL : UserAPI, ISingleCar
    {
        private readonly ProductContext _productcontext;

        public SingleCarBL()
        {
        }

        public SingleCarBL(ProductContext productcontext)
        {
            _productcontext = productcontext;
        }
        public ProductDbTable GetCarById(int id)
        {
            // Получаем машину по идентификатору из базы данных
            return GetCar(id);
        }
        public async Task<(int, int)> CalculateDays(CalcDataDays days, int price)
        {
            // логика вычесть дни 
            TimeSpan difference = days.returnDay.Subtract(days.takeDay);

            // Получаем количество дней в разнице
            int daysDifference = (int)difference.TotalDays;
            int totalPrice = daysDifference * price;

            return (daysDifference, totalPrice);
        }

    }
}
