using Library.Data.IDAO;
using Library.Data.Models;
using Library.Models.Book;
using Library.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace Library.Controllers
{
    public class BookController : Controller
    {
        private IBookDAO _dao;
        public BookController()
        {
            _dao = new BookService();
        }
        public ActionResult GetBooks()
        {
            var bookModels = _dao.GetBooks();

            var listingResult = bookModels
                .Select(result => new BookListingModel
                {
                    Id = result.Id,
                    Image = result.Image,
                    Title = result.Title,
                    Author = result.Author,
                    DeweyClassification = result.DeweyClassification,
            });
            var model = new BookModel()
            {
                Books = listingResult
            };

            return View(model);


        }
        public ActionResult GetBook(int id)
        {
            var book = _dao.GetBook(id);

            var model = new BookDetailModel()
            {
                BookId = id,
                Title = book.Title,
                Year = book.Year,
                Status = book.Status.Name,
                Image = book.Image,
                Author = book.Author,
                DeweyClassification = book.DeweyClassification,
                ISBN = book.ISBN
            };
            return View(model);
        }
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
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

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Book/Delete/5
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
