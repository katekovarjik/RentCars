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
    public class CarsBL : UserAPI, ICars
    {
        private readonly ProductContext _productcontext;

        public CarsBL()
        {
        }

        public CarsBL(ProductContext productcontext)
        {
            _productcontext = productcontext;
        }
        

    }
}
