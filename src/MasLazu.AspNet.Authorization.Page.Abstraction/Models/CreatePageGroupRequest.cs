namespace MasLazu.AspNet.Authorization.Page.Abstraction.Models;

public record CreatePageGroupRequest(
    string Code,
    string Name,
    string? Icon
);
