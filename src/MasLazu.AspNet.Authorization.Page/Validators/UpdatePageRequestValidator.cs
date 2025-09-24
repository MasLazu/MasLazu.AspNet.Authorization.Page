using FluentValidation;
using MasLazu.AspNet.Authorization.Page.Abstraction.Models;

namespace MasLazu.AspNet.Authorization.Page.Validators;

public class UpdatePageRequestValidator : AbstractValidator<UpdatePageRequest>
{
        public UpdatePageRequestValidator()
        {
                When(x => x.Code != null, () => RuleFor(x => x.Code!)
                        .NotEmpty()
                        .MaximumLength(50));

                When(x => x.Name != null, () => RuleFor(x => x.Name!)
                        .NotEmpty()
                        .MaximumLength(100));

                When(x => x.Path != null, () => RuleFor(x => x.Path!)
                        .NotEmpty()
                        .MaximumLength(500));
        }
}
