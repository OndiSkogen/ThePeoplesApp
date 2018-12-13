using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelAndSuch
{
    public class HardCodedEmailAttribute : ValidationAttribute
    {
        string correctValue;
        public HardCodedEmailAttribute(string correctValue)
        {
            this.correctValue = correctValue;
        }

        public override bool IsValid(object value)
        {
            return value?.ToString().EndsWith(correctValue) ?? false;
        }
    }
}
