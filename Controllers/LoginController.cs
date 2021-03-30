using BookShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegerBookShop.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {                      
            return View();
        }
        public IActionResult LoginVerification(string Name, string Password)
        {
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var login = api.Login(Name, Password);
            if (login != 0)
            {                
                TempData["id"] = login;
                TempData.Keep();
                return View("LoginVerification", login);
            }           
                return View("LoginFailed");          
        }

        //public User KeepLoginDetails(User obj)
        //{
        //    if (TempData.ContainsKey("adminCheck"))
        //        obj.IsAdmin = Convert.ToBoolean(TempData["adminCheck"]);
        //    if (TempData.ContainsKey("adminId"))
        //        obj.Id = Convert.ToInt32(TempData["adminId"]);
        //    TempData.Keep();
        //    return obj;
        //}
    }
}
