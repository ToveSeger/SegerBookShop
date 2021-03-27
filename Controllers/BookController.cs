using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using BookShop.Models;

namespace SegerBookShop.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }        

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

        public async Task<IActionResult> MatchingAuthorList(string keyword)
        {
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var searchResult = api.GetAuthors(keyword).ToList();
            return View(searchResult);
        }

        public IActionResult AllBooks(int adminId)
        {
            adminId = 0;
            if (TempData.ContainsKey("adminId"))
                adminId = Convert.ToInt32(TempData["adminId"]);
            TempData.Keep("adminId");
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var bookList = api.GetBookList(adminId);
            return View(bookList);
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
        public IActionResult Create(Book obj)
        {
            if (ModelState.IsValid)
            {
                var adminId = 0;
                if (TempData.ContainsKey("adminId"))
                    adminId = Convert.ToInt32(TempData["adminId"]);
                BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
                var newUser = api.AddBook(adminId, obj.Title, obj.Author, obj.Price, obj.Amount);
                var objList = new List<Book>();
                objList.Add(obj);
                return View("AllBooks", objList);
            }
            return View("CreationFailed");
        }
        public IActionResult Update(int Id, int adminId)
        {
            adminId = 0;
            if (TempData.ContainsKey("adminId"))
                adminId = Convert.ToInt32(TempData["adminId"]);
            TempData.Keep("adminId");
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var thisBook = api.GetBook(Id);
            if (Id == 0)
            {
                return NotFound();
            }
            return View(thisBook[0]);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Book obj)
        {
            if (ModelState.IsValid)
            {
                var adminId = 0;
                if (TempData.ContainsKey("adminId"))
                    adminId = Convert.ToInt32(TempData["adminId"]);
                TempData.Keep("adminId");
                BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
                var newUser = api.UpdateBook(adminId, obj.Id, obj.Title, obj.Author, obj.Price);
                var objList = new List<Book>();
                objList.Add(obj);
                return View("AllBooks", objList);
            }
            return View("CreationFailed");
        }
        public IActionResult Delete(int Id, int adminId)
        {
            adminId = 0;
            if (TempData.ContainsKey("adminId"))
                adminId = Convert.ToInt32(TempData["adminId"]);
            TempData.Keep("adminId");
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var thisBook = api.GetBook(Id);
            if (Id == 0)
            {
                return NotFound();
            }
            return View(thisBook[0]);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Book obj)
        {
            if (ModelState.IsValid)
            {
                var adminId = 0;
                if (TempData.ContainsKey("adminId"))
                    adminId = Convert.ToInt32(TempData["adminId"]);
                TempData.Keep("adminId");
                BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
                var newUser = api.DeleteBook(adminId, obj.Id);
                var objList = new List<Book>();
                objList.Add(obj);
                return View("DeletionOk");
            }
            return View("CreationFailed");
        }

        public IActionResult AllAvailableBooks(int id)
        {                       
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var bookList = api.GetAvailableBooks(id);
            return View("AvailableBooks", bookList);            
        }

        public IActionResult BuyBook(Book obj)
        {            
            var id = 0;
            if (TempData.ContainsKey("id"))
                id = Convert.ToInt32(TempData["id"]);
            TempData.Keep("id");
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var boughtBook = api.BuyBook(id, obj.Id);
            if (boughtBook==true)
            {
                return View();
            }
            return View("BuyFailed");           
        }

        public IActionResult StockCorrection(int Id, int adminId) 
        {
            adminId = 0;
            if (TempData.ContainsKey("adminId"))
                adminId = Convert.ToInt32(TempData["adminId"]);
            TempData.Keep("adminId");
            BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
            var thisBook = api.GetBook(Id);
            if (Id == 0)
            {
                return NotFound();
            }
            return View(thisBook[0]);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult StockCorrection(Book obj)
        {
            if (ModelState.IsValid)
            {
                var adminId = 0;
                if (TempData.ContainsKey("adminId"))
                    adminId = Convert.ToInt32(TempData["adminId"]);
                TempData.Keep("adminId");
                BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
                obj.Amount = api.SetAmount(adminId, obj.Id, obj.Amount);
                var objList = new List<Book>();
                objList.Add(obj);
                return View("AllBooks", objList);
            }
            return View("CreationFailed");
        }
      
    }
}
