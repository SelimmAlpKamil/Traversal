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
    public class AnnouncementManager:IAnnouncementService
    {
        EFAnnouncementDAL _announcementDAL;

        public AnnouncementManager(EFAnnouncementDAL announcementDAL)
        {
            _announcementDAL = announcementDAL;
        }

        public Announcement GetByID(int id)
        {
            return _announcementDAL.TGet(id);
        }

        public void TAdd(Announcement t)
        {
            _announcementDAL.Insert(t);
        }

        public List<Announcement> TGetList()
        {
            return _announcementDAL.GetList();
        }

        public void TRemove(Announcement t)
        {
            _announcementDAL.Delete(t);
        }

        public void TUppdate(Announcement t)
        {
            _announcementDAL.Update(t);
        }
    }
}
