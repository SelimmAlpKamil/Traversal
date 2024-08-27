using DataAccessLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TravelCoreProject.ViewComponents.Admin
{
    public class AdminStatistics:ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.destination = c.Destinations.Count();
            ViewBag.guide = c.Guides.Count();


            return View();
        }

    }
}
