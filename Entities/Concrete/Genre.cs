using Entities.Abstract;
using System;

namespace Entities.Contret
{
   public class Genre:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
