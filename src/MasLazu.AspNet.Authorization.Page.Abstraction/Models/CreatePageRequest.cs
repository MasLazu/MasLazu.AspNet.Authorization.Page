namespace MasLazu.AspNet.Authorization.Page.Abstraction.Models;

public record CreatePageRequest(
    Guid? ParentId,
    Guid? PageGroupId,
    string Code,
    string Name,
    string Path
);
