using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICommentDal:IGenericDAL<Comment>
    {
        List<Comment> GetCommentsByDestinationDestinationName(Func<Comment,bool>Filter);

 




    }
}
