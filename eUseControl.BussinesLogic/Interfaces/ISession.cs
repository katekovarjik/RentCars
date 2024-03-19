using eUseControl.Domain.Entities.Auth;
using eUseControl.Domain.Entities.GeneralResponce;
using eUseControl.Domain.Entities.User;
using eUseControl.Domain.Entities.User.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BussinesLogic.Interfaces
{
    public interface ISession
    {
        RResponceData UserLoginAction(ULoginData data);
        UCookieData GenCookieAlgo(User dataUser);

    }
}
