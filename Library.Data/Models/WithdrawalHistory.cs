using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    public class WithdrawalHistory
    {
        public int Id { get; set; }
        [Required]
        public Book Book { get; set; }
        [Required]
        public MembershipNo MembershipNo { get; set; }
        [Required]
        public DateTime Withdrawn { get; set; }
        public DateTime? Returned { get; set; }

    }
}
