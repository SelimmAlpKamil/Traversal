using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.Abstractuow
{
    public interface IGenericuowDAL<T>
    {
        void Insert(T t);

        void Update(T t);

        void MUltiUpdate(List<T> t);
       
        T Get(int id);

       
    }
}
