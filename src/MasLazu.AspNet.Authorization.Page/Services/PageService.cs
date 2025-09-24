using FluentValidation;
using MasLazu.AspNet.Authorization.Page.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Page.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Interfaces;
using MasLazu.AspNet.Framework.Application.Services;

namespace MasLazu.AspNet.Authorization.Page.Services;

public class PageService : CrudService<Domain.Entities.Page, PageDto, CreatePageRequest, UpdatePageRequest>, IPageService
{
    public PageService(
        IRepository<Domain.Entities.Page> repository,
        IReadRepository<Domain.Entities.Page> readRepository,
        IUnitOfWork unitOfWork,
        IEntityPropertyMap<Domain.Entities.Page> propertyMap,
        IPaginationValidator<Domain.Entities.Page> paginationValidator,
        ICursorPaginationValidator<Domain.Entities.Page> cursorPaginationValidator,
        IValidator<CreatePageRequest>? createValidator = null,
        IValidator<UpdatePageRequest>? updateValidator = null)
        : base(repository, readRepository, unitOfWork, propertyMap, paginationValidator, cursorPaginationValidator, createValidator, updateValidator)
    {
    }
}
