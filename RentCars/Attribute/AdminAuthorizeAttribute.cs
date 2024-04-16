using System;
using System.Linq;
using System.Web.Mvc;
using RentCars.BusinessLogic.DBModel.Seed;
using RentCars.Domain.Enum.Roles;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
public class AdminAuthorizeAttribute : AuthorizeAttribute
{
    public override void OnAuthorization(AuthorizationContext filterContext)
    {
        // Получаем имя пользователя из контекста аутентификации (сеанса)
        string userName = filterContext.HttpContext.Session["UserName"] as string;

        // Проверяем роль пользователя в базе данных
        using (var dbContext = new UserContext())
        {
            var user = dbContext.Users.FirstOrDefault(u => u.UserName == userName);
            if (user != null && user.Level == URole.Admin)
            {
                // Пользователь является администратором, ничего не делаем
            }
            else
            {
                // Пользователь не является администратором, перенаправляем на страницу с ошибкой доступа
                HandleUnauthorizedRequest(filterContext);
            }
        }
    }

    protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
    {
        filterContext.Result = new ViewResult { ViewName = "AccessDenied" }; // Здесь "AccessDenied" - это имя вашего представления для ошибки доступа
    }
}
