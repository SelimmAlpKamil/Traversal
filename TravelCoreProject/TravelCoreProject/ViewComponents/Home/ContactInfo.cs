using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.ViewComponents.Home
{
    public class ContactInfo:ViewComponent
    {
        ContactManager contactManager = new ContactManager(new EFContactDAL());

        public IViewComponentResult Invoke()
        {
            var listContact = contactManager.TGetList();


            return View(listContact);
        }

        
    }
}
