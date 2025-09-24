using System.Linq.Expressions;
using MasLazu.AspNet.Framework.Application.Interfaces;
using MasLazu.AspNet.Authorization.Page.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Page.Utils;

public class PagePermissionEntityPropertyMap : IEntityPropertyMap<PagePermission>
{
    private readonly Dictionary<string, Expression<Func<PagePermission, object>>> _map =
        new(StringComparer.OrdinalIgnoreCase)
        {
            { "id", pp => pp.Id },
            { "pageId", pp => pp.PageId },
            { "permissionId", pp => pp.PermissionId },
            { "createdAt", pp => pp.CreatedAt },
            { "updatedAt", pp => pp.UpdatedAt! },
        };

    public Expression<Func<PagePermission, object>> Get(string property)
    {
        if (_map.TryGetValue(property, out Expression<Func<PagePermission, object>>? expr))
        {
            return expr;
        }

        throw new ArgumentException($"Property '{property}' is not supported for PagePermission. " +
            $"Supported properties: {string.Join(", ", _map.Keys)}");
    }
}
