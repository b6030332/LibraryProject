using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.Book
{
    public class BookDetailModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public long ISBN { get; set; }
        public string DeweyClassification { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }
        public string PatronName { get; set; }
        public Withdrawal LatestWithdrawal { get; set; }
        public IEnumerable<WithdrawalHistory> WithdrawalHistory { get; set; }



    }
}