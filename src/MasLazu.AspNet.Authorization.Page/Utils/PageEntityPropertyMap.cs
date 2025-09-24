using System.Linq.Expressions;
using MasLazu.AspNet.Framework.Application.Interfaces;

namespace MasLazu.AspNet.Authorization.Page.Utils;

public class PageEntityPropertyMap : IEntityPropertyMap<Domain.Entities.Page>
{
    private readonly Dictionary<string, Expression<Func<Domain.Entities.Page, object>>> _map =
        new(StringComparer.OrdinalIgnoreCase)
        {
            { "id", p => p.Id },
            { "parentId", p => p.ParentId! },
            { "pageGroupId", p => p.PageGroupId! },
            { "code", p => p.Code },
            { "name", p => p.Name },
            { "path", p => p.Path },
            { "createdAt", p => p.CreatedAt },
            { "updatedAt", p => p.UpdatedAt! },
        };

    public Expression<Func<Domain.Entities.Page, object>> Get(string property)
    {
        if (_map.TryGetValue(property, out Expression<Func<Domain.Entities.Page, object>>? expr))
        {
            return expr;
        }

        throw new ArgumentException($"Property '{property}' is not supported for Page. " +
            $"Supported properties: {string.Join(", ", _map.Keys)}");
    }
}
