using Entities.Abstract;
using System;

namespace Entities.Contret
{
    public class BookUser:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}
