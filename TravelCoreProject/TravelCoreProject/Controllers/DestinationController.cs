using BusinessLayer.Abstract;
using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace TravelCoreProject.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());

       

        public IActionResult Index()
        {
            var destinationList = destinationManager.TGetList();

            TempData["active"] = "Destination";

            return View(destinationList);
        }


        public IActionResult DestinationDetail(int id) 
        {
            TempData["active"] = "Destination";

            ViewBag.DestinationId = id; 

            var findDestination = destinationManager.GetDestinationByGuideInfoList(id);


            return View(findDestination);
        }

        [HttpPost]
        public IActionResult DestinationSearch(Destination p)
        {

            var list = destinationManager.DestinationSearchList(p.DestinationId);

            TempData["active"] = "Destination";

            return View(list);
        }



    }
}
