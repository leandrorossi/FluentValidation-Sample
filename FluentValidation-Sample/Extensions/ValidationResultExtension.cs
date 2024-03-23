using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FluentValidation_Sample.Extensions
{
    public static class ValidationResultExtension
    {
        public static void AddErrorToModelState(this ValidationResult result, ModelStateDictionary modelState)
        {
            foreach (var error in result.Errors)
            {
                modelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
        }
    }
}
