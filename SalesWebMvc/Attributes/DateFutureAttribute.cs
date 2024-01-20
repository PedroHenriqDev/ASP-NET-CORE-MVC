using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Attributes
{
    public class DateFutureAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime data)
            {
                DateTime today = DateTime.Today;

                if (data.Year >= 2000 && data <= today)
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(ErrorMessage ?? "The date cannot be in the future and after the 2000s", new[] { validationContext.MemberName });
        }
    }
}

