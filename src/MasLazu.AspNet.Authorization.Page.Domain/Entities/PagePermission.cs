using MasLazu.AspNet.Framework.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Page.Domain.Entities;

public class PagePermission : BaseEntity
{
    public Guid PageId { get; set; }
    public Guid PermissionId { get; set; }

    public Page? Page { get; set; }
}
