using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    public class Reserve
    {
        public int Id { get; set; }
        public virtual Book Book { get; set; }
        public virtual MembershipNo MembershipNo { get; set; }
        public DateTime ReservePlaced { get; set; }

    }
}
