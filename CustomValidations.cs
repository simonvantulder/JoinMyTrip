using System;
using System.ComponentModel.DataAnnotations;

namespace LoginReg
{
    public class CustomValidators
    {
        public class FutureDate : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                DateTime date = (DateTime)value;
                return date < DateTime.Now ? new ValidationResult("must be in the future.") : ValidationResult.Success;
            }
        }
        public class IsAfter : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {

                return (bool)value == false ? new ValidationResult("must be after the Start Date.") : ValidationResult.Success;

            }
        }

    }
}