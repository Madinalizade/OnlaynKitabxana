using DataAccess.Abstract;
using Entities.Dtos;
using Entities.Contret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookUserDal : EfEntityRepositoryBase<BookUser, ProjectContext>, IBookUserDal
    {
        public List<BookUserDto> GetBookUserDetails()
        {
            using (ProjectContext context = new ProjectContext())
            {
                var result = from bookUsers in context.BookUsers
                             join book in context.Books on bookUsers.BookId equals book.Id
                             join user in context.Users on bookUsers.UserId equals user.Id
                             join author in context.Authors on book.AuthorId equals author.Id
                             select new BookUserDto
                             {
                                 AuthorName = author.FirstName + " " + author.LastName,
                                 BookName = book.Name,
                                 FullNameUser = user.FirstName + " " + user.LastName
                             };
                return result.ToList();
            }
        }
    }
}
