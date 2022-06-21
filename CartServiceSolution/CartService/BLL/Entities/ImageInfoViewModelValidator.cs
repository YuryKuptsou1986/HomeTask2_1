using FluentValidation;

namespace CartService.BLL.Entities
{
    public class ImageInfoViewModelValidator : AbstractValidator<ImageInfoViewModel>
    {
        public ImageInfoViewModelValidator()
        {
            RuleFor(x => x.Url).NotNull().NotEmpty().WithMessage("Can not be null or empty");
        }
    }
}
