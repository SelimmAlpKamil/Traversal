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
    public class EFReservationDAL : GenericRepository<Reservation>, IReservationDAL
    {
        

        public List<Reservation> GetMyApprovalReservation(int id)
        {
            using var valu = new Context();

            var result = valu.Reservations.Where(x=>x.AppUserId == id && x.status=="Onay Bekliyor").Include(x=>x.Destination).ToList();
            
            return result;
        }

        public List<Reservation> GetMyCurrentReservation(int id)
        {
            using var valu = new Context();

            var result = valu.Reservations.Where(x => x.AppUserId == id && x.status == "Onaylandı").Include(x => x.Destination).ToList();

            return result;
        }

        public List<Reservation> GetMyCurrentReservationCout(int id, int ReservationCount)
        {
            using var valu = new Context();

            var result = valu.Reservations.Where(x => x.AppUserId == id && x.status == "Onaylandı").Include(x => x.Destination).Take(ReservationCount).ToList();

            return result;
        }

        public List<Reservation> GetMyOldReservation(int id)
        {
            using var valu = new Context();

            var result = valu.Reservations.Where(x => x.AppUserId == id && x.status == "İptal Edildi").Include(x => x.Destination).ToList();

            return result;
        }

        public List<Reservation> GetApprovalReservationUser()
        {
            using var valu = new Context();

            var result = valu.Reservations.Where(x=> x.status == "Onay Bekliyor").Include(x => x.AppUser).ToList();

            return result;
        }

        public List<Reservation> GetCurrentReservationUser()
        {
            using var valu = new Context();

            var result = valu.Reservations.Where(x => x.status == "Onaylandı").Include(x => x.AppUser).ToList();

            return result;
        }

        public List<Reservation> GetOldReservationUser()
        {
            using var valu = new Context();

            var result = valu.Reservations.Where(x => x.status == "İptal Edildi").Include(x => x.AppUser).ToList();

            return result;
        }
    }
}
