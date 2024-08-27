using BusinessLayer.Validation;
using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using iTextSharp.text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCoreProject.Areas.Admin.Models;

namespace TravelCoreProject.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        Context c = new Context();

        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var roleList = _roleManager.Roles.ToList();


            return View(roleList);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel p)
        {

            AppRole appRole = new AppRole()
            {
                Name = p.Name,
            };


            var result = await _roleManager.CreateAsync(appRole);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Role");
            }

            return View(p);

        }

        public async Task<IActionResult> DeleteRole(int id)
        {

            var findRole = c.Roles.Find(id);

            await _roleManager.DeleteAsync(findRole);

            return RedirectToAction("Index", "Role");
        }


        [HttpGet]
        public IActionResult UppdateRole(int id)
        {
            var findRole = c.Roles.Find(id);

            return View(findRole);
        }

        [HttpPost]
        public async Task<IActionResult> UppdateRole(AppRole p)
        {
            var findRole = c.Roles.Find(p.Id);

            findRole.Name = p.Name;



            await _roleManager.UpdateAsync(findRole);


            return RedirectToAction("Index", "Role");

        }


        public IActionResult UserIndex()
        {
            var userList = _userManager.Users.ToList();

            return View(userList);
        }

        [HttpGet]
        public async Task<IActionResult> RoleDetail(int id)
        {

            var findUser = _userManager.Users.FirstOrDefault(x => x.Id == id);

            TempData["UserId"] = findUser.Id;

            var roleList = _roleManager.Roles.ToList();

            var userRole = await _userManager.GetRolesAsync(findUser);

            List<RoleDetailsViewModel> roleDetailsViewModel = new List<RoleDetailsViewModel>();

            foreach (var role in roleList)
            {
                RoleDetailsViewModel model = new RoleDetailsViewModel();
                model.RoleName = role.Name;
                model.RoleId = role.Id;
                model.RoleStatus = userRole.Contains(role.Name);
                roleDetailsViewModel.Add(model);
            }


            return View(roleDetailsViewModel);

        }


        [HttpPost]
        public async Task<IActionResult> RoleDetail(List<RoleDetailsViewModel> model)
        {
            var userId = (int)TempData["UserId"];

            var findUser = _userManager.Users.FirstOrDefault(x=> x.Id == userId);

            foreach(var x in model)
            {
                if (x.RoleStatus == true)
                {
                    await _userManager.AddToRoleAsync(findUser, x.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(findUser, x.RoleName);
                }
            }

            return RedirectToAction("UserIndex","Role");


        }
    }

}
