using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelAndSuch.Models.ViewModels
{
    public class PeopleIndexVM
    {
        public int Id { get; set; }

        [Display (Name = "First name")]
        public string Name { get; set; }

        [Display (Name = "E-mail")]
        public string Email { get; set; }
      
        public bool ShowAsHighlighted { get; set; }

        public string CompanyName { get; set; }
    }
}
