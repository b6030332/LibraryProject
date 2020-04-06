﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    public class Patron
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TelephoneNumber { get; set; }
        public virtual MembershipNo MembershipNo { get; set; }

    }
}
