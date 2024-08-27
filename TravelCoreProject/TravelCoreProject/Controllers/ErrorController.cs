using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Page404(int code)
        {
            return View();
        }
    }
}
