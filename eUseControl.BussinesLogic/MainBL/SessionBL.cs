using eUseControl.BussinesLogic.Core.Levels;
using eUseControl.BussinesLogic.Interfaces;
using eUseControl.Domain.Entities.Auth;
using eUseControl.Domain.Entities.GeneralResponce;
using eUseControl.Domain.Entities.User;
using eUseControl.Domain.Entities.User.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BussinesLogic.MainBL
{
    public class SessionBL : UserAPI, ISession
    {
        public UCookieData GenCookieAlgo(User dataUser)
        {
            throw new NotImplementedException();
        }

        public  RResponceData UserLoginAction(ULoginData data)
        {
            return ULASessionCheck(data);
        }
    }
}
