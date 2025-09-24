using Microsoft.EntityFrameworkCore;
using MasLazu.AspNet.Framework.EfCore.Data;
using MasLazu.AspNet.Authorization.Page.Domain.Entities;
using MasLazu.AspNet.Authorization.Page.EfCore.Configurations;

namespace MasLazu.AspNet.Authorization.Page.EfCore.Data;

public class AuthorizationPageDbContext : BaseDbContext
{
    public AuthorizationPageDbContext(DbContextOptions<AuthorizationPageDbContext> options) : base(options)
    {
    }

    public DbSet<Domain.Entities.Page> Pages { get; set; }
    public DbSet<PageGroup> PageGroups { get; set; }
    public DbSet<PagePermission> PagePermissions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new PageConfiguration());
        modelBuilder.ApplyConfiguration(new PageGroupConfiguration());
        modelBuilder.ApplyConfiguration(new PagePermissionConfiguration());
    }
}
