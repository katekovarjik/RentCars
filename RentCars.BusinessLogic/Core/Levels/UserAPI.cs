using RentCars.BusinessLogic.DBModel.Seed;
using RentCars.Domain.Entities.GeneralResponses;
using RentCars.Domain.Entities.Product;
using RentCars.Domain.Entities.Product.DB;
using RentCars.Domain.Entities.User;
using RentCars.Domain.Enum.Roles;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
                user = DbContext.Users.FirstOrDefault(u => u.UserName == data.Credential);
            }


            // Проверка, найден ли пользователь
            if (user != null)
            {
                if(VerifyPassword(user.Password, data.Password))
                {
                    return new RResponseData
                    {
                        Status = true,
                        CurrentUser = user
                    };
                }
                // Создание объекта RResponseData с данными текущего пользователя
               
            }
                // Создание объекта RResponseData с сообщением об ошибке
            return new RResponseData { 
                Status = false, 
                ResponceMessage = "Invalid credentials" };
            
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
                Password = HashPassword(NewUser.Password),
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

        public string HashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string passwordHash = Convert.ToBase64String(hashBytes);
            return passwordHash;
        }
        public bool VerifyPassword(string savedPasswordHash, string passwordToCheck)
        {
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(passwordToCheck, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                    return false;
            }
            return true;
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
