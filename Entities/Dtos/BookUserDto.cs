
using Entities.Abstract;

namespace Entities.Dtos
{
    public class BookUserDto : IDto
    {
        public string FullNameUser { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
    }
}
