using System;
using Entities.Abstract;

namespace Entities.Contret 
{
   public class Author:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
