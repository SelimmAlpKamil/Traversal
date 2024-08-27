using AutoMapper;
using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using DTOLayer.AnnouncementDTOs;
using EntityLayer.Concreate;
using iTextSharp.text;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TravelCoreProject.Areas.Admin.Models;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AnnouncementController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EFAnnouncementDAL());

        private readonly IMapper _mapper;

        public AnnouncementController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {

            var values = _mapper.Map<List<AnnouncementListDTOs>>(announcementManager.TGetList());

            return View(values);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDTOs p)
        {
            if (ModelState.IsValid)
            {
                announcementManager.TAdd(new Announcement
                {
                    AnnouncementTitle = p.AnnouncementTitle,
                    AnnouncementContent = p.AnnouncementContent,
                    AnnouncementDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    AnnouncementStatus = true

                });

                return RedirectToAction("Index", "Announcement");
            }

            return View();

        }

        [HttpGet]
        public IActionResult UppdateAnnouncement(int id)
        {
            var findAnnouncement = _mapper.Map<AnnouncementUppdateDTOs>(announcementManager.GetByID(id));

            return View(findAnnouncement);

        }

        [HttpPost]
        public IActionResult UppdateAnnouncement(AnnouncementUppdateDTOs p)
        {
            if (ModelState.IsValid)
            {
                announcementManager.TUppdate(new Announcement
                {
                    AnnouncementTitle = p.AnnouncementTitle,
                    AnnouncementContent = p.AnnouncementContent,
                    AnnouncementDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    AnnouncementStatus = true
                });
                return RedirectToAction("Index", "Announcement");
            }
            return View();

            

        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var findAnnouncement = announcementManager.GetByID(id);
            announcementManager.TRemove(findAnnouncement);

            return RedirectToAction("Index", "Announcement");
        }









    }
}
