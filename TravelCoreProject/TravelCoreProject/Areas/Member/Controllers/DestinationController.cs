using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.Areas.Member.Controllers
{

    [Area("Member")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        

        DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());

        public IActionResult Index()
        {
            var destinationList = destinationManager.TGetList();

            return View(destinationList);
        }
    }
}
