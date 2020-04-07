using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    public class MembershipNo
    {
        public int Id { get; set; }
        public double Fees { get; set; }
        public DateTime DateAssigned { get; set; }
        public virtual IEnumerable<Withdrawal> Withdrawals { get; set; }
}
}
