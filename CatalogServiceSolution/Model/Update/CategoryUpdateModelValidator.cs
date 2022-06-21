using FluentValidation;

namespace Model.Update
{
    public class CategoryUpdateModelValidator : AbstractValidator<CategoryUpdateModel>
    {
        public CategoryUpdateModelValidator()
        {
            RuleFor(x => x.Id).GreaterThanOrEqualTo(1);

            RuleFor(x => x.Name)
                .NotNull().WithMessage("Can not be null")
                .NotEmpty().WithMessage("Can not be empty")
                .MaximumLength(50).WithMessage("Maximum characters are 50");
        }
    }
}
