using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace TravelCoreProject.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonialDAL());



        public IActionResult Index()
        {
            var list = testimonialManager.TGetList();


            return View(list);
        }

        [HttpGet]
        public IActionResult AddTestimonial() 
        {
            return View();  
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial p)
        {
            TestimonialValidation validationRules = new TestimonialValidation();
            
            var rules = validationRules.Validate(p);

            if (rules.IsValid)
            {
                p.TestimonialStatus = true;

                testimonialManager.TAdd(p);

               return RedirectToAction("Index", "Testimonial");
            }
            else
            {
                foreach(var rule in rules.Errors)
                {
                    ModelState.AddModelError(rule.PropertyName, rule.ErrorMessage);
                }
            }


            return View(p);
        }

        [HttpGet]
        public IActionResult UppdateTestimonial(int id)
        {
            var findTestimonial = testimonialManager.GetByID(id);

            return View (findTestimonial);  
        }
        [HttpPost]
        public IActionResult UppdateTestimonial(Testimonial p)
        {
            TestimonialValidation validationRules = new TestimonialValidation();

            var rules = validationRules.Validate(p);

            if (rules.IsValid)
            {
                p.TestimonialStatus  = true;

                testimonialManager.TUppdate(p);

                return RedirectToAction("Index", "Testimonial");
            }
            else
            {
                foreach (var rule in rules.Errors)
                {
                    ModelState.AddModelError(rule.PropertyName, rule.ErrorMessage);
                }
            }

            return View(p);

        }

        public IActionResult DeleteTestimonial(int id)
        {
            var findTestimonial = testimonialManager.GetByID(id);

            testimonialManager.TRemove(findTestimonial);

            return RedirectToAction("Index", "Testimonial");
        }

    }
}
