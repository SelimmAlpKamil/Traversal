using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;



namespace TravelCoreProject.Controllers
{
    [AllowAnonymous]

    public class ContactController : Controller
    {
        

        ContactUsManager contactUsManager = new ContactUsManager(new EFContactUsDAL());



        public IActionResult Index()
        {
            TempData["active"] = "Contact";

            return View();
        }

        [HttpGet]
        public IActionResult ContactAdd()
        {
            TempData["active"] = "Contact";

            return View(); 
        }
        [HttpPost]
        public IActionResult ContactAdd(ContactUs p)
        {
            AddContactValidation validationRules = new AddContactValidation();

            var validation = validationRules.Validate(p);

            if (validation.IsValid)
            {
                p.ContactUsStatus = true;
                p.ContactUsDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                contactUsManager.TAdd(p);

                return RedirectToAction("Index", "Contact");
            }
            else
            {
                foreach (var item in validation.Errors)
                {
                    TempData["ErrorNewLetter"] = validation.Errors.Select(x => x.ErrorMessage).FirstOrDefault().ToString();

                    return RedirectToAction("Index", "Contact");

                }
            }

            return View();
        }
    }
}
