using FluentValidation;
using MasLazu.AspNet.Authorization.Page.Abstraction.Models;

namespace MasLazu.AspNet.Authorization.Page.Validators;

public class CreatePageGroupRequestValidator : AbstractValidator<CreatePageGroupRequest>
{
    public CreatePageGroupRequestValidator()
    {
        RuleFor(x => x.Code)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.Icon)
            .MaximumLength(100);
    }
}
