using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelCoreProject.ViewComponents.Member
{
    public class MemberPopularGuide:ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EFGuideDAL());

        

        public  IViewComponentResult Invoke()
        {
            var list = guideManager.PopularGuideList();

            return View(list);
        }

    }
}
