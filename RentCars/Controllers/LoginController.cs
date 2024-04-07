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

        public ActionResult LogIn(LoginData data)
        {
            // Создаем объект UserLoginData для передачи данных в метод проверки аутентификации
            var uLoginData = new UserLoginData
            {
                Credential = data.UserName, // Получаем имя пользователя из формы входа
                Password = data.Password, // Получаем пароль пользователя из формы входа
                IP = "", // Можно добавить IP-адрес пользователя, если необходимо
                FirstLoginTime = DateTime.Now // Записываем текущее время как время первого входа
            };

            // Вызываем метод для проверки аутентификации пользователя
            RResponseData responce = _session.UserLoginAction(uLoginData);

            // Проверяем, что ответ не равен null и пароль из ответа совпадает с введенным пользователем паролем
            if (responce != null && responce.CurrentUser != null && responce.CurrentUser.Password == uLoginData.Password)
            {
                // Если аутентификация прошла успешно, сохраняем имя пользователя в сессии
                Session["UserName"] = responce.CurrentUser.UserName;
                // Перенаправляем пользователя на страницу с автомобилями
                return RedirectToAction("Car", "Home");
            }
            else
            {
                // Если аутентификация не удалась, добавляем сообщение об ошибке в модель состояния
                ModelState.AddModelError("", "Ошибка аутентификации. Пожалуйста, проверьте свои учетные данные и попробуйте снова.");
                // Возвращаем представление с формой входа, чтобы пользователь мог попробовать снова
                return View();
            }
        }

    }
}