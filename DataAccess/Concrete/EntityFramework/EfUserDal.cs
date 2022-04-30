using DataAccess.Abstract;
using Entities.Contret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,ProjectContext>,IUserDal
    {
    }
}
