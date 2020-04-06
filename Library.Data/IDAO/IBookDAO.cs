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

        
    }
}
