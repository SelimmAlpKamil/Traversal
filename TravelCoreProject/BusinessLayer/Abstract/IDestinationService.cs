using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
    {

        List<Destination> GetPopularLocation();

        List<Destination> GetAboutPopularLocation();

        public List<Destination> GetMemberPopularLocation();

        List<Destination> GetFeatureMain();

        List<Destination> GetFeatureSub();

        List<Destination> GetDestinationByGuideInfoList(int id);

        List<Destination> GetGuideDestinationList(int id);
        List<Destination> DestinationSearchList(int id);

    }
}
