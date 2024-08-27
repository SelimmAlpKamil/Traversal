using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.ViewComponents.Home
{
    public class HomeSlider:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }

    }
}
