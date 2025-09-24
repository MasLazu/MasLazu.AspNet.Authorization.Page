using System.Linq.Expressions;
using MasLazu.AspNet.Framework.Application.Interfaces;
using MasLazu.AspNet.Authorization.Page.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Page.Utils;

public class PageGroupEntityPropertyMap : IEntityPropertyMap<PageGroup>
{
    private readonly Dictionary<string, Expression<Func<PageGroup, object>>> _map =
        new(StringComparer.OrdinalIgnoreCase)
        {
            { "id", pg => pg.Id },
            { "code", pg => pg.Code },
            { "name", pg => pg.Name },
            { "icon", pg => pg.Icon! },
            { "createdAt", pg => pg.CreatedAt },
            { "updatedAt", pg => pg.UpdatedAt! },
        };

    public Expression<Func<PageGroup, object>> Get(string property)
    {
        if (_map.TryGetValue(property, out Expression<Func<PageGroup, object>>? expr))
        {
            return expr;
        }

        throw new ArgumentException($"Property '{property}' is not supported for PageGroup. " +
            $"Supported properties: {string.Join(", ", _map.Keys)}");
    }
}
