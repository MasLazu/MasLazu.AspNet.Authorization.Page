using MasLazu.AspNet.Framework.Application.Models;

namespace MasLazu.AspNet.Authorization.Page.Abstraction.Models;

public record UpdatePagePermissionRequest(
    Guid Id,
    Guid? PageId,
    Guid? PermissionId
) : BaseUpdateRequest(Id);
