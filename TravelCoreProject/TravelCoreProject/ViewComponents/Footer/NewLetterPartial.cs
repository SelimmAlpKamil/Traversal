using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.ViewComponents.Footer
{
    public class NewLetterPartial:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
         
            return View();
        }


    }
}
