using Microsoft.Extensions.DependencyInjection;
using MasLazu.AspNet.Authorization.Page.Utils;
using MasLazu.AspNet.Authorization.Page.Domain.Entities;
using MasLazu.AspNet.Framework.Application.Interfaces;
using MasLazu.AspNet.Framework.Application.Utils;

namespace MasLazu.AspNet.Authorization.Page.Extensions;

public static class AuthorizationPageApplicationUtilExtension
{
    public static IServiceCollection AddAuthorizationPageApplicationUtils(this IServiceCollection services)
    {
        RegisterPropertyMapsAndExpressionBuilders(services);

        return services;
    }

    private static void RegisterPropertyMapsAndExpressionBuilders(IServiceCollection services)
    {
        var entityPropertyMapPairs = new (Type entityType, Type propertyMapType)[]
        {
            (typeof(Domain.Entities.Page), typeof(PageEntityPropertyMap)),
            (typeof(PageGroup), typeof(PageGroupEntityPropertyMap)),
            (typeof(PagePermission), typeof(PagePermissionEntityPropertyMap))
        };

        foreach ((Type entityType, Type propertyMapType) in entityPropertyMapPairs)
        {
            Type propertyMapInterfaceType = typeof(IEntityPropertyMap<>).MakeGenericType(entityType);
            services.AddSingleton(propertyMapInterfaceType, propertyMapType);

            Type expressionBuilderType = typeof(ExpressionBuilder<>).MakeGenericType(entityType);
            services.AddScoped(expressionBuilderType);
        }
    }
}
