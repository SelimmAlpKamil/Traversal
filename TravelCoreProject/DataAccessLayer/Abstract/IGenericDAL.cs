﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T>
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList ();
        List<T> GetList(Func<T,bool>Filter);
        T TGet (int id);

        T TGet(Func<T,bool>Filter);


    }
    
    
}
