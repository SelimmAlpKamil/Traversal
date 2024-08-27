using DataAccessLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TravelCoreProject.ViewComponents.Admin
{
    public class AdminGuideList:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.contactUsCount = c.ContactUses.Count();

            ViewBag.commentCount = c.Comments.Count();

            ViewBag.newLetterCount = c.NewLetters.Count();

            ViewBag.testimonial = c.Testimonials.Count();



            return View();
        }
    }
}
