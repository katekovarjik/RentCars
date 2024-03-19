using eUseControl.Domain.Entities.Auth;
using eUseControl.Domain.Entities.GeneralResponce;
using eUseControl.Domain.Entities.User;
using eUseControl.Domain.Entities.User.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BussinesLogic.Core.Levels
{
    public class UserAPI
    {
        internal RResponceData ULASessionCheck(ULoginData data)
        {

            //db connection
            //SELECT USER FROM DB>User WHERE Username=data.Credential and Password= data.Password
            // if SELECT VALID or TRUE

            //RETURN status = true
            return new RResponceData {
                Status = false,
                CurrentUser = new User
                {
                    UserName = "Vasilica"
                }
            };
        }

        internal UCookieData UserCookieGenerationAlg(User user)
        {

            //Logic Coockie generation process

            return new UCookieData
            {
                MaxAge = 1709044385,
                Cookies = "MY UNIQUE ID FOR THIS SESSION"
            };
        }
    }
}

