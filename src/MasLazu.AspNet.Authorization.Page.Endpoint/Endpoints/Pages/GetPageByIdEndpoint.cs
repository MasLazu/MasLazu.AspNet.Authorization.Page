using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Page.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Page.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Models;
using MasLazu.AspNet.Authorization.Page.Endpoint.EndpointGroups;
using MasLazu.AspNet.Framework.Application.Exceptions;

namespace MasLazu.AspNet.Authorization.Page.Endpoint.Endpoints.Pages;

public class GetPageByIdEndpoint : BaseEndpoint<IdRequest, PageDto>
{
    public IPageService PageService { get; set; }

    public override void ConfigureEndpoint()
    {
        Get("/{Id}");
        Group<PagesEndpointGroup>();
    }

    public override async Task HandleAsync(IdRequest req, CancellationToken ct)
    {
        PageDto result = await PageService.GetByIdAsync(Guid.Empty, req.Id, ct) ??
            throw new NotFoundException(nameof(PageDto), req.Id);
        await SendOkResponseAsync(result, "Page Retrieved Successfully", ct);
    }
}
