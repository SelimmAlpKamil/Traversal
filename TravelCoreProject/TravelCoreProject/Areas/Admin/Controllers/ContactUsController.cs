using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class ContactUsController : Controller
    {
        ContactUsManager contactUsManager = new ContactUsManager(new EFContactUsDAL());

        public IActionResult ActiveContact()
        {
            var contactList = contactUsManager.GetListTrue();

            return View(contactList);
        }
        public IActionResult PasifContact()
        {
            var contactList = contactUsManager.GetListFalse();

            return View(contactList);
        }

        public IActionResult ChangeStatusFalseContact(int id)
        {
            contactUsManager.ChangeToFalse(id);

            return RedirectToAction("ActiveContact", "ContactUs");
        }

        public IActionResult ChangeStatusTrueContact(int id)
        {
            contactUsManager.ChangeToTrue(id);

            return RedirectToAction("PasifContact", "ContactUs");
        }
        public IActionResult ContactDetail(int id)
        {
            var findContact = contactUsManager.GetByID(id);

            return View(findContact);
        }

        public IActionResult SendMail(int id)
        {
            var findMail = contactUsManager.GetByID(id);
            TempData["mail"] = findMail.ContactUsMail;

            return RedirectToAction("Index", "MailSend");
        }
    }
}
