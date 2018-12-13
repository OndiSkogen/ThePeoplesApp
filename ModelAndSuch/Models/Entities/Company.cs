using System;
using System.Collections.Generic;

namespace ModelAndSuch.Models.Entities
{
    public partial class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int? CompanyId { get; set; }

        public Person CompanyNavigation { get; set; }
    }
}
