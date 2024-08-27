using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDestinationDAL:IGenericDAL<Destination>
    {
        List<Destination> GetPupularLocation(Func<Destination,bool>Filter,int DestinationCount);

        List<Destination> GetPupularLocation();

        List<Destination> GetFeatureMainPost(Func<Destination, bool> Filter);

        List<Destination> GetFeatureSubPost(Func<Destination, bool> Filter);

        List<Destination> GetDestinationByGuideInfo(Func<Destination, bool> Filter);


    }
}
