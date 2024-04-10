using Microsoft.Win32;
using RentCars.BusinessLogic.Core.Levels;
using RentCars.BusinessLogic.DBModel.Seed;
using RentCars.BusinessLogic.Interfaces;
using RentCars.Domain.Entities.User;
using System.Linq;

namespace RentCars.BusinessLogic.MainBL
{
    public class RegisterBL :  UserAPI, IRegister
    {
        private readonly UserContext _context;

        public RegisterBL()
        {
        }

        public RegisterBL(UserContext context)
        {
            _context = context;
        }

        public bool IsEmailRegistered(string email)
        {
            // Логика проверки, зарегистрирован ли email в базе данных
            return _context.Users.Any(u => u.Email == email);
        }

        public bool IsUserNameTaken(string userName)
        {

            // Логика проверки, занято ли имя пользователя в базе данных
            return IsUserNameExistAlready(userName);

        }

        public void CreateUser(UserRegisterData NewUser) 
        {
            CreateNewUser(NewUser);
        }

        public void RegisterUser(UserRegisterData userData)
        {
            // Логика регистрации пользователя в базе данных
            // Создание нового пользователя на основе данных из userData и добавление его в базу данных
        }
    }
}
