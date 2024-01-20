using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Attributes
{
    public class AdultAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime date = (DateTime)value;
            DateTime present = DateTime.Now;
            TimeSpan result = present.Subtract(date);
            return result.TotalDays >= 6570;
        }
    }
}
