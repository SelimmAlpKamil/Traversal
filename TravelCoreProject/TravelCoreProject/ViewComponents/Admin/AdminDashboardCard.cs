using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TravelCoreProject.ViewComponents.Admin
{
    public class AdminDashboardCard:ViewComponent
    {
        Context c = new Context();


        public IViewComponentResult Invoke()
        {
            ViewBag.userCount = c.Users.Count();

            return View();
        }
    }
}
