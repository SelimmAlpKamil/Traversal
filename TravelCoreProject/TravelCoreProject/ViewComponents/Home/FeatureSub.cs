using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.ViewComponents.Home
{
    public class FeatureSub:ViewComponent
    {

        DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());
        

        public IViewComponentResult Invoke()
        {
            var featureSubList = destinationManager.GetFeatureSub();



            return View(featureSubList);
        }
    }
}
