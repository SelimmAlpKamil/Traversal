using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace TravelCoreProject.Controllers
{
    [AllowAnonymous]
    public class GuideController : Controller
    {
        GuideManager guideManager = new GuideManager(new EFGuideDAL());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GuideDestination(int id)
        {
            
            DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());


            var guideDestinationList = destinationManager.GetGuideDestinationList(id);

            ViewBag.GuideName = guideManager.GetByID(id).GuideName;

            

            return View(guideDestinationList);
        }
    }
}
