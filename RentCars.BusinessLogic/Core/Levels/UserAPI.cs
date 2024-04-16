using RentCars.BusinessLogic.DBModel.Seed;
using RentCars.Domain.Entities.GeneralResponses;
using RentCars.Domain.Entities.Product;
using RentCars.Domain.Entities.Product.DB;
using RentCars.Domain.Entities.User;
using RentCars.Domain.Enum.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.Core.Levels
{
    public class UserAPI
    {

        public UserAPI()
        {
        }

        internal RResponseData UALSessionCheck(UserLoginData data)
        {
            UDbTable user;

            using (var DbContext = new UserContext()) 
          
            {
                user = DbContext.Users.FirstOrDefault(u => u.Name == data.Credential && u.Password == data.Password);
            }


            // Проверка, найден ли пользователь
            if (user != null)
            {
                // Создание объекта RResponseData с данными текущего пользователя
                return new RResponseData {
                    Status = true,
                    CurrentUser = user,
                    };
            }
                // Создание объекта RResponseData с сообщением об ошибке
            return new RResponseData { Status = false, ResponceMessage = "Invalid credentials" };
            
        }

        //Login
        private RResponseData UALRegisterUser(UserRegisterData data)
        {
            throw new NotImplementedException();
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

        internal ProductDataModel GetSingleAction(int id)
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


        public bool IsUserNameExistAlready(string userName) 
        {
            UDbTable RegisterData;
            using (var DbContext = new UserContext()) 
            {
                RegisterData = DbContext.Users.FirstOrDefault(a => a.UserName == userName);
            }
            if (RegisterData != null) 
            {
                return true;
            }
            return false;

        }

        public void CreateNewUser(UserRegisterData NewUser) 
        {
            var newUser = new UDbTable
            {
                Name= NewUser.UserName,
                UserName = NewUser.UserName,
                Email = NewUser.Email,
                Password = NewUser.Password,
                LastLogin = DateTime.Now,
                LastIp = NewUser.IP,
                Level = URole.Admin,
            };

            using (var DbContext = new UserContext())
            {
                DbContext.Users.Add(newUser);
                DbContext.SaveChanges();


            }
        }


    }
}
