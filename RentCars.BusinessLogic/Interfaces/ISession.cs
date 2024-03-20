using RentCars.Domain.Entities.GeneralResponses;
using RentCars.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.Interfaces
{
    public interface ISession
    { 
        RResponseData UserLoginAction(UserLoginData data); // объявлен метод который будем использовать 
    }
}
