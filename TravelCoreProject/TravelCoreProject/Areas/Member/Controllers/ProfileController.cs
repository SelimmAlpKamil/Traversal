using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using TravelCoreProject.Areas.Member.Models;

namespace TravelCoreProject.Areas.Member.Controllers
{
	[Area("Member")]
	[Route("Member/[Controller]/[Action]")]
	public class ProfileController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public ProfileController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);	
			ProfileEditViewModels profileEditViewModels = new ProfileEditViewModels();

			profileEditViewModels.Name = user.Name;
			profileEditViewModels.Surname = user.Surname;
			profileEditViewModels.Mail = user.Email;
			profileEditViewModels.PhoneNumber = user.PhoneNumber;
			
			return View(profileEditViewModels);
		}
        [HttpPost]
        public async Task<IActionResult> Index(ProfileEditViewModels p)
        {
			var user = await _userManager.FindByNameAsync(User.Identity.Name);

			if(p.Image != null)
			{
				var resource = Directory.GetCurrentDirectory();
				var extansion = Path.GetExtension(p.Image.FileName);
				var imageName = Guid.NewGuid() + extansion;
				var saveLocation = resource + "/wwwroot/UserImage/" + imageName;
				var stream = new FileStream(saveLocation,FileMode.Create);
				await p.Image.CopyToAsync(stream);
				user.ImageURL = imageName;	

            }

			user.Name = p.Name;
			user.Surname = p.Surname;
			user.Email = p.Mail;
			user.PhoneNumber = p.PhoneNumber;
			
			if(p.PassWord == p.ConfigPassWord && p.PassWord!=null && p.ConfigPassWord!=null)
			{
				user.PasswordHash = _userManager.PasswordHasher.HashPassword(user,p.PassWord);	
			}

			var result = await _userManager.UpdateAsync(user);

			if(result.Succeeded)
			{
				return RedirectToAction("SingIn", "Login");
			}




			return View(p);

            
        }
    }
}
