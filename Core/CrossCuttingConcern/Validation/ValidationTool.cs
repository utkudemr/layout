using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcern.Validation
{
    public class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);
            if (!result.IsValid)
            {
                var str = "";
                foreach (var item in result.Errors)
                {
                    str+="/"+item.ErrorMessage;
                }
                throw new ValidationException(str);
            }
        }
    }
}
