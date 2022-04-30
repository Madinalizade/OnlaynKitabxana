using Entities.Contret;
using System.Data.Entity;

namespace DataAccess.Concrete.EntityFramework
{
    public class ProjectContext :DbContext
    {
        public DbSet<Book> Books { get; set; }
        public  DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<BookUser> BookUsers { get; set; }
    }
}