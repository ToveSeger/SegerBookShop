using BookShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegerBookShop.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }     

        public ActionResult UserList()
        {
            int adminId=0;

            if (TempData.ContainsKey("adminId"))
                adminId = Convert.ToInt32(TempData["adminId"]);
            TempData.Keep("adminId");
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var userList = api.ListUsers(adminId);
            return View(userList);
        }

        public IActionResult Create(int adminId)
        {
            adminId = 0;
            if (TempData.ContainsKey("adminId"))
            adminId = Convert.ToInt32(TempData["adminId"]);
            TempData.Keep("adminId");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User obj)
        {
            if (ModelState.IsValid)
            {
                var adminId = 0;
                if (TempData.ContainsKey("adminId"))
                adminId = Convert.ToInt32(TempData["adminId"]);
                TempData.Keep("adminId");
                BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
                var newUser = api.AddUser(adminId, obj.Name, obj.Password);
                var objList = new List<User>();
                objList.Add(obj);
                return View("UserList", objList);
            }
            return View("CreationFailed");
        }
      
       public IActionResult FindUser(string keyword)
       {
            var adminId = 0;
            if (TempData.ContainsKey("adminId"))
                adminId = Convert.ToInt32(TempData["adminId"]);
            TempData.Keep("adminId");
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var searchResult = api.FindUser(adminId, keyword).ToList();
            return View("UserList",searchResult);
       }
              
    }
}
