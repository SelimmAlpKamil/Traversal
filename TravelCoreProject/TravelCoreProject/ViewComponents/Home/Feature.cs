using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.ViewComponents.Home
{
    public class Feature:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
