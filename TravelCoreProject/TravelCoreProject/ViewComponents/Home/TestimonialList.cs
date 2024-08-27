using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.ViewComponents.Home
{
    public class TestimonialList:ViewComponent
    {


        TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonialDAL());

        public IViewComponentResult Invoke()
        {
            var testimoniaClientList = testimonialManager.GetListClient();

            return View(testimoniaClientList);
        }

    }
}
