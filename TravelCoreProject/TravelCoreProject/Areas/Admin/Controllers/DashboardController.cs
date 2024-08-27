using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admin")]
        [Route("Admin/[controller]/[action]/{id?}")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
