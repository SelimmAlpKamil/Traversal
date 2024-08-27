using DataAccessLayer.Abstract.Abstractuow;
using DataAccessLayer.Concreate;
using DataAccessLayer.Repository.Repositoryuow;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework.EntityFrameworkuow
{
    public class EFAccoundDAL : GenericRepositoryuow<Accound>, IAccoundDAL
    {
        public EFAccoundDAL(Context context) : base(context)
        {
        }
    }
}
