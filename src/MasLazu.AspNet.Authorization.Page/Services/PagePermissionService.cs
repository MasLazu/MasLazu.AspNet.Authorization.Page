using FluentValidation;
using MasLazu.AspNet.Authorization.Page.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Page.Abstraction.Models;
using MasLazu.AspNet.Authorization.Page.Domain.Entities;
using MasLazu.AspNet.Framework.Application.Interfaces;
using MasLazu.AspNet.Framework.Application.Services;

namespace MasLazu.AspNet.Authorization.Page.Services;

public class PagePermissionService : CrudService<PagePermission, PagePermissionDto, CreatePagePermissionRequest, UpdatePagePermissionRequest>, IPagePermissionService
{
    public PagePermissionService(
        IRepository<PagePermission> repository,
        IReadRepository<PagePermission> readRepository,
        IUnitOfWork unitOfWork,
        IEntityPropertyMap<PagePermission> propertyMap,
        IPaginationValidator<PagePermission> paginationValidator,
        ICursorPaginationValidator<PagePermission> cursorPaginationValidator,
        IValidator<CreatePagePermissionRequest>? createValidator = null,
        IValidator<UpdatePagePermissionRequest>? updateValidator = null)
        : base(repository, readRepository, unitOfWork, propertyMap, paginationValidator, cursorPaginationValidator, createValidator, updateValidator)
    {
    }
}
