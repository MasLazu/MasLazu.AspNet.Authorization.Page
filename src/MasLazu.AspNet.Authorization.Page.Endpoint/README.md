# MasLazu.AspNet.Authorization.Page.Endpoint

This project provides REST API endpoints for the ASP.NET Authorization Page system using FastEndpoints. It defines HTTP endpoints for CRUD operations on pages, page groups, and page permissions with proper routing and grouping.

## Overview

The endpoint layer exposes the page authorization functionality through REST APIs. It uses FastEndpoints for high-performance API development with automatic OpenAPI/Swagger documentation generation.

## API Structure

The endpoints are organized under versioned groups with the following structure:

```
api/v1/
├── pages/
│   ├── GET /{id} - Get page by ID
│   └── POST /paginated - Get paginated pages
├── page-groups/
│   ├── GET /{id} - Get page group by ID
│   └── POST /paginated - Get paginated page groups
└── page-permissions/
    ├── GET /{id} - Get page permission by ID
    └── POST /paginated - Get paginated page permissions
```

## Endpoint Groups

### PagesEndpointGroup

- Route prefix: `pages`
- Swagger tag: "Pages"
- Inherits from `V1EndpointGroup` for API versioning

### PageGroupsEndpointGroup

- Route prefix: `page-groups`
- Swagger tag: "Page Groups"
- Inherits from `V1EndpointGroup`

### PagePermissionsEndpointGroup

- Route prefix: `page-permissions`
- Swagger tag: "Page Permissions"
- Inherits from `V1EndpointGroup`

## Endpoints

### Page Endpoints

#### GetPageByIdEndpoint

- **Method**: GET
- **Route**: `/{id}`
- **Request**: `IdRequest` (GUID)
- **Response**: `PageDto`
- **Behavior**: Retrieves a single page by ID, throws `NotFoundException` if not found

#### GetPagesPaginatedEndpoint

- **Method**: POST
- **Route**: `/paginated`
- **Request**: `PaginationRequest`
- **Response**: `PaginatedResult<PageDto>`
- **Behavior**: Retrieves paginated list of pages with sorting/filtering support
- **Authorization**: Allow anonymous

### Page Group Endpoints

#### GetPageGroupByIdEndpoint

- **Method**: GET
- **Route**: `/{id}`
- **Request**: `IdRequest` (GUID)
- **Response**: `PageGroupDto`
- **Behavior**: Retrieves a single page group by ID

#### GetPageGroupsPaginatedEndpoint

- **Method**: POST
- **Route**: `/paginated`
- **Request**: `PaginationRequest`
- **Response**: `PaginatedResult<PageGroupDto>`
- **Behavior**: Retrieves paginated list of page groups

### Page Permission Endpoints

#### GetPagePermissionByIdEndpoint

- **Method**: GET
- **Route**: `/{id}`
- **Request**: `IdRequest` (GUID)
- **Response**: `PagePermissionDto`
- **Behavior**: Retrieves a single page permission by ID

#### GetPagePermissionsPaginatedEndpoint

- **Method**: POST
- **Route**: `/paginated`
- **Request**: `PaginationRequest`
- **Response**: `PaginatedResult<PagePermissionDto>`
- **Behavior**: Retrieves paginated list of page permissions

## Dependencies

- **MasLazu.AspNet.Framework.Endpoint**: Provides base endpoint classes and FastEndpoints utilities
- **MasLazu.AspNet.Authorization.Page.Abstraction**: References the service interfaces and DTOs

## Target Framework

- .NET 9.0
- Nullable reference types enabled
- Implicit usings enabled

## Extensions

- **ServiceCollectionExtensions**: Provides `AddAuthorizationPageEndpoints()` extension method for registering endpoints (currently a placeholder)

## Usage

To integrate these endpoints into an ASP.NET application:

1. Ensure FastEndpoints is configured in your application
2. Call the endpoint registration if needed (currently empty)
3. The endpoints will be automatically discovered by FastEndpoints

The endpoints use dependency injection to access the service layer (`IPageService`, `IPageGroupService`, `IPagePermissionService`) for business logic execution.

## Response Format

All endpoints return standardized responses using the framework's base endpoint patterns:

- Success responses include the data and a success message
- Error responses follow the framework's error handling conventions
- Pagination endpoints support sorting, filtering, and cursor-based pagination
