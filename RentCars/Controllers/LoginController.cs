using RentCars.BusinessLogic.Interfaces;
using RentCars.Domain.Entities.GeneralResponses;
using RentCars.Domain.Entities.User;
using RentCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace RentCars.Controllers
{
    public class LoginController : Controller
    {


        // GET: Login
        internal ISession _session;
        public LoginController()
        {
            var logicBl = new BusinessLogic.BusinessLogic();
            _session = logicBl.GetSessionBL(); // можем "тянуть функционал из бизнес логики"

        }
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(LoginData data) //получили пароль пользователя из View
        {

            var uLoginData = new UserLoginData
            {
                Credential = data.UserName, // берем данные которые ввел ползователь с ваб-а 
                Password = data.Password,
                IP = "",
                FirstLoginTime = DateTime.Now,

            };
            RResponseData responce = _session.UserLoginAction(uLoginData);

           if(responce != null && responce.CurrentUser.Password == uLoginData.Password)
            {
                Session["UserName"] = responce.CurrentUser.UserName;
                return RedirectToAction("Car", "Home");
            }
            ModelState.AddModelError("", "Ошибка аутентификации. Пожалуйста, проверьте свои учетные данные и попробуйте снова.");

            return View();
            
            
        }
    }
}