using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using iTextSharp.text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        

        AboutManager aboutManager = new AboutManager(new EFAboutDAL()); 
        
        public IActionResult Index()
        {
            TempData["active"] = "About";

            var aboutList = aboutManager.TGetList();



            return View(aboutList);
        }
    }
}
