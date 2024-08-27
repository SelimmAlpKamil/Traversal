using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class UserController : Controller
    {
        UserManager userManager = new UserManager(new EFUserDAL());
        RecervationManager recervationManager = new RecervationManager(new EFReservationDAL());

        

        public IActionResult Index()
        {
            var userList = userManager.TGetList();

            return View(userList);
        }

        public IActionResult DestinationUser(int id)
        {
            var findUser = userManager.GetByID(id);
            
            ViewBag.user = findUser.Name + " " +findUser.Surname;

            var rezervationList = recervationManager.MyCurrentReservation(id);

            return View(rezervationList);
        }

        public IActionResult DeleteUser(int id)
        {
            var findUser = userManager.GetByID(id);

            userManager.TRemove(findUser);

            return RedirectToAction("Index", "User");
        }
    }
}
