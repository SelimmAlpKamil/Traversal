using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelCoreProject.ViewComponents.Member
{
    public class MemberProfileInfo:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public MemberProfileInfo(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var findUser = await _userManager.FindByNameAsync(User.Identity.Name);
            
            ViewBag.Name = findUser.UserName + " " + findUser.Surname;
            ViewBag.Mail = findUser.Email;
            ViewBag.Phone = findUser.PhoneNumber;

            return View();
        }

    }
}
