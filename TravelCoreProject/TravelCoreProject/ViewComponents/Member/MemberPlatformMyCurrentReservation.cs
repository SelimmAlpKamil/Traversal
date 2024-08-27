using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelCoreProject.Views.Shared.Components
{
    public class MemberPlatformMyCurrentReservation:ViewComponent
    {

        RecervationManager recervationManager = new RecervationManager(new EFReservationDAL());

        private readonly UserManager<AppUser> _userManager;

        public MemberPlatformMyCurrentReservation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var findUser = await _userManager.FindByNameAsync(User.Identity.Name);

            var list = recervationManager.MyCurrentReservation(findUser.Id);


            return View(list);
        }
    }
}
