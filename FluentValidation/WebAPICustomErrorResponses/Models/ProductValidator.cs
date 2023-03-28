using FluentValidation;

namespace WebAPICustomErrorResponses.Models
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty()
                .WithError("name_required", "Product name cannot be empty");

            RuleFor(p => p.Quantity).GreaterThan(0)
                .WithError("quantity_invalid", "Quantity must be greater than 0");
        }
    }
}
