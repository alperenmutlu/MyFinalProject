using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        //static sınıfın metotlarıda static olur c#'ta.
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);            
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
