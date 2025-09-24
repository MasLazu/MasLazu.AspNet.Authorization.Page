using FluentValidation;
using MasLazu.AspNet.Authorization.Page.Abstraction.Models;

namespace MasLazu.AspNet.Authorization.Page.Validators;

public class CreatePagePermissionRequestValidator : AbstractValidator<CreatePagePermissionRequest>
{
    public CreatePagePermissionRequestValidator()
    {
        RuleFor(x => x.PageId)
            .NotEmpty();

        RuleFor(x => x.PermissionId)
            .NotEmpty();
    }
}
