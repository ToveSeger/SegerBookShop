using BookShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegerBookShop.Controllers
{
    public class AdminLoginController : Controller
    {      
        public IActionResult Index(User obj)
        {
            obj = KeepAdminDetails(obj);        
            if (obj.IsAdmin==true && obj.Id!=0)
            {
                return View("LoginVerification");
            }
                return View();                                                      
        }
        /// <summary>
        /// Logs in an admin user.
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Password"></param>
        /// <returns>If success: login verification view, otherwhise: login failed view</returns>
        public IActionResult AdminLogin(string Name, string Password)
        {
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();            
            var adminCheck = api.CheckIfAdmin(Name, Password);           
            if (adminCheck == true)
            {
                var login = api.Login(Name, Password);
                TempData["adminId"] = login;
                TempData["adminCheck"] = adminCheck;
                TempData.Keep();
                return View("LoginVerification", adminCheck);
            }
            return View("LoginFailed");
        }

        public IActionResult LoginVerification()
        {
            return View();
        }

        public User KeepAdminDetails(User obj)
        {
            if (TempData.ContainsKey("adminCheck"))
                obj.IsAdmin = Convert.ToBoolean(TempData["adminCheck"]);
            if (TempData.ContainsKey("adminId"))
                obj.Id = Convert.ToInt32(TempData["adminId"]);
            TempData.Keep();
            return obj;
        }



    }
}
