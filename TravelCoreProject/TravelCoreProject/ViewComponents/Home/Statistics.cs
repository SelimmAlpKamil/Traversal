using DataAccessLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TravelCoreProject.ViewComponents.Home
{
    public class Statistics:ViewComponent
    {
        Context c = new Context();


        public IViewComponentResult Invoke()
        {
            ViewBag.Location = c.Destinations.Count();

            ViewBag.Guide = c.Guides.Count();

            ViewBag.Testimonials = c.Testimonials.Count();

            ViewBag.NewLetters = c.NewLetters.Count();


            return View();
        }
    }
}
