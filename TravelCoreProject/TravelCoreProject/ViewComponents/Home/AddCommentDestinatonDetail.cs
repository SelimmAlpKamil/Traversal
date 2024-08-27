using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.ViewComponents.Home
{
    public class AddCommentDestinatonDetail:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());

        public IViewComponentResult Invoke(int id)
        {
             ViewBag.Id = id;   

            return View();
        }

    }
}
