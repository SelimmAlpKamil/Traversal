using DataAccessLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public class uowDAL : IuofDAL
    {
        private readonly Context _context;

        public uowDAL(Context context)
        {
            _context = context;
        }

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
