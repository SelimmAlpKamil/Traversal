using BusinessLayer.Concreate;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TravelCoreProject.ViewComponents.Admin
{
    public class AdminOrderStatistics:ViewComponent
    {
        RecervationManager recervationManager = new RecervationManager(new EFReservationDAL());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {

            ViewBag.CountRecervation = c.Reservations.Count();

            int countCurrent = 0;
            int countOld = 0;
            int countApproval = 0;

            var countCurrentList = recervationManager.CountCurrentReservation();
            var countOldList = recervationManager.CountOldReservation();
            var countApprovalList = recervationManager.CountApprovalReservation();

            foreach(var x in countCurrentList)
            {
                countCurrent++;
            }

            foreach(var x in countOldList)
            {
                countOld++;
            }

            foreach (var item in countApprovalList)
            {
                countApproval++;
            }


            ViewBag.countCurrent = countCurrent;

            ViewBag.countOld = countOld;

            ViewBag.countApproval = countApproval;



            return View();
        }

    }
}
