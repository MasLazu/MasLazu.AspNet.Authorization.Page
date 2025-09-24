using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Page.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Page.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Models;
using MasLazu.AspNet.Authorization.Page.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Page.Endpoint.Endpoints.PageGroups;

public class GetPageGroupsPaginatedEndpoint : BaseEndpoint<PaginationRequest, PaginatedResult<PageGroupDto>>
{
    public IPageGroupService PageGroupService { get; set; }

    public override void ConfigureEndpoint()
    {
        Post("/paginated");
        Group<PageGroupsEndpointGroup>();
        AllowAnonymous();
    }

    public override async Task HandleAsync(PaginationRequest req, CancellationToken ct)
    {
        PaginatedResult<PageGroupDto> result = await PageGroupService.GetPaginatedAsync(Guid.Empty, req, ct);
        await SendOkResponseAsync(result, "Page Groups Retrieved Successfully", ct);
    }
}
