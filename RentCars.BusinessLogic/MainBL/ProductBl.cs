using RentCars.BusinessLogic.Core.Levels;
using RentCars.BusinessLogic.Interfaces;
using RentCars.Domain.Entities.GeneralResponses;
using RentCars.Domain.Entities.Product;
using RentCars.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.MainBL
{
    public class ProductBl : UserAPI,IProduct
    {
        public ProductDataModel GetProductsToList()
        {
            return ProductActionGetToList();
        }
    }
}
