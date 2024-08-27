using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class RecervationManager : IRecervationService
    {
        EFReservationDAL _recervation;

        public RecervationManager(EFReservationDAL recervation)
        {
            _recervation = recervation;
        }

        public List<Reservation> CountApprovalReservation()
        {
            return _recervation.GetList(x => x.status == "Onay Bekliyor");
        }

        public List<Reservation> CountCurrentReservation()
        {
            return _recervation.GetList(x=>x.status== "Onaylandı");
        }

        public List<Reservation> CountOldReservation()
        {
            return _recervation.GetList(x => x.status == "İptal Edildi");
        }

        public List<Reservation> GetApprovalReservationUser()
        {
           return _recervation.GetApprovalReservationUser();
        }

        public Reservation GetByID(int id)
        {
            return _recervation.TGet(id);
        }

        public List<Reservation> GetCurrentReservationUser()
        {
            return _recervation.GetCurrentReservationUser();
        }

        public List<Reservation> GetMyCurrentReservationCout(int id)
        {
            return _recervation.GetMyCurrentReservationCout(id, 4);
        }

        public List<Reservation> GetOldReservationUser()
        {
            return _recervation.GetOldReservationUser();
        }

        public List<Reservation> MyApprovalReservation(int id)
        {
            return _recervation.GetMyApprovalReservation(id);
        }

        public List<Reservation> MyCurrentReservation(int id)
        {
            return _recervation.GetMyCurrentReservation(id);
        }

        public List<Reservation> MyOldReservation(int id)
        {
            return _recervation.GetMyOldReservation(id);
        }

        public void TAdd(Reservation t)
        {
            _recervation.Insert(t);
        }

        public List<Reservation> TGetList()
        {
            return _recervation.GetList();
        }

        public void TRemove(Reservation t)
        {
            _recervation.Delete(t);
        }

        public void TUppdate(Reservation t)
        {
            _recervation.Update(t);
        }
    }
}
