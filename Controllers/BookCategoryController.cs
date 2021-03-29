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
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ListAllCategories()
        {
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var searchResult = api.GetCategories().ToList();
            return View(searchResult);
        }
        public async Task<IActionResult> ShowCategoryResults(int id)
        {
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var searchResult = api.GetCategory(id).ToList();
            return View(searchResult);
        }


        public async Task<IActionResult> ShowCategoryResultsWithKeyword(string keyword)
        {
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
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
                BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
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
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
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
                BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
                var update = api.UpdateCategory(adminId, obj.Id, obj.Name);
                var objList = new List<BookCategory>() { obj};
                return View("ListAllCategories", objList);
            }
            return View(NotFound());
        }
    }   
}
