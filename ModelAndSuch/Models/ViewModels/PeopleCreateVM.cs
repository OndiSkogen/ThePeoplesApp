using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelAndSuch.Models.ViewModels
{
    public class PeopleCreateVM
    {
        [Required (ErrorMessage ="Please enter a name")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [Required (ErrorMessage = "Please enter a e-mail address")]
        [HardCodedEmail ()]
        public string Email { get; set; }

        [Display (Name = "What is 2 + 2?")]
        [Range (4, 4)]
        public int BotCheck { get; set; }
    }
}
