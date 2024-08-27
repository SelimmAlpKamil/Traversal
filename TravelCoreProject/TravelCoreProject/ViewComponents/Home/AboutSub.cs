using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.ViewComponents.Home
{
    public class AboutSub:ViewComponent
    {
        
       AboutSubManager aboutSubManager = new AboutSubManager(new EFAboutSubDAL());
        public IViewComponentResult Invoke()
        {
           var aboutSubList = aboutSubManager.TGetList();


            return View(aboutSubList);
        }
    }
}
