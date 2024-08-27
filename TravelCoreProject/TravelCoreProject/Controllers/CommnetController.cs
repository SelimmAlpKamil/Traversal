using BusinessLayer.Abstract;
using BusinessLayer.Concreate;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Windows.Input;

namespace TravelCoreProject.Controllers
{
    [AllowAnonymous]
    public class CommnetController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());

       

        [HttpGet] 
        public IActionResult AddCommnet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCommnet(Comment p)
        {
            AddCommnetValidation validationRules = new AddCommnetValidation();
            var rule = validationRules.Validate(p);

            p.CommentStatus = true;
            p.CommentDate = Convert.ToDateTime(DateTime.Today);
            var destinationId = p.DestinationId;

            if (rule.IsValid)
            {

                commentManager.TAdd(p);

                return RedirectToAction("DestinationDetail", "Destination", new { id = destinationId });
            }
            else
            {
                TempData["error"] =  string.Join(" ",rule.Errors.Select(x => x.ErrorMessage));

                return RedirectToAction("DestinationDetail", "Destination", new { id = destinationId });
            }


            
        }
    }
}
