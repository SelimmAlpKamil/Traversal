using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TravelCoreProject.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            TempData["active"] = "Home";

            _logger.LogInformation("Ana sayfaya girildi");

            return View();
        }
    }
}
