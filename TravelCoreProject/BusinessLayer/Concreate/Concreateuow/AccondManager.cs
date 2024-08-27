using BusinessLayer.Abstract.Abstractuow;
using DataAccessLayer.Abstract.Abstractuow;
using DataAccessLayer.EntityFramework.EntityFrameworkuow;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate.Concreateuow
{
    public class AccondManager : IAccondService
    {
        private readonly IAccoundDAL _accound;
        private readonly IuofDAL _save;

        public AccondManager(IAccoundDAL accound, IuofDAL save)
        {
            _accound = accound;
            _save = save;
        }

        public Accound TGet(int id)
        {
            return _accound.Get(id);
            
        }

        public void TInsert(Accound t)
        {
            _accound.Insert(t);
            _save.save();
        }

        public void TMUltiUpdate(List<Accound> t)
        {
            _accound.MUltiUpdate(t);
            _save.save();
        }

        public void TUpdate(Accound t)
        {
            _accound.Update(t);
            _save.save();
        }
    }
}
