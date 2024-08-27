using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.ViewComponents.Home
{
    public class DestinationPopular:ViewComponent
    {
        

        DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());


        public IViewComponentResult Invoke()
        {
            var destinationList = destinationManager.GetPopularLocation();

            return View(destinationList);
        }
    }
}
