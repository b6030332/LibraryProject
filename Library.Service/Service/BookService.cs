using Library.Data;
using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Library.Data.IDAO;

namespace Library.Service.Service
{
    public class BookService : IBookDAO
    {
        private LibraryContext _context;

        public BookService()
        {
            _context = new LibraryContext();
        }

        public void AddBook(Book book)
        {
            _context.Book.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            _context.Book.Remove(book);
            _context.SaveChanges();
        }

        public IList<Book> GetAllBooks()
        {
            return _context.Book.ToList();
        }

        public Book GetBook(int id)
        {
            return _context.Book
                .Include(book => book.Status)
                .FirstOrDefault(book => book.Id == id);
                
        }
        public IEnumerable<Book> GetBooks()
        {
            return _context.Book
                .Include(book => book.Status);
        }

        public void UpdateBook(Book book)
        {
            Book _book = GetBook(book.Id);
            _book.Image = book.Image; _book.Title = book.Title;
            _book.Author = book.Author; _book.Year = book.Year;
            _book.Publisher = book.Publisher; _book.Format = book.Format;
            _book.Price = book.Price; _book.Blurb = book.Blurb;
            _book.ISBN = book.ISBN; _book.DeweyClassification = book.DeweyClassification;
            _book.Status = _book.Status;
            _context.SaveChanges();
        }
    }
}
