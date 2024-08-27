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
    public class ContactManager:IContactService
    {
        EFContactDAL _ContactDAL;

        public ContactManager(EFContactDAL contactDAL)
        {
            _ContactDAL = contactDAL;
        }

        public Contact GetByID(int id)
        {
            return _ContactDAL.TGet(id);
        }

        public void TAdd(Contact t)
        {
            _ContactDAL.Insert(t);
        }

        public List<Contact> TGetList()
        {
            return _ContactDAL.GetList(x=>x.ContactStatus==true);
        }

        public void TRemove(Contact t)
        {
            _ContactDAL.Delete(t);
        }

        public void TUppdate(Contact t)
        {
            _ContactDAL.Update(t);
        }
    }
}
