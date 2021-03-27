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
        public async Task<IActionResult> LoginVerification(string Name, string Password)
        {
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var login = api.Login(Name, Password);
            if (login != 0)
            {                
                TempData["id"] = login;
                TempData.Keep("id");
                return View("LoginVerification", login);
            }           
                return View("LoginFailed");          
        }
    }
}
