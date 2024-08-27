using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRecervationService:IGenericService<Reservation>
    {
        List<Reservation> MyApprovalReservation(int id);
        List<Reservation> MyCurrentReservation(int id);
        List<Reservation> GetMyCurrentReservationCout(int id);
        List<Reservation> MyOldReservation(int id);

        List<Reservation> CountCurrentReservation();

        List<Reservation> CountOldReservation();
        List<Reservation> CountApprovalReservation();

        List<Reservation> GetApprovalReservationUser();

        List<Reservation> GetCurrentReservationUser();

        List<Reservation> GetOldReservationUser();

    }
}
