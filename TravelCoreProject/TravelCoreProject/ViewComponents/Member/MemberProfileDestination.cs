using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.ViewComponents.Member
{



    public class MemberProfileDestination:ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());

        public IViewComponentResult Invoke()
        {
            var list = destinationManager.GetMemberPopularLocation();

            return View(list);
        }
    }
}
