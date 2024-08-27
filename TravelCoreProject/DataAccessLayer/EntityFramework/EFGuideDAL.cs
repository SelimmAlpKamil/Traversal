using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using DataAccessLayer.Repository;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFGuideDAL : GenericRepository<Guide>, IGuideDAL
    {
        public List<Guide> GetPopularGuide(int GuidCount)
        {
            using var value = new Context();
            
            return value.Guides.OrderByDescending(x=>x.GuideID).Take(GuidCount).ToList();
        }
    }
}
