using FluentValidation;
using MasLazu.AspNet.Authorization.Page.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Page.Abstraction.Models;
using MasLazu.AspNet.Authorization.Page.Domain.Entities;
using MasLazu.AspNet.Framework.Application.Interfaces;
using MasLazu.AspNet.Framework.Application.Services;

namespace MasLazu.AspNet.Authorization.Page.Services;

public class PageGroupService : CrudService<PageGroup, PageGroupDto, CreatePageGroupRequest, UpdatePageGroupRequest>, IPageGroupService
{
    public PageGroupService(
        IRepository<PageGroup> repository,
        IReadRepository<PageGroup> readRepository,
        IUnitOfWork unitOfWork,
        IEntityPropertyMap<PageGroup> propertyMap,
        IPaginationValidator<PageGroup> paginationValidator,
        ICursorPaginationValidator<PageGroup> cursorPaginationValidator,
        IValidator<CreatePageGroupRequest>? createValidator = null,
        IValidator<UpdatePageGroupRequest>? updateValidator = null)
        : base(repository, readRepository, unitOfWork, propertyMap, paginationValidator, cursorPaginationValidator, createValidator, updateValidator)
    {
    }
}
