using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace TravelCoreProject.Controllers
{
    [AllowAnonymous]
    public class NewLetterController : Controller
    {
        

        NewLetterManager newLetterManager = new NewLetterManager(new EFNewLetterDAL());

        [HttpGet]
        public IActionResult Index()
        {
            return ViewComponent("NewLetterPartial");
        }

        [HttpPost]
        public IActionResult Index(NewLetter p)
        {
            NewLetterValidation validationRules = new NewLetterValidation();

            var rules = validationRules.Validate(p);

            if(rules.IsValid)
            {
                newLetterManager.TAdd(p);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["ErrorNewLetter"] = rules.Errors.Select(x => x.ErrorMessage).FirstOrDefault().ToString();

                return RedirectToAction("Index", "Home");

            }
          
            
        }
    }
}
