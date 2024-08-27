using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.ViewComponents.About
{
    public class AboutGuideList:ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EFGuideDAL());


        public IViewComponentResult Invoke()
        {
            var guideList= guideManager.PopularAboutGuideList();


            return View(guideList);
        }
    }
}
