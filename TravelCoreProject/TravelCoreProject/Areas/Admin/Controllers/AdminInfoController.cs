using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TravelCoreProject.Areas.Admin.Models;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]

    public class AdminInfoController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AdminInfoController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            AdminProfileViewModel adminProfileViewModel = new AdminProfileViewModel();

            var findUser = await _userManager.FindByNameAsync(User.Identity.Name);

            adminProfileViewModel.Name = findUser.Name;
            adminProfileViewModel.Surname = findUser.Surname;
            adminProfileViewModel.ImageURL = findUser.ImageURL;
            adminProfileViewModel.PhoneNumber = findUser.PhoneNumber;
            adminProfileViewModel.Mail = findUser.Email;

            return View(adminProfileViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(AdminProfileViewModel p)
        {

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            user.Name = p.Name;
            user.Surname = p.Surname;
            user.Email = p.Mail;
            user.PhoneNumber = p.PhoneNumber;
            user.ImageURL = p.ImageURL;

            if (p.PassWord == p.ConfigPassWord && p.PassWord != null && p.ConfigPassWord != null)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.PassWord);
            }

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("SingIn", "Login");
            }

            return View(p);
        }
    }
}
