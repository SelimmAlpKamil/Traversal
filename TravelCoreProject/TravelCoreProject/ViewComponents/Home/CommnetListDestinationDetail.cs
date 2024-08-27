using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelCoreProject.ViewComponents.Home
{
    public class CommnetListDestinationDetail:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());

       

        public IViewComponentResult Invoke(int id)
        {
            

            var commnetList = commentManager.GetCommentsByDestination(id);

            return View(commnetList);
        }

    }
}
