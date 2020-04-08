using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.IDAO
{
    public interface IBookDAO
    {
        IEnumerable<Book> GetBooks();

        Book GetBook(int id);

        IList<Book> GetAllBooks();

        void UpdateBook(Book book);

        void AddBook(Book book);

        void DeleteBook(Book book);


        
    }
}
