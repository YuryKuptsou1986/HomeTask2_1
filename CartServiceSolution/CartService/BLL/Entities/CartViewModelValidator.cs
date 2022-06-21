using FluentValidation;

namespace CartService.BLL.Entities
{
    public class CartViewModelValidator : AbstractValidator<CartViewModel>
    {
        public CartViewModelValidator()
        {
            RuleFor(x => x.Price).GreaterThanOrEqualTo(0).WithMessage("Should be greater or equals 0");
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Can not be null or empty");
            RuleFor(x => x.Quantity).GreaterThanOrEqualTo(0).WithMessage("Should be greater or equals 0");
        }
    }
}
