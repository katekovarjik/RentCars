using RentCars.BusinessLogic.DBModel.Seed;
using RentCars.Domain.Entities.GeneralResponses;
using RentCars.Domain.Entities.Product;
using RentCars.Domain.Entities.Product.DB;
using RentCars.Domain.Entities.User;
using RentCars.Domain.Enum.Roles;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        //Sort Cars
        public List<CarProductData> GetCars()
        {
            var DbContext = new ProductContext();

            // Получаем все машины из базы данных
            var allCars = DbContext.Products
                .Select(car => new CarProductData
                {
                    ProductName = car.Name,
                    ProductPrice = car.Price,
                    ProductBrand = car.Brand,
                    ProductYear = car.Year,
                    Image = car.Image,
                })
                .ToList();

            return allCars;
        }
       
        public List<CarProductData> SortCars()
        {
            var DbContext = new ProductContext();
            // Получаем все машины из базы данных и сортируем их по возрастанию года выпуска
            var sortedCars = DbContext.Products
                .OrderBy(car => car.Price)
                .Select(car => new CarProductData
                {
                    ProductName = car.Name,
                    ProductPrice = car.Price,
                    ProductBrand = car.Brand,
                    ProductYear = car.Year,
                    Image = car.Image,

                })
                .ToList();

            return sortedCars;
        }
        public List<CarProductData> DescSort()
        {
            var DbContext = new ProductContext();
            // Получаем все машины из базы данных и сортируем их по убыванию года выпуска
            var sortedCars = DbContext.Products
                .OrderByDescending(car => car.Price)
                .Select(car => new CarProductData
                {
                    ProductName = car.Name,
                    ProductPrice = car.Price,
                    ProductBrand = car.Brand,
                    ProductYear = car.Year,
                    Image = car.Image,

                })
                .ToList();

            return sortedCars;
        }
        //_________________
        public ProductDbTable GetCar(int id)
        {
            var DbContext = new ProductContext();
            var car = DbContext.Products.FirstOrDefault(p => p.Id == id);

            return car;
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
                Level = URole.User,
            };

            using (var DbContext = new UserContext())
            {
                DbContext.Users.Add(newUser);
                DbContext.SaveChanges();


            }
        }


        // Search Car
        public List<CarProductData> Search()
        {
            using (var dbContext = new ProductContext())
            {
                // Получаем все машины из базы данных и сортируем их по бренду
                var searchedCars = dbContext.Products
                    .OrderBy(car => car.Brand)
                    .Select(car => new CarProductData
                    {
                        ProductName = car.Name,
                        ProductPrice = car.Price,
                        ProductBrand = car.Brand,
                        ProductYear = car.Year,
                        Image = car.Image
                    })
                    .ToList();

                return searchedCars;
            }
        }



    }
}
