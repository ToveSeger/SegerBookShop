using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;


namespace SegerBookShop.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult ShowSearchResults(int id)
        //{
        //    BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
        //    var searchResult = api.GetBook(id).FirstOrDefault();
        //    return View();
        //}

        public async Task<IActionResult> ShowSearchResults(int id)
        {
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var searchResult = api.GetBook(id).ToList();          
            return View(searchResult);
        }

        public async Task<IActionResult> ShowSearchResultsWithKeyword(string keyword)
        {
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var searchResult = api.GetBooks(keyword).ToList();
            return View(searchResult);
        }
    }
}
