using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class NewLetterManager: INewLetterService
    {
        EFNewLetterDAL _NewLetter;

        public NewLetterManager(EFNewLetterDAL newLetter)
        {
            _NewLetter = newLetter;
        }

        public NewLetter GetByID(int id)
        {
            return _NewLetter.TGet(id);
        }

        public void TAdd(NewLetter t)
        {
            _NewLetter.Insert(t);
        }

        public List<NewLetter> TGetList()
        {
            return _NewLetter.GetList();
        }

        public void TRemove(NewLetter t)
        {
            _NewLetter.Delete(t);
        }

        public void TUppdate(NewLetter t)
        {
            _NewLetter.Update(t);
        }
    }
}
