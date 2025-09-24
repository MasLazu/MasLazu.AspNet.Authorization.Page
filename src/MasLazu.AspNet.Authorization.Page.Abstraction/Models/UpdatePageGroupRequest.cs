using MasLazu.AspNet.Framework.Application.Models;

namespace MasLazu.AspNet.Authorization.Page.Abstraction.Models;

public record UpdatePageGroupRequest(
    Guid Id,
    string? Code,
    string? Name,
    string? Icon
) : BaseUpdateRequest(Id);
