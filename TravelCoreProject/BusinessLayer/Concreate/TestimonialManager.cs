using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class TestimonialManager:ITestimonialService
    {
        EFTestimonialDAL _testimonial;

        public TestimonialManager(EFTestimonialDAL testimonial)
        {
            _testimonial = testimonial;
        }

        public Testimonial GetByID(int id)
        {
            return _testimonial.TGet(id);
        }

        public List<Testimonial> GetListClient()
        {
            return _testimonial.TGetListClient(x=>x.TestimonialStatus==true,6);
        }

        public void TAdd(Testimonial t)
        {
            _testimonial.Insert(t);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonial.GetList();
        }

        public void TRemove(Testimonial t)
        {
            _testimonial.Delete(t);
        }

        public void TUppdate(Testimonial t)
        {
            _testimonial.Update(t);
        }
    }
}
