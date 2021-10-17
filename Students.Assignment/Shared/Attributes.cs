using System;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Learner.Shared
{
    public class MinimumAgeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime date;
            var parsed = DateTime.TryParse(value.ToString(), out date);
            if (!parsed)
                return new ValidationResult("Invalid Date");
            var min = DateTime.Now.AddYears(-16); //for min 16 age
            var max = DateTime.Now.AddYears(-100); //for max 100 age
            var msg = $"Please enter a value between {max:MM/dd/yyyy} and {min:MM/dd/yyyy}";

            if (date > min || date < max)
                return new ValidationResult(msg);
            return ValidationResult.Success;
        }
    }
}