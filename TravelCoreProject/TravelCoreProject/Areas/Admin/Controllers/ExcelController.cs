using BusinessLayer.Concreate;
using DataAccessLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Linq;
using TravelCoreProject.Areas.Admin.Models;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExcelController : Controller
    {
        ExcelManager excelManager = new ExcelManager();


        public IActionResult Index()
        {
            return View();
        }


        public List<DestinationExcelModel> destinationList()
        {
            List<DestinationExcelModel> destinationExcelModels = new List<DestinationExcelModel>();

            using var value = new Context();

            destinationExcelModels = value.Destinations.Select(x=> new DestinationExcelModel
            {
                Capacity=x.DestinationCapacity,
                City=x.DestinationCity,
                DayAndNight=x.DestinationDayAndNight,
                Price=x.DestinationPrice,
            }).ToList();

            return destinationExcelModels;

        }

        public IActionResult DynamicExcel()
        {
            
            return File(excelManager.ExcelList(destinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Tur_Rotaları2.xlsx");


        }

    }
}
