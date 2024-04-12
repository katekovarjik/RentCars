using RentCars.BusinessLogic.Core.Levels;
using RentCars.BusinessLogic.DBModel.Seed;
using RentCars.BusinessLogic.Interfaces;
using RentCars.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.MainBL
{
    public class AddCarBL : AdminAPI, IAddCar
    {
        private readonly ProductContext _productcontext;

        public AddCarBL()
        {
        }

        public AddCarBL(ProductContext productcontext) 
        { 
            _productcontext = productcontext;
        }

        public void CreareProduct(CarProductData NewProduct)
        { 
            CreateNewProduct(NewProduct);
        }


    }
}
