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

        // GET: BookAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookAdmin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
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
            ViewBag.Status = new SelectList(_statusService.GetStatus(), "Id", "Name", book.Status);
            return View(book);
        }
       
        // POST: BookAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Book book)
        {
            _bookService.UpdateBook(book);

            try
            {
                _bookService.UpdateBook(book);


                return RedirectToAction("GetBooks", "Book", book);
            }
            catch
            {
                return View();
            }
        }

        // GET: BookAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
