using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;


namespace TravelCoreProject.ViewComponents.Home
{
    public class DestinationSearch:ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());
        public IViewComponentResult Invoke()
        {

            List<SelectListItem> list = (from x in destinationManager.TGetList()
                                         select new SelectListItem
                                         {
                                             Value = x.DestinationId.ToString(),
                                             Text = x.DestinationCity,
                                         }).ToList();


            ViewBag.destinationList = list;


            var destinationList = destinationManager.TGetList();

            

            return View();
            
        }
    }
}
