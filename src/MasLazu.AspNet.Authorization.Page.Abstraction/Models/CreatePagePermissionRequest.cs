namespace MasLazu.AspNet.Authorization.Page.Abstraction.Models;

public record CreatePagePermissionRequest(
    Guid PageId,
    Guid PermissionId
);
