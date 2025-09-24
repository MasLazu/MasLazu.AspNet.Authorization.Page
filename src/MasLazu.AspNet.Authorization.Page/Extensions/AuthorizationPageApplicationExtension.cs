using Microsoft.Extensions.DependencyInjection;

namespace MasLazu.AspNet.Authorization.Page.Extensions;

public static class AuthorizationPageApplicationExtension
{
    public static IServiceCollection AddAuthorizationPageApplication(this IServiceCollection services)
    {
        services.AddAuthorizationPageApplicationServices();
        services.AddAuthorizationPageApplicationUtils();
        services.AddAuthorizationPageApplicationValidators();

        return services;
    }
}
