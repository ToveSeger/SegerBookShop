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
        public async Task<IActionResult> LoginVerification(string userName, string passWord) //Fortsätt här, fel vy returneras
        {
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var login = api.Login(userName, passWord);
            if (login != 0)
            {
                return View("LoginVerification", login);
            }
           
                return View("LoginFailed");
           

        }
    }
}
