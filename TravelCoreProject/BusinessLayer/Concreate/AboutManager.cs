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
    public class AboutManager : IAboutService
    {
        EFAboutDAL _aboutDAL;

        public AboutManager(EFAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public About GetByID(int id)
        {
           return  _aboutDAL.TGet(id);
        }

        public void TAdd(About t)
        {
            _aboutDAL.Insert(t);
        }

        public List<About> TGetList()
        {
            return _aboutDAL.GetList(x=>x.AboutStatus==true);
        }

        public void TRemove(About t)
        {
            _aboutDAL.Delete(t);
        }

        public void TUppdate(About t)
        {
            _aboutDAL.Update(t);
        }
    }
}
