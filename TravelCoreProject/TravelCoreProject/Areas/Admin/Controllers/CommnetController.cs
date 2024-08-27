using BusinessLayer.Abstract;
using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]

    public class CommnetController : Controller
    {

        CommentManager commentManager = new CommentManager(new EfCommentDal());

        

        public IActionResult Index()
        {
            var commnetList = commentManager.GetCommentsByDestinationDestinationName();

            return View(commnetList);
        }


        public IActionResult DeleteCommnet(int id)
        {
            var findCommnet = commentManager.GetByID(id);

            findCommnet.CommentStatus = false;

            commentManager.TUppdate(findCommnet);

            return RedirectToAction("Index", "Commnet");
        }
    }



  
}
