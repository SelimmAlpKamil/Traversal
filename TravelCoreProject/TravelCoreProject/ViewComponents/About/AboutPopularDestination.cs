using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.ViewComponents.About
{
    

    public class AboutPopularDestination:ViewComponent
    {

        DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());
        
        public IViewComponentResult Invoke()
        {
            var destinationList = destinationManager.GetAboutPopularLocation();


            return View(destinationList);
        }


    }
}
