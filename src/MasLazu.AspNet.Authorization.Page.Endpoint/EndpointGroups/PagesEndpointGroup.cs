using FastEndpoints;
using Microsoft.AspNetCore.Http;
using MasLazu.AspNet.Framework.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Page.Endpoint.EndpointGroups;

public class PagesEndpointGroup : SubGroup<V1EndpointGroup>
{
    public PagesEndpointGroup()
    {
        Configure("pages", ep => ep.Description(x => x.WithTags("Pages")));
    }
}
