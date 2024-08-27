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
    public class UserManager : IUserService
    {
        EFUserDAL _usermanager;

        public UserManager(EFUserDAL usermanager)
        {
            _usermanager = usermanager;
        }

        public AppUser GetByID(int id)
        {
            return _usermanager.TGet(id);
        }

        public void TAdd(AppUser t)
        {
            _usermanager.Insert(t);
        }

        public List<AppUser> TGetList()
        {
            return _usermanager.GetList();
        }

        public void TRemove(AppUser t)
        {
            _usermanager.Delete(t);
        }

        public void TUppdate(AppUser t)
        {
            _usermanager.Update(t);
        }
    }
}
