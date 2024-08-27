using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IReservationDAL:IGenericDAL<Reservation>
    {
        List<Reservation> GetMyApprovalReservation(int id);
        List<Reservation> GetMyCurrentReservation(int id);
        List<Reservation> GetMyCurrentReservationCout(int id,int ReservationCount);
        List<Reservation> GetMyOldReservation(int id);

        List<Reservation> GetApprovalReservationUser();

        List<Reservation> GetCurrentReservationUser();

        List<Reservation> GetOldReservationUser();


    }
}
