# MasLazu.AspNet.Authorization.Page

This is the main application project for the ASP.NET Authorization Page system. It implements the business logic services, validation rules, and dependency injection configurations that bring together the abstraction and domain layers.

## Overview

The application layer provides concrete implementations of the interfaces defined in the abstraction layer, using the domain entities. It includes service implementations, input validation, property mapping for sorting/filtering, and extension methods for easy integration into ASP.NET applications.

## Key Components

### Services

Concrete implementations of the service interfaces:

- **PageService**: Implements `IPageService` for CRUD operations on pages
- **PageGroupService**: Implements `IPageGroupService` for CRUD operations on page groups
- **PagePermissionService**: Implements `IPagePermissionService` for CRUD operations on page permissions

All services inherit from `CrudService<TEntity, TDto, TCreateRequest, TUpdateRequest>` and provide full CRUD functionality with pagination, sorting, and filtering support.

### Validators

FluentValidation validators for request models:

- **CreatePageRequestValidator**: Validates page creation requests (Code: required, max 50; Name: required, max 100; Path: required, max 500)
- **UpdatePageRequestValidator**: Validates page update requests (same rules, only when fields are provided)
- **CreatePageGroupRequestValidator**: Validates page group creation (Code: required, max 50; Name: required, max 100; Icon: optional, max 100)
- **UpdatePageGroupRequestValidator**: Validates page group updates
- **CreatePagePermissionRequestValidator**: Validates page permission creation (PageId and PermissionId required)
- **UpdatePagePermissionRequestValidator**: Validates page permission updates

### Property Maps

Expression-based property mapping for dynamic sorting and filtering:

- **PageEntityPropertyMap**: Maps string property names to expressions for Page entities
- **PageGroupEntityPropertyMap**: Maps string property names to expressions for PageGroup entities
- **PagePermissionEntityPropertyMap**: Maps string property names to expressions for PagePermission entities

Supported properties include Id, timestamps, and entity-specific fields.

### Extensions

Dependency injection extension methods:

- **AuthorizationPageApplicationExtension**: Main extension that registers all services, validators, and utilities
- **AuthorizationPageApplicationServiceExtension**: Registers the service implementations
- **AuthorizationPageApplicationValidatorExtension**: Registers the validators
- **AuthorizationPageApplicationUtilExtension**: Registers property maps and expression builders

## Dependencies

- **MasLazu.AspNet.Framework.Application**: Provides base service classes, interfaces, and utilities
- **MasLazu.AspNet.Authorization.Page.Abstraction**: References the abstraction interfaces and models
- **MasLazu.AspNet.Authorization.Page.Domain**: References the domain entities

## Target Framework

- .NET 9.0
- Nullable reference types enabled
- Implicit usings enabled

## Usage

To integrate this library into an ASP.NET application, call the extension method in `Program.cs` or `Startup.cs`:

```csharp
builder.Services.AddAuthorizationPageApplication();
```

This will register all necessary services, validators, and utilities for the page authorization system.

The services can then be injected into controllers or other services to perform CRUD operations on pages, groups, and permissions with full validation and error handling.
