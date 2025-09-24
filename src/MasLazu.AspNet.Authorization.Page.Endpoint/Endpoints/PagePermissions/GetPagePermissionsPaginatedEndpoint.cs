using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Page.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Page.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Models;
using MasLazu.AspNet.Authorization.Page.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Page.Endpoint.Endpoints.PagePermissions;

public class GetPagePermissionsPaginatedEndpoint : BaseEndpoint<PaginationRequest, PaginatedResult<PagePermissionDto>>
{
    public IPagePermissionService PagePermissionService { get; set; }

    public override void ConfigureEndpoint()
    {
        Post("/paginated");
        Group<PagePermissionsEndpointGroup>();
        AllowAnonymous();
    }

    public override async Task HandleAsync(PaginationRequest req, CancellationToken ct)
    {
        PaginatedResult<PagePermissionDto> result = await PagePermissionService.GetPaginatedAsync(Guid.Empty, req, ct);
        await SendOkResponseAsync(result, "Page Permissions Retrieved Successfully", ct);
    }
}
