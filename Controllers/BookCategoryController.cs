using BookShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegerBookShop.Controllers
{
    public class BookCategoryController : Controller
    {
        BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListAllCategories()
        {
            var searchResult = api.GetCategories().ToList();
            return View(searchResult);
        }
        public IActionResult ShowCategoryResults(int id)
        {
            var searchResult = api.GetCategory(id).ToList();
            return View(searchResult);
        }


        public IActionResult ShowCategoryResultsWithKeyword(string keyword)
        {
            var searchResult = api.GetCategories(keyword).ToList();
            return View("ShowCategoryResultsWithKeyword", searchResult);
        }

        public IActionResult Delete(int Id, int adminId, BookCategory obj)
        {           
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(BookCategory obj)
        {
            if (ModelState.IsValid)
            {
                var adminId = 0;
                if (TempData.ContainsKey("adminId"))
                    adminId = Convert.ToInt32(TempData["adminId"]);
                TempData.Keep("adminId");
                var deletion= api.DeleteCategory(adminId, obj.Id);
                if (deletion==true)
                {
                return View("DeletionOk");
                }
            }
            return View("DeletionFailed");
        }

        public IActionResult Update(int id, int adminId)
        {
            adminId = 0;
            if (TempData.ContainsKey("adminId"))
                adminId = Convert.ToInt32(TempData["adminId"]);
            TempData.Keep("adminId");
            BookCategory category = api.FindCategory(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(BookCategory obj)
        {
            if (ModelState.IsValid)
            {
                var adminId = 0;
                if (TempData.ContainsKey("adminId"))
                    adminId = Convert.ToInt32(TempData["adminId"]);
                TempData.Keep("adminId");
                var update = api.UpdateCategory(adminId, obj.Id, obj.Name);
                var objList = new List<BookCategory>() { obj};
                return View("ListAllCategories", objList);
            }
            return View(NotFound());
        }

        public IActionResult Create(int adminId)
        {
            adminId = SaveAdminId(adminId);
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int adminId, BookCategory obj)
        {
            if (ModelState.IsValid)
            {
                adminId = SaveAdminId(adminId);
                var newUser = api.AddCategory(adminId, obj.Name);
                var objList = new List<BookCategory>();
                objList.Add(obj);
                return View("ListAllCategories", objList);
            }
            return View("CreationFailed");
        }

        /// <summary>
        /// Saves admin Id in Temp Data to be able to pass it forward to access all admin methods
        /// </summary>
        /// <param name="adminId"></param>
        /// <returns>admin Id</returns>
        public int SaveAdminId(int adminId)
        {
            adminId = 0;
            if (TempData.ContainsKey("adminId"))
                adminId = Convert.ToInt32(TempData["adminId"]);
            TempData.Keep("adminId");
            return adminId;
        }
    
    }   
}
