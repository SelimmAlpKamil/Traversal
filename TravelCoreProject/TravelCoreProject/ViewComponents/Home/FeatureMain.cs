using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TravelCoreProject.ViewComponents.Home
{
    public class FeatureMain:ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());

        

        public IViewComponentResult Invoke()
        {
            var lastFeature = destinationManager.GetFeatureMain();

            return View(lastFeature);
        }
    }
}
