# MasLazu.AspNet.Authorization.Page.Abstraction

This project defines the abstraction layer for the ASP.NET Authorization Page system. It provides contracts (interfaces and data models) that other layers in the application can implement and use.

## Overview

The abstraction layer serves as the foundation for the page authorization functionality, defining:

- Service interfaces for CRUD operations on pages, page groups, and page permissions
- Data transfer objects (DTOs) for representing entities
- Request models for create and update operations

## Key Components

### Interfaces

- **IPageService**: Defines CRUD operations for pages
- **IPageGroupService**: Defines CRUD operations for page groups
- **IPagePermissionService**: Defines CRUD operations for page permissions

All interfaces inherit from `ICrudService<TDto, TCreateRequest, TUpdateRequest>` from the MasLazu.AspNet.Framework.Application package.

### Models

#### DTOs

- **PageDto**: Represents a page with properties like Id, ParentId, PageGroupId, Code, Name, Path, and timestamps
- **PageGroupDto**: Represents a page group with Id, Code, Name, Icon, and timestamps
- **PagePermissionDto**: Represents a page permission linking a page to a permission with Id, PageId, PermissionId, and timestamps

#### Request Models

- **CreatePageRequest**: For creating new pages (ParentId, PageGroupId, Code, Name, Path)
- **CreatePageGroupRequest**: For creating new page groups (Code, Name, Icon)
- **CreatePagePermissionRequest**: For creating new page permissions (PageId, PermissionId)
- **UpdatePageRequest**: For updating pages (Id, optional ParentId, PageGroupId, Code, Name, Path)
- **UpdatePageGroupRequest**: For updating page groups (Id, optional Code, Name, Icon)
- **UpdatePagePermissionRequest**: For updating page permissions (Id, optional PageId, PermissionId)

## Dependencies

- **MasLazu.AspNet.Framework.Application**: Provides base interfaces and models like `ICrudService`, `BaseDto`, and `BaseUpdateRequest`

## Target Framework

- .NET 9.0
- Nullable reference types enabled
- Implicit usings enabled

## Usage

This project is referenced by other projects in the solution to implement the actual business logic and data access. It ensures consistent contracts across different layers of the application.
