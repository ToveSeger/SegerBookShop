using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegerBookShop.Controllers
{
    public class RevenueController : Controller
    {
        BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SoldItems(int adminId)
        {
            //adminId=SaveAdminId(adminId);
            var allSoldItems = api.SoldItems(adminId);
            return View(allSoldItems);
        }
        public IActionResult MoneyEarned(int adminId)
        {
           // adminId = SaveAdminId(adminId);
            var sumOfMoneyEarned = api.MoneyEarned(adminId);
            ViewData ["sumOfMoneyEarned"]= sumOfMoneyEarned;
            return View();
        }
        public IActionResult BestCustomer(int adminId)
        {
           // adminId = SaveAdminId(adminId);
            var theBestCustomer = api.BestCustomer(adminId);
            ViewData["theBestCustomer"] = theBestCustomer;
            return View(theBestCustomer);
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
