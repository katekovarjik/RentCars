using eUseControl.BussinesLogic.Interfaces;
using eUseControl.Domain.Entities.Auth;
using eUseControl.Domain.Entities.GeneralResponce;
using eUseControl.Domain.Entities.User;
using RentCars.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace RentCars.Controllers
{
    public class LoginController : Controller
    {

        internal ISession _session;

        public LoginController()
        {
            
            var logicBl = new eUseControl.BussinesLogic.BussinesLogic();

            _session = logicBl.GetSessionBL();
        }





        // GET: Logic
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginData data)
        {

            var uLoginData = new ULoginData
            {
                Credential = data.Username,
                Password = data.Password,
                Ip = "",
                FirstLoginTime = DateTime.Now
            };

            RResponceData responce = _session.UserLoginAction(uLoginData);
            if (responce != null && responce.Status)
            {
                //логка тут Cookie Generation
                UCookieData cData = _session.GenCookieAlgo(responce.CurrentUser);

                if (cData != null)
                {
                    //set coockie to user browser
                }
            }


            return View();
        }
    }
}