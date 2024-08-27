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
    public class AboutSubManager:IAboutSubService
    {
        EFAboutSubDAL _AboutSub;

        public AboutSubManager(EFAboutSubDAL aboutSub)
        {
            _AboutSub = aboutSub;
        }

        public AboutSub GetByID(int id)
        {
            return _AboutSub.TGet(id);
        }

        public void TAdd(AboutSub t)
        {
            _AboutSub.Insert(t);    
        }

        public List<AboutSub> TGetList()
        {
            return _AboutSub.GetList();
        }

        public void TRemove(AboutSub t)
        {
            _AboutSub.Delete(t);
        }

        public void TUppdate(AboutSub t)
        {
            _AboutSub.Update(t);
        }
    }
}
