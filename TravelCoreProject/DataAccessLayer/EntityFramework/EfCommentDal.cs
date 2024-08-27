using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using DataAccessLayer.Repository;
using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
      

        public List<Comment> GetCommentsByDestinationDestinationName(Func<Comment, bool> Filter)
        {
            using var value = new Context();

            return value.Comments.Include(x=>x.Destination).Where(Filter).ToList();
        }

        
    }
}
