using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    public class Withdrawal
    {
        public int Id { get; set; }
        [Required]
        public Book Book { get; set; }
        public MembershipNo MembershipNo { get; set; }
        public DateTime From { get; set; }
        public DateTime Until { get; set; }

    }
}
