using Microsoft.Extensions.DependencyInjection;
using MasLazu.AspNet.Authorization.Page.Services;
using MasLazu.AspNet.Authorization.Page.Abstraction.Interfaces;

namespace MasLazu.AspNet.Authorization.Page.Extensions;

public static class AuthorizationPageApplicationServiceExtension
{
    public static IServiceCollection AddAuthorizationPageApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IPageService, PageService>();
        services.AddScoped<IPageGroupService, PageGroupService>();
        services.AddScoped<IPagePermissionService, PagePermissionService>();

        return services;
    }
}
