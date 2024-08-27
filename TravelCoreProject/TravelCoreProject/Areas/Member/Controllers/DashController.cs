using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class DashController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DashController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var findUser = await _userManager.FindByNameAsync(User.Identity.Name);  

            ViewBag.UserName = findUser.UserName + " " + findUser.Surname;
            ViewBag.UserImage = findUser.ImageURL;

            return View();
        }
    }
}
