using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactUsService:IGenericService<ContactUs>
    {
        List<ContactUs> GetListTrue();   
        List<ContactUs> GetListFalse();
        void ChangeToFalse(int id);
        void ChangeToTrue(int id);



    }
}
