using MasLazu.AspNet.Framework.Application.Models;

namespace MasLazu.AspNet.Authorization.Page.Abstraction.Models;

public record PageDto(
    Guid Id,
    Guid? ParentId,
    Guid? PageGroupId,
    string Code,
    string Name,
    string Path,
    DateTimeOffset CreatedAt,
    DateTimeOffset? UpdatedAt
) : BaseDto(Id, CreatedAt, UpdatedAt);
