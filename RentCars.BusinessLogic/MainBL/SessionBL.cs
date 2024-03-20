using RentCars.BusinessLogic.Core.Levels;
using RentCars.BusinessLogic.Interfaces;
using RentCars.Domain.Entities.GeneralResponses;
using RentCars.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCars.BusinessLogic.MainBL
{
    public class SessionBL : UserAPI, ISession
    {
        public RResponseData UserLoginAction(UserLoginData data) //здесь уже будут данные
        {
            return UALSessionCheck(data);  // return true or false depends on valid or not
        }
    }
}
