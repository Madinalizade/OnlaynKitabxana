using Entities.Contret;
using Entities.Dtos;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IBookUserDal:IEntityRepositoryBase<BookUser>
    {
        List<BookUserDto> GetBookUserDetails();
    }
}
