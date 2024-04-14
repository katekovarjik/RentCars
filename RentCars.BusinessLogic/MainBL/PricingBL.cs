using RentCars.BusinessLogic.Core.Levels;
using RentCars.BusinessLogic.Interfaces;
using RentCars.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCars.BusinessLogic.DBModel.Seed;

namespace RentCars.BusinessLogic.MainBL
{
    public class PricingBL: UserAPI, IPricing
    {
        private readonly ProductContext _productcontext;

        public PricingBL()
        {
        }

        public PricingBL(ProductContext productcontext)
        {
            _productcontext = productcontext;
        }
        public List<CarProductData> SortProducts(string sortOrder)
        {
            if (sortOrder == "descending")
                return DescSort();
            else 
                return SortCars();
        }
        




    }
}
