using Microsoft.Extensions.DependencyInjection;
using MasLazu.AspNet.Authorization.Page.Validators;
using FluentValidation;
using MasLazu.AspNet.Authorization.Page.Abstraction.Models;

namespace MasLazu.AspNet.Authorization.Page.Extensions;

public static class AuthorizationPageApplicationValidatorExtension
{
    public static IServiceCollection AddAuthorizationPageApplicationValidators(this IServiceCollection services)
    {
        services.AddScoped<IValidator<CreatePageRequest>, CreatePageRequestValidator>();
        services.AddScoped<IValidator<UpdatePageRequest>, UpdatePageRequestValidator>();
        services.AddScoped<IValidator<CreatePageGroupRequest>, CreatePageGroupRequestValidator>();
        services.AddScoped<IValidator<UpdatePageGroupRequest>, UpdatePageGroupRequestValidator>();
        services.AddScoped<IValidator<CreatePagePermissionRequest>, CreatePagePermissionRequestValidator>();
        services.AddScoped<IValidator<UpdatePagePermissionRequest>, UpdatePagePermissionRequestValidator>();

        return services;
    }
}
