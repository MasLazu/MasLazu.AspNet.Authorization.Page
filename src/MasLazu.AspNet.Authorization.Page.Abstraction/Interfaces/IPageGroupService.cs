using MasLazu.AspNet.Framework.Application.Interfaces;
using MasLazu.AspNet.Authorization.Page.Abstraction.Models;

namespace MasLazu.AspNet.Authorization.Page.Abstraction.Interfaces;

public interface IPageGroupService : ICrudService<PageGroupDto, CreatePageGroupRequest, UpdatePageGroupRequest>
{
}
