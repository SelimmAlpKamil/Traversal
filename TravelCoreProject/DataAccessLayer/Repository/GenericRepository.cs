using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDAL<T>  where T : class
    {
        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }
      

        public List<T> GetList()
        {
            using var c = new Context();

            return c.Set<T>().ToList();
        }

        public List<T> GetList(Func<T,bool>filter)
        {
            using var c = new Context();

            return c.Set<T>().Where(filter).ToList();
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();

        }

        public T TGet(int id)
        {
            using var c = new Context();
            
            return c.Set<T>().Find(id);
        }

        public T TGet(Func<T, bool> Filter)
        {
            using var c = new Context();

            return c.Set<T>().Where(Filter).LastOrDefault();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
