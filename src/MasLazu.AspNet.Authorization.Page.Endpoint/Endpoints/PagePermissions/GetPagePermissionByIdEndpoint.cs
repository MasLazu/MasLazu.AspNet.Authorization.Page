using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Page.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Page.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Models;
using MasLazu.AspNet.Authorization.Page.Endpoint.EndpointGroups;
using MasLazu.AspNet.Framework.Application.Exceptions;

namespace MasLazu.AspNet.Authorization.Page.Endpoint.Endpoints.PagePermissions;

public class GetPagePermissionByIdEndpoint : BaseEndpoint<IdRequest, PagePermissionDto>
{
    public IPagePermissionService PagePermissionService { get; set; }

    public override void ConfigureEndpoint()
    {
        Get("/{Id}");
        Group<PagePermissionsEndpointGroup>();
    }

    public override async Task HandleAsync(IdRequest req, CancellationToken ct)
    {
        PagePermissionDto result = await PagePermissionService.GetByIdAsync(Guid.Empty, req.Id, ct) ??
            throw new NotFoundException(nameof(PagePermissionDto), req.Id);
        await SendOkResponseAsync(result, "Page Permission Retrieved Successfully", ct);
    }
}
