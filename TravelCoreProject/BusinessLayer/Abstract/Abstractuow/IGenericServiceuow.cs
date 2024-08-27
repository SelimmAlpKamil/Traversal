using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.Abstractuow
{
    public interface IGenericServiceuow<T>
    {
        void TInsert(T t);

        void TUpdate(T t);

        void TMUltiUpdate(List<T> t);

        T TGet(int id);

    }
}
