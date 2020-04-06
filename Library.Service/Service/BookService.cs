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

        public Book GetBook(int id)
        {
            return _context.Book.Find(id);
        }
        public IEnumerable<Book> GetBooks()
        {
            return _context.Book
                .Include(book => book.Status);

        }

    }
}
