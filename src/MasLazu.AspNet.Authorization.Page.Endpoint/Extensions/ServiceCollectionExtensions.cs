using Microsoft.Extensions.DependencyInjection;

namespace MasLazu.AspNet.Authorization.Page.Endpoint.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAuthorizationPageEndpoints(this IServiceCollection services)
    {
        return services;
    }
}
