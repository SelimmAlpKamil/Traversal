using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ITestiMonialDAL:IGenericDAL<Testimonial>
    {
        List<Testimonial> TGetListClient(Func<Testimonial,bool>Filter,int ClientNumber);
    }
}
