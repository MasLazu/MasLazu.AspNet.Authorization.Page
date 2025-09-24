using MasLazu.AspNet.Framework.Application.Models;

namespace MasLazu.AspNet.Authorization.Page.Abstraction.Models;

public record PageGroupDto(
    Guid Id,
    string Code,
    string Name,
    string? Icon,
    DateTimeOffset CreatedAt,
    DateTimeOffset? UpdatedAt
) : BaseDto(Id, CreatedAt, UpdatedAt);
