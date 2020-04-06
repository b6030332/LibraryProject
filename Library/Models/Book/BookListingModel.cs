using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.Book
{
    public class BookListingModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string DeweyClassification { get; set; }
        public int Quantity { get; set; }
    }
}