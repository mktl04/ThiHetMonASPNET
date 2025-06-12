using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWeb_NguyenLeMinhKhoi.Models;

namespace TestWeb_NguyenLeMinhKhoi.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _hosting;
        public BookController(AppDbContext db, IWebHostEnvironment hosting)
        {
            _db = db;
            _hosting = hosting;
        }
        public IActionResult Index()
        {
            var bookList = _db.Books.ToList();
            return View(bookList);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Add(book);
                _db.SaveChanges();
                TempData["success"] = "Product inserted success";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Update(int id)
        {
            var book = _db.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }
        [HttpPost]
        public IActionResult Update(Book book)
        {
            if (ModelState.IsValid)
            {
                var existingBook = _db.Books.Find(book.Id);

                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Price = book.Price;
                existingBook.Quantity = book.Quantity;
                _db.SaveChanges();
                TempData["success"] = "Product updated success";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            var book = _db.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = _db.Books.Find(id);
            _db.Books.Remove(book);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
