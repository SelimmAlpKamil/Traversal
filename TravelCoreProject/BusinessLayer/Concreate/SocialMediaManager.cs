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
    public class SocialMediaManager : ISocialMediaService
    {
        EFSocialMediaDAL _socialMedia;

        public SocialMediaManager(EFSocialMediaDAL socialMedia)
        {
            _socialMedia = socialMedia;
        }

        public SocialMedia GetByID(int id)
        {
           return _socialMedia.TGet(id);
        }

        public void TAdd(SocialMedia t)
        {
            _socialMedia.Insert(t);
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMedia.GetList(x=>x.SocialMediaStatus==true);
        }

        public void TRemove(SocialMedia t)
        {
            _socialMedia.Delete(t);
        }

        public void TUppdate(SocialMedia t)
        {
            _socialMedia.Update(t);
        }
    }
}
