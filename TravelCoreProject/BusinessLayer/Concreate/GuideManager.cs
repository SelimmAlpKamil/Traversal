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
    public class GuideManager: IGuideService
    {
        EFGuideDAL _Guide;

        public GuideManager(EFGuideDAL guide)
        {
            _Guide = guide;
        }

        public Guide GetByID(int id)
        {
            return _Guide.TGet(id);
        }

        public List<Guide> PopularAboutGuideList()
        {
            return _Guide.GetPopularGuide(4);
        }

        public List<Guide> PopularGuideList()
        {
            return _Guide.GetPopularGuide(5);
        }

        public void TAdd(Guide t)
        {
            _Guide.Insert(t);
        }

        public List<Guide> TGetList()
        {
            return _Guide.GetList();
        }

        public void TRemove(Guide t)
        {
            _Guide.Delete(t);
        }

        public void TUppdate(Guide t)
        {
            _Guide.Update(t);
        }
    }
}
