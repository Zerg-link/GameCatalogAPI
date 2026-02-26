// Validation/DateAttribute.cs


using System.ComponentModel.DataAnnotations;

namespace GameCatalogAPI.Validation
{
    /// <summary>
    /// Attribute checks that date isn't in future.
    /// </summary>
    public class DateNotFutureAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // Future checking.
            if (value is DateTime date && date > DateTime.Now)
                return new ValidationResult("Date can't be in the future");


            return ValidationResult.Success;
        }
    }
}
