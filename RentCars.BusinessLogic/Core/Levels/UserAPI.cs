using RentCars.Domain.Entities.GeneralResponses;
using RentCars.Domain.Entities.Product;
using RentCars.Domain.Entities.Product.DB;
using RentCars.Domain.Entities.User;
using RentCars.Domain.Entities.User.DB;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.Core.Levels
{
    public class UserAPI
    {
        public RResponseData UALSessionCheck(UserLoginData data)
        {

            //db connection 
            //select user from db
            // if select valid or true
            //return status = true

            return new RResponseData { CurrentUser = new DBUser {UserName = "Olga",
                Email = "olga.lutcenco@isa.utm.md" , 
            Password = "12345"} };
        }
        public ProductDataModel ProductActionGetToList()
        {
            var products = new List<Product>();

            return new ProductDataModel {Products = products };


        }
    }
}
