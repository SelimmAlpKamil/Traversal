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
    public class ContactUsManager:IContactUsService
    {
        EFContactUsDAL _contactUs;

        public ContactUsManager(EFContactUsDAL contactUs)
        {
            _contactUs = contactUs;
        }

        public void  ChangeToFalse(int id)
        {
            var findContact = _contactUs.TGet(id);

            findContact.ContactUsStatus = false;

            _contactUs.Update(findContact);

            
        }

        public void ChangeToTrue(int id)
        {
            var findContact = _contactUs.TGet(id);

            findContact.ContactUsStatus = true;

            _contactUs.Update(findContact);

            
        }

        public ContactUs GetByID(int id)
        {
            return _contactUs.TGet(id);
        }

        public List<ContactUs> GetListFalse()
        {
            return _contactUs.GetList(x=>x.ContactUsStatus==false);
        }

        public List<ContactUs> GetListTrue()
        {
            return _contactUs.GetList(x => x.ContactUsStatus == true);
        }

        public void TAdd(ContactUs t)
        {
            _contactUs.Insert(t);
        }

        public List<ContactUs> TGetList()
        {
            return _contactUs.GetList();
        }

        public void TRemove(ContactUs t)
        {
             _contactUs.Delete(t);
        }

        public void TUppdate(ContactUs t)
        {
            _contactUs.Update(t);
        }
    }
}
