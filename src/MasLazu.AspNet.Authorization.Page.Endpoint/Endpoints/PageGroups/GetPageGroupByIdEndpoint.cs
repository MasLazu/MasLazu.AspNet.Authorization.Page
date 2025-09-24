using FastEndpoints;
using MasLazu.AspNet.Framework.Endpoint.Endpoints;
using MasLazu.AspNet.Authorization.Page.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Page.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Models;
using MasLazu.AspNet.Authorization.Page.Endpoint.EndpointGroups;
using MasLazu.AspNet.Framework.Application.Exceptions;

namespace MasLazu.AspNet.Authorization.Page.Endpoint.Endpoints.PageGroups;

public class GetPageGroupByIdEndpoint : BaseEndpoint<IdRequest, PageGroupDto>
{
    public IPageGroupService PageGroupService { get; set; }

    public override void ConfigureEndpoint()
    {
        Get("/{Id}");
        Group<PageGroupsEndpointGroup>();
    }

    public override async Task HandleAsync(IdRequest req, CancellationToken ct)
    {
        PageGroupDto result = await PageGroupService.GetByIdAsync(Guid.Empty, req.Id, ct) ??
            throw new NotFoundException(nameof(PageGroupDto), req.Id);
        await SendOkResponseAsync(result, "Page Group Retrieved Successfully", ct);
    }
}
