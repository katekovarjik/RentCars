using RentCars.BusinessLogic.Interfaces;
using RentCars.BusinessLogic;
using RentCars.Domain.Entities.User;
using RentCars.Domain.Enum.Roles;
using RentCars.Models;
using System.Web.Mvc;
using System;
using RentCars.BusinessLogic.DBModel.Seed;
using System.Linq;

public class RegisterController : Controller
{
    private readonly IRegister _register;

    public RegisterController()
    {
        var logicBl = new BusinessLogic();
        _register = logicBl.GetRegisterBL(); // Получение сервиса для регистрации
    }

    [HttpGet]
    public ActionResult Register()
    {
        return View(); // Отображение представления для регистрации
    }

    [HttpPost]
    public ActionResult Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Проверяем, нет ли уже пользователя с таким именем в базе данных
            if (_register.IsUserNameTaken(model.UserName))
            {
                ModelState.AddModelError("UserName", "Username is already taken.");
                return View(model);
            }

            UserRegisterData registerInfo = new UserRegisterData()
            {

                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                IP = Request.UserHostAddress,
                FirstLoginTime = DateTime.Now,

            };

            _register.CreateUser(registerInfo);
            // Перенаправляем пользователя на страницу входа после успешной регистрации
            return RedirectToAction("LogIn", "Login");
        }

        // Если модель не валидна, возвращаем представление с ошибками
        return View(model);
    }
}
