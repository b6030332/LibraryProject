using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.Book
{
    public class BookModel
    {
        public IEnumerable<BookListingModel> Books { get; set; }
    }
}