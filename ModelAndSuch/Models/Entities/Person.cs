using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelAndSuch.Models.Entities
{
    public partial class Person
    {
        public Person()
        {
            Company = new HashSet<Company>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Enter a name")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Enter a valid email address")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [HardCodedEmail("acme.com")]
        public string Email { get; set; }

        public ICollection<Company> Company { get; set; }
    }
}
