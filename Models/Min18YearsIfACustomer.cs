using System.ComponentModel.DataAnnotations;

namespace CustomerRegistration.Models
{
    public class Min18YearsIfACustomer : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext){
            var customer = (Customer)validationContext.ObjectInstance;
            
            var age = DateTime.Today.Year - customer.Birthday.Year;

            return ( age >= 18 ) 
                ? ValidationResult.Success 
                : new ValidationResult("Customer should be at least 18 years old.");
        }
    }
}