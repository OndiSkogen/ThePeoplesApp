using System;
using System.Collections.Generic;

namespace ModelAndSuch.Models.Entities
{
    public partial class Company
    {
        public Company()
        {
            Person = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public ICollection<Person> Person { get; set; }
    }
}
