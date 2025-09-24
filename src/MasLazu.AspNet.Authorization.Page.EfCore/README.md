# MasLazu.AspNet.Authorization.Page.EfCore

This project provides Entity Framework Core integration for the ASP.NET Authorization Page system. It includes database context configuration, entity type configurations, and dependency injection setup for data persistence.

## Overview

The EF Core layer handles the mapping between domain entities and database tables, including relationships, constraints, and indexes. It provides the database context that applications use to interact with the underlying data store.

## Key Components

### Database Context

- **AuthorizationPageDbContext**: The main EF Core database context that inherits from `BaseDbContext`
  - Contains `DbSet` properties for Pages, PageGroups, and PagePermissions
  - Applies entity configurations in `OnModelCreating`

### Entity Configurations

Fluent API configurations for each entity:

#### PageConfiguration

Configures the Page entity:

- Primary key: Id
- Properties: Code (required, max 50, unique), Name (required, max 100), Path (required, max 500, indexed)
- Relationships:
  - Self-referencing Parent relationship (optional, set null on delete)
  - PageGroup relationship (optional, set null on delete)
  - PagePermissions collection (cascade delete)
- Indexes: Unique on Code, standard on Path

#### PageGroupConfiguration

Configures the PageGroup entity:

- Primary key: Id
- Properties: Code (required, max 50, unique), Name (required, max 100), Icon (optional, max 100)
- Relationships: Pages collection (set null on delete)
- Indexes: Unique on Code

#### PagePermissionConfiguration

Configures the PagePermission entity:

- Primary key: Id
- Properties: PageId (required), PermissionId (required)
- Relationships: Page relationship (cascade delete)
- Indexes: Unique composite on (PageId, PermissionId)

### Extensions

- **ServiceCollectionExtensions**: Provides `AddAuthorizationPageEntityFrameworkCore()` extension method for registering EF Core services (currently a placeholder for future enhancements)

## Database Schema

The configurations define the following database schema:

```
PageGroups
├── Id (PK)
├── Code (unique, required)
├── Name (required)
├── Icon (optional)
├── CreatedAt
└── UpdatedAt

Pages
├── Id (PK)
├── ParentId (FK to Pages.Id, nullable)
├── PageGroupId (FK to PageGroups.Id, nullable)
├── Code (unique, required)
├── Name (required)
├── Path (indexed, required)
├── CreatedAt
└── UpdatedAt

PagePermissions
├── Id (PK)
├── PageId (FK to Pages.Id, required)
├── PermissionId (required)
├── CreatedAt
└── UpdatedAt
├── Unique: (PageId, PermissionId)
```

## Dependencies

- **MasLazu.AspNet.Framework.EfCore**: Provides `BaseDbContext` and other EF Core utilities
- **MasLazu.AspNet.Authorization.Page.Domain**: References the domain entities being configured

## Target Framework

- .NET 9.0
- Nullable reference types enabled
- Implicit usings enabled

## Usage

To use this EF Core integration in an application:

1. Configure the database context in your application's service registration:

```csharp
builder.Services.AddDbContext<AuthorizationPageDbContext>(options =>
    options.UseSqlServer(connectionString)); // or other provider
```

2. Apply migrations or ensure database schema matches the configurations.

3. Inject `AuthorizationPageDbContext` or use it through repository patterns for data access.

The context can be used directly or through the repository interfaces provided by the framework for data operations.
