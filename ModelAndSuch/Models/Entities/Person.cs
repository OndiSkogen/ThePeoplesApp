using System;
using System.Collections.Generic;

namespace ModelAndSuch.Models.Entities
{
    public partial class Person
    {
        public Person()
        {
            Company = new HashSet<Company>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Company> Company { get; set; }
    }
}
