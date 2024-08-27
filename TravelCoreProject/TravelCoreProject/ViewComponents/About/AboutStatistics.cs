using DataAccessLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TravelCoreProject.ViewComponents.About
{
    public class AboutStatistics:ViewComponent
    {

        Context c = new Context();

        public IViewComponentResult Invoke()
        {
               ViewBag.GuideCount = c.Guides.Count();
               ViewBag.UserCount = c.Users.Count();
               ViewBag.CommentCount = c.Comments.Count();

               return View();
        }

    }
}
