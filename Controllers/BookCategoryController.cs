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
            return View("ShowCategoryResultsWithKeyword",searchResult);                       
        }
    }
}
