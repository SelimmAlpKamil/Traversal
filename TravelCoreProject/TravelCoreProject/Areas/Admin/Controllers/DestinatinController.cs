using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinatinController : Controller
    {

        GuideManager guideManager = new GuideManager(new EFGuideDAL());
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());

        public IActionResult Index()
        {
            var destinationList = destinationManager.TGetList();

            return View(destinationList);
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            List<SelectListItem> guideList = (from x in guideManager.TGetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.GuideName,
                                                  Value = x.GuideID.ToString(),

                                              }).ToList();

            List<SelectListItem> FeatureTrueFalse = new List<SelectListItem>
            {
                new SelectListItem { Text = "Evet", Value = "true" },
                new SelectListItem { Text = "Hayır", Value = "false" }
             };

           

            ViewBag.FeatureTrueFalse = FeatureTrueFalse;
            ViewBag.GuideList = guideList;

            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(Destination p)
        {
            if (ModelState.IsValid)
            {
                p.DestinationStatus = true;
                destinationManager.TAdd(p);
                return RedirectToAction("Index", "Destination", new { area = "Admin" });
            }

            List<SelectListItem> guideList = (from x in guideManager.TGetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.GuideName,
                                                  Value = x.GuideID.ToString(),

                                              }).ToList();

            List<SelectListItem> FeatureTrueFalse = new List<SelectListItem>
            {
                new SelectListItem { Text = "Evet", Value = "true" },
                new SelectListItem { Text = "Hayır", Value = "false" }
             };



            ViewBag.FeatureTrueFalse = FeatureTrueFalse;
            ViewBag.GuideList = guideList;

            return View(p);
        }

        [HttpGet]
        public IActionResult UpdateDestinatino(int id)
        {
            var findDestination = destinationManager.GetByID(id);

            List<SelectListItem> guideList = (from x in guideManager.TGetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.GuideName,
                                                  Value = x.GuideID.ToString(),

                                              }).ToList();

            List<SelectListItem> FeatureTrueFalse = new List<SelectListItem>
            {
                new SelectListItem { Text = "Evet", Value = "true" },
                new SelectListItem { Text = "Hayır", Value = "false" }
             };



            ViewBag.FeatureTrueFalse = FeatureTrueFalse;
            ViewBag.GuideList = guideList;


            return View(findDestination);
        }

        [HttpPost]
        public IActionResult UpdateDestinatino(Destination p)
        {
            if(ModelState.IsValid)
            {
                p.DestinationStatus = true;
                destinationManager.TUppdate(p);
                return RedirectToAction("Index", "Destination", new { area = "Admin" });

            }

            List<SelectListItem> guideList = (from x in guideManager.TGetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.GuideName,
                                                  Value = x.GuideID.ToString(),

                                              }).ToList();

            List<SelectListItem> FeatureTrueFalse = new List<SelectListItem>
            {
                new SelectListItem { Text = "Evet", Value = "true" },
                new SelectListItem { Text = "Hayır", Value = "false" }
             };



            ViewBag.FeatureTrueFalse = FeatureTrueFalse;
            ViewBag.GuideList = guideList;


            return View();
        }

        public IActionResult DeleteDestination(int id)
        {
            var findDestination = destinationManager.GetByID(id);

            findDestination.DestinationStatus = false;

            destinationManager.TUppdate(findDestination);

            return RedirectToAction("Index", "Destination", new { area = "Admin" });
        }

    }
}
