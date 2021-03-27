using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegerBookShop.Controllers
{
    public class AdminLoginController : Controller
    {
        public IActionResult Index()
        {           
                return View();                                                      
        }

        public async Task<IActionResult> AdminLogin(string Name, string Password)
        {
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();            
            var adminCheck = api.CheckIfAdmin(Name, Password);           
            if (adminCheck == true)
            {
                var login = api.Login(Name, Password);
                TempData["adminId"] = login;
                TempData.Keep("adminId");
                return View("LoginVerification", adminCheck);
            }
            return View("LoginFailed");
        }

        public IActionResult LoginVerification()
        {
            return View();
        }

      

      
    
    }
}
