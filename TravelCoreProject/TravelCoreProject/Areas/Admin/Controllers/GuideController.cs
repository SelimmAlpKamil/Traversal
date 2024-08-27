using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TravelCoreProject.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class GuideController : Controller
    {


        GuideManager guideManager = new GuideManager(new EFGuideDAL());


        public IActionResult Index()
        {
            var guideList = guideManager.TGetList();


            return View(guideList);
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddGuide(Guide p)
        {
            if (ModelState.IsValid)
            {
                p.GuideStatus = false;

                guideManager.TAdd(p);

                return RedirectToAction("Index", "Guide", new { area = "Admin" });
            }


            return View(p);
        }

        [HttpGet]
        public IActionResult UppdateGuide(int id) 
        {
            var findGuide = guideManager.GetByID(id);

            return View(findGuide); 

        }

        [HttpPost]
        public IActionResult UppdateGuide(Guide p)
        {
            if (ModelState.IsValid)
            {
                p.GuideStatus = true;

                guideManager.TUppdate(p);
                return RedirectToAction("Index","Guide", new { area = "Admin" });
            }


            return View(p);
        }

        public IActionResult ChangeToFalse(int id)
        {
            var findGuide = guideManager.GetByID(id);

            findGuide.GuideStatus = false;

            guideManager.TUppdate(findGuide);


            return RedirectToAction("Index", "Guide", new {area="Admin"}); 
        }

        public IActionResult ChangeToTrue(int id)
        {
            var findGuide = guideManager.GetByID(id);

            findGuide.GuideStatus = true;

            guideManager.TUppdate(findGuide);

            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }


    }
}
