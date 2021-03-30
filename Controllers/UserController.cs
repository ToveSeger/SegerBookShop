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
        BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();        
        public IActionResult Index(User obj)
        {
            return View();
        }     

        public ActionResult UserList(int adminId, User obj)
        {
            //adminId = SaveAdminId(adminId);
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
        public IActionResult Create(int adminId, User obj)
        {
            if (ModelState.IsValid)
            {
                //adminId = SaveAdminId(adminId);
                var newUser = api.AddUser(adminId, obj.Name, obj.Password);
                var objList = new List<User>();
                objList.Add(obj);
                return View("UserListWithoutButtons", objList);
            }
            return View("CreationFailed");
        }
      
       public IActionResult FindUser(int adminId, string keyword)
       {
            //adminId = SaveAdminId(adminId);
            var searchResult = api.FindUser(adminId, keyword).ToList();
            return View("UserList",searchResult);
       }

        public IActionResult Promote(User obj)
        {
            return View(FindUserToSendToView(obj));
           
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Promote(int adminId, User obj)
        {
           // adminId = SaveAdminId(adminId);
            var inactivation = api.Promote(adminId, obj.Id);
            if (inactivation == true)
            {
                return View("RequestDone");
            }
            return View(NotFound());

        }
        public IActionResult Demote(User obj)
        {
            return View(FindUserToSendToView(obj));
          
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Demote(int adminId, User obj)
        {
            //adminId = SaveAdminId(adminId);
            var activation = api.Demote(adminId, obj.Id);
            if (activation == true)
            {
                return View("RequestDone");
            }
            return View(NotFound());
        }
        public IActionResult Activate(User obj)
        {
            return View(FindUserToSendToView(obj));          
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Activate(int adminId, User obj)
        {
            //adminId = SaveAdminId(adminId);
            var activation = api.ActivateUser(adminId, obj.Id);
            if (activation==true)
            {
                return View("RequestDone");
            }
            return View(NotFound());
        }
        public IActionResult Inactivate(User obj)
        {
            return View(FindUserToSendToView(obj));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Inactivate(int adminId, User obj)
        {
            //adminId = SaveAdminId(adminId);
            var inactivation = api.InactivateUser(adminId, obj.Id);
            if (inactivation == true)
            {
                return View("RequestDone");
            }
            return View(NotFound());
        }
        /// <summary>
        /// Finds a user to be able to send user object to post view
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>user object</returns>

        public User FindUserToSendToView(User obj)
        {
            var adminId = 0;
            if (TempData.ContainsKey("adminId"))
                adminId = Convert.ToInt32(TempData["adminId"]);
            TempData.Keep("adminId");
            var user = api.FindUser(adminId, obj.Id);
            return user;
        }
        /// <summary>
        /// Saves admin Id in Temp Data to be able to pass it forward to access all admin methods
        /// </summary>
        /// <param name="adminId"></param>
        /// <returns>admin Id</returns>
        //public int SaveAdminId(int adminId)
        //{
        //    adminId = 0;
        //    if (TempData.ContainsKey("adminId"))
        //        adminId = Convert.ToInt32(TempData["adminId"]);
        //    TempData.Keep("adminId");
        //    return adminId;
        //}
    }
}
