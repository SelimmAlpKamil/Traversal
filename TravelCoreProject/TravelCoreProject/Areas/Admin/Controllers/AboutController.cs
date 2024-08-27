using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EFAboutDAL());
        AboutSubManager aboutSubManager = new AboutSubManager(new EFAboutSubDAL());

        [HttpGet]
        public IActionResult AboutPage()
        {
            var findAbout = aboutManager.GetByID(1);

            return View(findAbout);
        }
        [HttpPost]
        public IActionResult AboutPage(About p)
        {
            AdminAboutValidation validations = new AdminAboutValidation();
            var rules = validations.Validate(p);

            if (rules.IsValid)
            {
                p.AboutStatus = true;
                aboutManager.TUppdate(p);

                return RedirectToAction("Index", "About", new { @area = "Home" });
            }
            else
            {
                foreach(var x in rules.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);

                    
                }
            }

            return View(p);
        }
        [HttpGet]
        public IActionResult AboutSubPage()
        {
            var findAbout = aboutSubManager.GetByID(1);

            return View(findAbout);
        }
        [HttpPost]
        public IActionResult AboutSubPage(AboutSub p)
        {
            AdminAboutSubValidation validations = new AdminAboutSubValidation();
            var rule = validations.Validate(p);

            if(rule.IsValid)
            {
                aboutSubManager.TUppdate(p);
                return RedirectToAction("Index", "Home", new { @area = "Home" });
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
