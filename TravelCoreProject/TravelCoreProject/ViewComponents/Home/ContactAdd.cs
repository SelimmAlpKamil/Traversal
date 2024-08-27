using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.ViewComponents.Home
{
    public class ContactAdd: ViewComponent
    {
        


        public IViewComponentResult Invoke()
        {
            

            return View();
            
        }
    }
}
