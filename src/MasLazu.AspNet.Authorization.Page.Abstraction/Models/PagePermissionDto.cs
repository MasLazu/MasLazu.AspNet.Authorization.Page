using MasLazu.AspNet.Framework.Application.Models;

namespace MasLazu.AspNet.Authorization.Page.Abstraction.Models;

public record PagePermissionDto(
    Guid Id,
    Guid PageId,
    Guid PermissionId,
    DateTimeOffset CreatedAt,
    DateTimeOffset? UpdatedAt
) : BaseDto(Id, CreatedAt, UpdatedAt);
