using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EFContactDAL());

        [HttpGet]
        public IActionResult Index()
        {
            var findContact = contactManager.GetByID(1);


            return View(findContact);
        }

        [HttpPost]
        public IActionResult Index(Contact p)
        {
            ContactValidation validations = new ContactValidation();

            var rule = validations.Validate(p);

            if (rule.IsValid)
            {
                
                p.ContactStatus = true;
                contactManager.TUppdate(p);
                return RedirectToAction("Index", "Contact",new {area="Home"});

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
