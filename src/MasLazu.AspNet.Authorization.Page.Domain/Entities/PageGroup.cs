using MasLazu.AspNet.Framework.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Page.Domain.Entities;

public class PageGroup : BaseEntity
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Icon { get; set; }

    public ICollection<Page>? Pages { get; set; }
}
