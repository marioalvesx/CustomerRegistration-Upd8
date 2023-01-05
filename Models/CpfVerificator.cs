using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Caelum.Stella.CSharp.Validation;

namespace CustomerRegistration.Models
{
    public class CpfVerificator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext){
            var customer = (Customer)validationContext.ObjectInstance;
            
            // CPF Validator - Alura
            if(new CPFValidator().IsValid(customer.Cpf)) {
                return ValidationResult.Success;
            }else{
                return new ValidationResult("CPF is not valid!");
            }
            
        }
    }
}