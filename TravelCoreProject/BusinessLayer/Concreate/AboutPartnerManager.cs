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
    public class AboutPartnerManager : IAboutPartnerService
    {
        EFAboutPartnerDAL _aboutPartner;

        public AboutPartnerManager(EFAboutPartnerDAL aboutPartner)
        {
            _aboutPartner = aboutPartner;
        }

        public AboutPartner GetByID(int id)
        {
            return _aboutPartner.TGet(id);
        }

        public void TAdd(AboutPartner t)
        {
            _aboutPartner.Insert(t);
        }

        public List<AboutPartner> TGetList()
        {
            return _aboutPartner.GetList();
        }

        public void TRemove(AboutPartner t)
        {
            _aboutPartner.Delete(t);
        }

        public void TUppdate(AboutPartner t)
        {
            _aboutPartner.Update(t);
        }
    }
}
