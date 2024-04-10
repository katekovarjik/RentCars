using RentCars.Domain.Entities.User;
using System;

namespace RentCars.BusinessLogic.Interfaces
{
    public interface IRegister
    {
        bool IsEmailRegistered(string email); // Метод для проверки зарегистрирован ли email в базе данных
        bool IsUserNameTaken(string userName); // Метод для проверки занятости имени пользователя

        void CreateUser(UserRegisterData NewUser);
    }
}
