using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using DataAccessLayer.Repository;
using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFDestinationDAL : GenericRepository<Destination>, IDestinationDAL
    {
        public List<Destination> GetDestinationByGuideInfo(Func<Destination, bool> Filter)
        {
            using var x = new Context();

            return x.Set<Destination>().Include(x=>x.Guide).Where(Filter).ToList();
        }

        public List<Destination> GetFeatureMainPost(Func<Destination, bool> Filter)
        {
            using var x = new Context();

            return x.Set<Destination>().OrderByDescending(x => x.DestinationId).Where(Filter).Take(1).ToList();
        }

        public List<Destination> GetFeatureSubPost(Func<Destination, bool> Filter)
        {
            using var x = new Context();

            return x.Set<Destination>().OrderByDescending(x => x.DestinationId).Where(Filter).Take(4).ToList();
        }
        public List<Destination> GetPupularLocation(Func<Destination,bool>Filter, int DestinationCount)
        {
            using var x = new Context();

            return x.Set<Destination>().OrderByDescending(x=>x.DestinationId).Where(Filter).Take(DestinationCount).ToList();
    
        }
        public List<Destination> GetPupularLocation()
        {
            using var x = new Context();

            return x.Set<Destination>().OrderByDescending(x => x.DestinationId).Take(6).ToList();
        }

       
            
    }
}
