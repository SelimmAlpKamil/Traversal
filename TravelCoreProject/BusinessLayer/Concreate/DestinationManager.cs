using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class DestinationManager : IDestinationService
    {
        EFDestinationDAL _destination;

        public DestinationManager(EFDestinationDAL destination)
        {
            _destination = destination;
        }

        public Destination GetByID(int id)
        {
            return _destination.TGet(id);
        }

        public List<Destination> GetDestinationByGuideInfoList(int id)
        {
            return _destination.GetDestinationByGuideInfo(x=>x.DestinationStatus==true && x.DestinationId==id);
        }

        public List<Destination> GetGuideDestinationList(int id)
        {
            return _destination.GetDestinationByGuideInfo(x => x.DestinationStatus == true && x.GuideID == id);
        }

        public List<Destination> GetFeatureMain()
        {
            return _destination.GetFeatureMainPost(x=>x.FeatureMainPost==true && x.DestinationStatus == true);
        }

        public List<Destination> GetFeatureSub()
        {
            return _destination.GetFeatureSubPost(x => x.FeatureSubPost == true && x.DestinationStatus == true);
        }

        public List<Destination> GetPopularLocation()
        {
            return _destination.GetPupularLocation(x=>x.DestinationStatus==true,6);
        }

        public void TAdd(Destination t)
        {
            _destination.Insert(t);
        }

        public List<Destination> TGetList()
        {
           return _destination.GetList(x=>x.DestinationStatus==true);   
        }

        public void TRemove(Destination t)
        {
            _destination.Delete(t);
        }

        public void TUppdate(Destination t)
        {
            _destination.Update(t);
        }

        public List<Destination> GetMemberPopularLocation()
        {
            return _destination.GetPupularLocation(x => x.DestinationStatus == true, 4);
        }

        public List<Destination> GetAboutPopularLocation()
        {
            return _destination.GetPupularLocation(x => x.DestinationStatus == true, 3);
        }

        public List<Destination> DestinationSearchList(int id)
        {
            return _destination.GetList(x => x.DestinationStatus == true && x.DestinationId ==id);
        }
    }
}
