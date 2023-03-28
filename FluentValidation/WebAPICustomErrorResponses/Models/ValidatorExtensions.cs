using FluentValidation;

namespace WebAPICustomErrorResponses.Models
{
    public static class ValidatorExtensions
    {
        public static IRuleBuilderOptions<T, TProperty> WithError<T, TProperty>(this IRuleBuilderOptions<T, TProperty> rule, string errorCode, string errorMessage)
        {
            return rule
                .WithErrorCode(errorCode)
                .WithMessage(errorMessage);
        }
    }
}
