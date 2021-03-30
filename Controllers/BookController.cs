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
        BookShop.WebbShopAPI api = new BookShop.WebbShopAPI();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowSearchResults(int id)
        {           
            var searchResult = api.GetBook(id).ToList();
            return View(searchResult);
        }

        public IActionResult ShowSearchResultsWithKeyword(string keyword)
        {
            var searchResult = api.GetBooks(keyword).ToList();
            return View(searchResult);
        }

        public IActionResult MatchingAuthorList(string keyword)
        {
            var searchResult = api.GetAuthors(keyword).ToList();
            return View(searchResult);
        }

        public IActionResult AllBooks(int adminId)
        {
            adminId = 0;
            if (TempData.ContainsKey("adminId"))
                adminId = Convert.ToInt32(TempData["adminId"]);
            TempData.Keep("adminId");
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
        public IActionResult Create(int adminId, Book obj)
        {
            if (ModelState.IsValid)
            {
                //var adminId = 0;
                //if (TempData.ContainsKey("adminId"))
                //    adminId = Convert.ToInt32(TempData["adminId"]);
                var newUser = api.AddBook(adminId, obj.Title, obj.Author, obj.Price, obj.Amount);
                var objList = new List<Book>();
                objList.Add(obj);
                return View("AllBooks", objList);
            }
            return View("CreationFailed");
        }
        public IActionResult Update(int Id, int adminId)
        {
            //adminId = 0;
            //if (TempData.ContainsKey("adminId"))
            //    adminId = Convert.ToInt32(TempData["adminId"]);
            //TempData.Keep("adminId");
            var thisBook = api.GetBook(Id);
            if (Id == 0)
            {
                return NotFound();
            }
            return View(thisBook[0]);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int adminId, Book obj)
        {
            if (ModelState.IsValid)
            {
                //var adminId = 0;
                //if (TempData.ContainsKey("adminId"))
                //    adminId = Convert.ToInt32(TempData["adminId"]);
                //TempData.Keep("adminId");
                var newUser = api.UpdateBook(adminId, obj.Id, obj.Title, obj.Author, obj.Price);
                var objList = new List<Book>();
                objList.Add(obj);
                return View("AllBooks", objList);
            }
            return View("CreationFailed");
        }
        public IActionResult Delete(int Id, int adminId)
        {
            //adminId = 0;
            //if (TempData.ContainsKey("adminId"))
            //    adminId = Convert.ToInt32(TempData["adminId"]);
            //TempData.Keep("adminId");
            var thisBook = api.GetBook(Id);
            if (Id == 0)
            {
                return NotFound();
            }
            return View(thisBook[0]);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int adminId, Book obj)
        {
            if (ModelState.IsValid)
            {
                //var adminId = 0;
                //if (TempData.ContainsKey("adminId"))
                //    adminId = Convert.ToInt32(TempData["adminId"]);
                //TempData.Keep("adminId");
                api.DeleteBook(adminId, obj.Id);
                var objList = new List<Book>();
                objList.Add(obj);
                return View("DeletionOk");
            }
            return View("CreationFailed");
        }

        public IActionResult AllAvailableBooks(int id)
        {
            var bookList = api.GetAvailableBooks(id);
            return View("AvailableBooks", bookList);
        }

        public IActionResult BuyBook(int id, Book obj)
        {       
            if (TempData.ContainsKey("id"))
                id = Convert.ToInt32(TempData["id"]);
            TempData.Keep();
            var boughtBook = api.BuyBook(id, obj.Id);
            if (boughtBook == true)
            {
                return View();
            }
            return View("BuyFailed");
        }

        public IActionResult StockCorrection(int Id, int adminId)
        {
            //adminId = 0;
            //if (TempData.ContainsKey("adminId"))
            //    adminId = Convert.ToInt32(TempData["adminId"]);
            //TempData.Keep("adminId");
            var thisBook = api.GetBook(Id);
            if (Id == 0)
            {
                return NotFound();
            }
            return View(thisBook[0]);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult StockCorrection(int adminId, Book obj)
        {
            if (ModelState.IsValid)
            {
                //var adminId = 0;
                //if (TempData.ContainsKey("adminId"))
                //    adminId = Convert.ToInt32(TempData["adminId"]);
                //TempData.Keep("adminId");
                obj.Amount = api.SetAmount(adminId, obj.Id, obj.Amount);
                var objList = new List<Book>();
                objList.Add(obj);
                return View("AllBooks", objList);
            }
            return View("CreationFailed");
        }
        public IActionResult AddBookToCategory()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddBookToCategory(int adminId, Book obj)
        {
            if (ModelState.IsValid)
            {
                //var adminId = 0;
                //if (TempData.ContainsKey("adminId"))
                //    adminId = Convert.ToInt32(TempData["adminId"]);
                //TempData.Keep("adminId");
                var added = api.AddBookToCategory(adminId, obj.Id, obj.CategoryId);
                if (added == true)
                {
                    return View("BookAddedToCategory");
                }
            }
            return View("CreationFailed");
        }
    }
}
