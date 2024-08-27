using DataAccessLayer.Abstract.Abstractuow;
using DataAccessLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.Repositoryuow
{
    public class GenericRepositoryuow<T> : IGenericuowDAL<T> where T : class
    {
        private readonly Context _context;

        public GenericRepositoryuow(Context context)
        {
            _context = context;
        }

        public void Insert(T t)
        {
            _context.Add(t);
        }

        public void MUltiUpdate(List<T> t)
        {
            _context.UpdateRange(t);
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T t)
        {
            _context.Update(t);
        }
    }
}
