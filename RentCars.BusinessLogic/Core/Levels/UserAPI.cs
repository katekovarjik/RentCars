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
        internal RResponseData UALSessionCheck(UserLoginData data)
        {

            //db connection 
            //select user from db
            // if select valid or true
            //return status = true

            return new RResponseData { CurrentUser = new DBUser {UserName = "Olga",
                Email = "olga.lutcenco@isa.utm.md" , 
            Password = "12345"} };
        }

        //______________________
        //products

        internal ProductDataModel ProductActionGetToList()
        {
            var products = new List<Product>(); // list of products from DB
            ProductDataModel pr1 = new ProductDataModel();   // это для тренировки без бд
            pr1.SingleProduct = new Product(); // это для тренировки без бд..инициализация объекта SingleProduct
            pr1.SingleProduct.Name = "Let's Test";
            //pull out products 
            //return new ProductDataModel {Products = products };
            return pr1;

        }

        internal  ProductDataModel GetSingleAction(int id)
        {
            // select from DB where id = id
            var product = new Product();
            return new ProductDataModel { SingleProduct = product };
            /*return new ProductDataModel
            {
                SingleProduct = new Product
                {
                    Name = "Let's Test",
                    Price = 110
                }
            };*/
        }


    }
}
