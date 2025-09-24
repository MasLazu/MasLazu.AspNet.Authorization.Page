using FastEndpoints;
using Microsoft.AspNetCore.Http;
using MasLazu.AspNet.Framework.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Page.Endpoint.EndpointGroups;

public class PageGroupsEndpointGroup : SubGroup<V1EndpointGroup>
{
    public PageGroupsEndpointGroup()
    {
        Configure("page-groups", ep => ep.Description(x => x.WithTags("Page Groups")));
    }
}
