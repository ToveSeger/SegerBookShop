using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegerBookShop.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterVerification(string Name, string Password, string Passwordverify)
        {
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var register = api.Register(Name, Password, Passwordverify);
            if (register == true)
            {
                return View("RegisterVerification");
            }
            return View("RegistrationFailed");
        }
    }
}
