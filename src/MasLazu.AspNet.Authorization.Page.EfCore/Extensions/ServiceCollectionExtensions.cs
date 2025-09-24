using Microsoft.Extensions.DependencyInjection;

namespace MasLazu.AspNet.Authorization.Page.EfCore.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAuthorizationPageEntityFrameworkCore(this IServiceCollection services)
    {
        return services;
    }
}
