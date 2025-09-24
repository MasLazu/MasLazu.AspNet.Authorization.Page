using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MasLazu.AspNet.Authorization.Page.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Page.EfCore.Configurations;

public class PagePermissionConfiguration : IEntityTypeConfiguration<PagePermission>
{
    public void Configure(EntityTypeBuilder<PagePermission> builder)
    {
        builder.HasKey(pp => pp.Id);

        builder.Property(pp => pp.PageId)
            .IsRequired();

        builder.Property(pp => pp.PermissionId)
            .IsRequired();

        builder.HasOne(pp => pp.Page)
            .WithMany(p => p.PagePermissions)
            .HasForeignKey(pp => pp.PageId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(pp => new { pp.PageId, pp.PermissionId })
            .IsUnique();
    }
}
