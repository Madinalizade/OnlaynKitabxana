using Entities.Abstract;
using System;

namespace Entities.Contret
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
    }
}
