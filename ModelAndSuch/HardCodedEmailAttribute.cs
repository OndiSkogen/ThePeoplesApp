using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ModelAndSuch
{
    public class HardCodedEmailAttribute : ValidationAttribute
    {
        string correctValue;
        public HardCodedEmailAttribute()
        {
            //this.correctValue = correctValue;
        }

        public override bool IsValid(object value)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(value.ToString());
            //return value?.ToString().EndsWith(correctValue) ?? false;
        }
    }
}
