using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.ViewComponents.Footer
{
    public class SocialMedia:ViewComponent
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EFSocialMediaDAL());

        public IViewComponentResult Invoke()
        {
            var socialMediaList = socialMediaManager.TGetList();


            return View(socialMediaList);
        }

    }
}
