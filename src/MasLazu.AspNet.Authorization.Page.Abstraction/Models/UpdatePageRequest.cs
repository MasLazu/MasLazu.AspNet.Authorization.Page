using MasLazu.AspNet.Framework.Application.Models;

namespace MasLazu.AspNet.Authorization.Page.Abstraction.Models;

public record UpdatePageRequest(
    Guid Id,
    Guid? ParentId,
    Guid? PageGroupId,
    string? Code,
    string? Name,
    string? Path
) : BaseUpdateRequest(Id);
