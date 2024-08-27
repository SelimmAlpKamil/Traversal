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
    public class CommentManager:ICommentService
    {
        EfCommentDal _commnet;

        public CommentManager(EfCommentDal commnet)
        {
            _commnet = commnet;
        }

        public Comment GetByID(int id)
        {
            return _commnet.TGet(id);
        }

      

        public List<Comment> GetCommentsByDestination(int destinatonId)
        {
            return _commnet.GetList(x=>x.DestinationId == destinatonId && x.CommentStatus ==true);
        }

        public List<Comment> GetCommentsByDestinationDestinationName()
        {
            return _commnet.GetCommentsByDestinationDestinationName(x=>x.CommentStatus ==true);
        }

   

        public void TAdd(Comment t)
        {
            _commnet.Insert(t);
        }

        public List<Comment> TGetList()
        {
            return _commnet.GetList();
        }

        public void TRemove(Comment t)
        {
           _commnet.Delete(t);
        }

        public void TUppdate(Comment t)
        {
            _commnet.Update(t);
        }
    }
}
