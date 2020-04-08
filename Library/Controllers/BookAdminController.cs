using Library.Data.IDAO;
using Library.Data.Models;
using Library.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class BookAdminController : Controller
    {
        private IBookDAO _bookService;
        private IStatusDAO _statusService;
        public BookAdminController()
        {
            _bookService = new BookService();
            _statusService = new StatusService();
        }
        
        
        
        // GET: BookAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddBook()
        {
          
            return View();
        }

        // POST: BookAdmin/Create
        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            try
            {
                _bookService.AddBook(book);

                return RedirectToAction("GetBooks", "Book", book);
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult UpdateBook(int id)
        {
            Book book = _bookService.GetBook(id);
            return View(book);
        }
       
        // POST: BookAdmin/Edit/5
        [HttpPost]
        public ActionResult UpdateBook(int id, Book book)
        {
                 
            try
            {
                 _bookService.UpdateBook(book);


                return RedirectToAction("GetBook", "Book", book);
            }
            catch
            {
                return View();
            }
        }

        // GET: BookAdmin/Delete/5
        [HttpGet]
        public ActionResult DeleteBook(int id)
        {
            return View(_bookService.GetBook(id));
        }

        // POST: BookAdmin/Delete/5
        [HttpPost]
        public ActionResult DeleteBook(int id, Book book)
        {
            try
            {
                Book books = _bookService.GetBook(id);
                _bookService.DeleteBook(books);

                return RedirectToAction("GetBooks", "Book", id);
            }
            catch
            {
                return View();
            }
        }
    }
}
