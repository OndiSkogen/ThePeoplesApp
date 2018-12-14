using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelAndSuch
{
    public class HardcodedHighlightAttribute : ValidationAttribute
    {
        string correctValue;
        public HardcodedHighlightAttribute(string correctValue)
        {
            this.correctValue = correctValue;
        }

        public override bool IsValid(object value)
        {
            return value?.ToString().StartsWith(correctValue) ?? false;
        }
    }
}
