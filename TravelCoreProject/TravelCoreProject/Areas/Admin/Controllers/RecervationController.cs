using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Linq;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class RecervationController : Controller
    {
        RecervationManager recervationManager = new RecervationManager(new EFReservationDAL());


        public IActionResult Index()
        {
            var list = recervationManager.GetApprovalReservationUser();

            return View(list);
        }

        public IActionResult ActiveRecervation(int id) 
        {
            var findRecervation = recervationManager.GetByID(id);

            findRecervation.status = "Onaylandı";

            recervationManager.TUppdate(findRecervation);

            return RedirectToAction("ActiveRecervationList", "Recervation");
        }

        public IActionResult PasifRecervation(int id)
        {
            var findRecervation = recervationManager.GetByID(id);

            findRecervation.status = "İptal Edildi";

            recervationManager.TUppdate(findRecervation);

            return RedirectToAction("PasifRecervationList", "Recervation");
        }

        public IActionResult ActiveRecervationList()
        {
            var list = recervationManager.GetCurrentReservationUser();

            return View(list);
        }

        public IActionResult PasifRecervationList()
        {
            var list = recervationManager.GetOldReservationUser();

            return View(list);
        }




    }
}
