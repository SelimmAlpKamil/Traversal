using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;
using TravelCoreProject.Models;

namespace TravelCoreProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SingUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SingUp(UserRegisterAppModel p)
        {
            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                UserName = p.Username,
                Email = p.Mail

            };

            if (p.Password == p.ConfirmPassword && p.Password != null && p.ConfirmPassword != null)
            {
                var result = await _userManager.CreateAsync(appUser, p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("SingIn", "Login");
                }
                else
                {
                    foreach (var x in result.Errors)
                    {
                        ModelState.AddModelError("", x.Description);
                    }
                }

            }

            return View(p);
        }

        [HttpGet]
        public IActionResult SingIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SingIn(LoginRegisterAppModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.PassWord, false, true);

                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(p.UserName);
                    var isAdmin = await _userManager.IsInRoleAsync(user, "admin");

                    if (isAdmin)
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                    }
                    else
                    {
                        return RedirectToAction("Index", "Profile", new { area = "Member" });
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış");
                }
            }

            return View(p);

        }

        public async Task<IActionResult> SingOut()
        {

            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");

        }

    }
}
