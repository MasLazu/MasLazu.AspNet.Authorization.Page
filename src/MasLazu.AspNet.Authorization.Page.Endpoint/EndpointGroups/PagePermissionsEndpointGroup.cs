using FastEndpoints;
using Microsoft.AspNetCore.Http;
using MasLazu.AspNet.Framework.Endpoint.EndpointGroups;

namespace MasLazu.AspNet.Authorization.Page.Endpoint.EndpointGroups;

public class PagePermissionsEndpointGroup : SubGroup<V1EndpointGroup>
{
    public PagePermissionsEndpointGroup()
    {
        Configure("page-permissions", ep => ep.Description(x => x.WithTags("Page Permissions")));
    }
}
