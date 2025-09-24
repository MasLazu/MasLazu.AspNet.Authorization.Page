using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Page.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Page.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Models;
using MasLazu.AspNet.Authorization.Page.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Page.Endpoint.Endpoints.Pages;

public class GetPagesPaginatedEndpoint : BaseEndpoint<PaginationRequest, PaginatedResult<PageDto>>
{
    public IPageService PageService { get; set; }

    public override void ConfigureEndpoint()
    {
        Post("/paginated");
        Group<PagesEndpointGroup>();
        AllowAnonymous();
    }

    public override async Task HandleAsync(PaginationRequest req, CancellationToken ct)
    {
        PaginatedResult<PageDto> result = await PageService.GetPaginatedAsync(Guid.Empty, req, ct);
        await SendOkResponseAsync(result, "Pages Retrieved Successfully", ct);
    }
}
