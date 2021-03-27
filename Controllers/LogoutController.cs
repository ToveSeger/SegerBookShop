using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegerBookShop.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogoutOk(int id, int adminId)
        {
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            if (TempData.ContainsKey("adminId"))
            {
                adminId = Convert.ToInt32(TempData["adminId"]);
                var logout = api.Logout(adminId);
                if (logout == true)
                {
                    return View();
                }
            }
            if (TempData.ContainsKey("id"))
            {
                id = Convert.ToInt32(TempData["id"]);
                var logout = api.Logout(id);
                if (logout == true)
                {
                    return View();
                }
            }
                
            return View("LogoutFailed");
        }
    }
}
