# MasLazu.AspNet.Authorization.Page.Domain

This project contains the domain entities for the ASP.NET Authorization Page system. It defines the core business objects and their relationships that represent the domain model.

## Overview

The domain layer establishes the fundamental entities that model the page authorization system, including their properties and relationships. These entities form the basis for data persistence and business logic.

## Entities

### Page

Represents a page in the authorization system.

**Properties:**

- `Id` (inherited from BaseEntity)
- `ParentId`: Optional GUID referencing the parent page for hierarchical structure
- `PageGroupId`: Optional GUID referencing the page group
- `Code`: Unique code identifier for the page
- `Name`: Display name of the page
- `Path`: URL path or route for the page
- `CreatedAt`, `UpdatedAt` (inherited from BaseEntity)

**Relationships:**

- `Parent`: Navigation to parent Page (self-referencing)
- `PageGroup`: Navigation to associated PageGroup
- `PagePermissions`: Collection of PagePermission entities

### PageGroup

Represents a group of pages for organizational purposes.

**Properties:**

- `Id` (inherited from BaseEntity)
- `Code`: Unique code identifier for the group
- `Name`: Display name of the group
- `Icon`: Optional icon representation
- `CreatedAt`, `UpdatedAt` (inherited from BaseEntity)

**Relationships:**

- `Pages`: Collection of Page entities belonging to this group

### PagePermission

Represents the association between a page and a permission.

**Properties:**

- `Id` (inherited from BaseEntity)
- `PageId`: GUID referencing the associated page
- `PermissionId`: GUID referencing the associated permission
- `CreatedAt`, `UpdatedAt` (inherited from BaseEntity)

**Relationships:**

- `Page`: Navigation to the associated Page entity

## Entity Relationships

```
PageGroup 1:N Pages
Page 1:N PagePermissions
Page N:1 Page (self-referencing for hierarchy)
```

## Dependencies

- **MasLazu.AspNet.Framework.Domain**: Provides the `BaseEntity` class with common properties like `Id`, `CreatedAt`, and `UpdatedAt`

## Target Framework

- .NET 9.0
- Nullable reference types enabled
- Implicit usings enabled

## Usage

These domain entities are used by:

- The EF Core project for database mapping and persistence
- The main application project for business logic implementation
- Other layers that need to work with the core domain objects

The entities define the structure and relationships that govern how pages, groups, and permissions interact within the authorization system.
