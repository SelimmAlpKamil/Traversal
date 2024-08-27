using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using DataAccessLayer.Repository;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFTestimonialDAL : GenericRepository<Testimonial>, ITestiMonialDAL
    {
        public List<Testimonial> TGetListClient(Func<Testimonial, bool> Filter, int ClientNumber)
        {
            using var c = new Context();
            return c.Testimonials.Where(Filter).Take(ClientNumber).ToList();
        }
    }
}
