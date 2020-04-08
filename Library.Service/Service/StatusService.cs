using Library.Data;
using Library.Data.IDAO;
using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Service
{
    public class StatusService : IStatusDAO
    {
        private LibraryContext _context;
        public StatusService()
        {
            _context = new LibraryContext();
        }

        public IList<Status> GetStatus()
        {
            return _context.Status.ToList();
        }
    }
}
