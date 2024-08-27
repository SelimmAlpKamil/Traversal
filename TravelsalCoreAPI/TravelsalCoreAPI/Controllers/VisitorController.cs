using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TravelsalCoreAPI.DAL.Entity;
using TravelsalCoreAPI.DAL.Model;

namespace TravelsalCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        [HttpGet]
        public IActionResult VisitorList()
        {
            using (var c = new VisitorContext())
            {
                var visitorList = c.Visitors.ToList();

                return Ok(visitorList);
            }
        }

        [HttpPost]
        public IActionResult VisitorAdd(Visitor visitor)
        {
            using (var c = new VisitorContext())
            {
                c.Visitors.Add(visitor);
                c.SaveChanges();

                return Ok();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult VisitorDelete(int id) 
        {
            using(var c = new VisitorContext())
            {
                var findVisitor = c.Visitors.Find(id);

                if(findVisitor != null)
                {
                    c.Visitors.Remove(findVisitor);
                    c.SaveChanges() ;

                    return Ok();
                }
                else
                {
                    return NotFound();
                }

                  
            } 
        }


        [HttpGet("{id}")]
        public IActionResult VisitorGet(int id)
        {
            using(var c = new VisitorContext())
            {
                var findVisitor = c.Visitors.Find(id);
                if( findVisitor != null)
                {
                    return Ok(findVisitor);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        [HttpPut]
        public IActionResult actionUppdate(Visitor visitor)
        {
            using (var c = new VisitorContext())
            {
                var findVisitor = c.Visitors.Find(visitor.VisitorId);

                if(findVisitor!= null)
                {
                    findVisitor.VisitorName = visitor.VisitorName;
                    findVisitor.VisitorSurname = visitor.VisitorSurname;
                    findVisitor.VisitorCity = visitor.VisitorCity;
                    findVisitor.VisitorCountry = visitor.VisitorCountry;
                    findVisitor.VisitorMail = visitor.VisitorMail;

                    c.Visitors.Update(findVisitor);

                    c.SaveChanges();

                    return Ok(findVisitor);
                }
                else
                {
                    return NotFound();  
                }
            }
        }




    }
}
