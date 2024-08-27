using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[Controller]/[Action]/{id?}")]
    public class ReservationController : Controller
    {


        DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());
        RecervationManager recervationManager = new RecervationManager(new EFReservationDAL());

        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {
            var findUser = await _userManager.FindByNameAsync(User.Identity.Name);

            var CurrentlList = recervationManager.MyCurrentReservation(findUser.Id);

            return View(CurrentlList);
        }

        public async Task<IActionResult> MyOldReservation()
        {
            var findUser = await _userManager.FindByNameAsync(User.Identity.Name);

            var oldlList = recervationManager.MyOldReservation(findUser.Id);

            return View(oldlList);
        }

        public async Task<IActionResult> MyApprovalReservation()
        {
            var findUser = await _userManager.FindByNameAsync(User.Identity.Name);

            var approvalList = recervationManager.MyApprovalReservation(findUser.Id);

            return View(approvalList);
        }



        [HttpGet]
        public IActionResult NewReservation()
        {
            
            IEnumerable<SelectListItem> destinationValue = (from x  in destinationManager.TGetList() select new SelectListItem
            {
                Text = x.DestinationCity,
                Value = x.DestinationId.ToString(),

            }).ToList();

            ViewBag.DestinationValue = destinationValue;    

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation p)
        {
            ReservationValidation validationRules = new ReservationValidation();
            
            var rule = validationRules.Validate(p);

            IEnumerable<SelectListItem> destinationValue = (from x in destinationManager.TGetList()
                                             select new SelectListItem
                                             {
                                                 Text = x.DestinationCity,
                                                 Value = x.DestinationId.ToString(),

                                             }).ToList();

            ViewBag.DestinationValue = destinationValue;


            if (rule.IsValid  && p.ReservationDate != null && p.PersonCount !=null)
            {

                var  findUser = await _userManager.FindByNameAsync(User.Identity.Name);
                p.AppUserId = findUser.Id;
                p.status = "Onay Bekliyor";
                recervationManager.TAdd(p);

                return RedirectToAction("MyApprovalReservation", "Reservation");
            }
            else
            {
                foreach(var x in rule.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);

                }
            }

            return View(p);

            
        }
    }
}
