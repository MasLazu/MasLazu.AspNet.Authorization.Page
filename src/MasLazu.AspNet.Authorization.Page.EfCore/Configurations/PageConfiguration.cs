using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MasLazu.AspNet.Authorization.Page.EfCore.Configurations;

public class PageConfiguration : IEntityTypeConfiguration<Domain.Entities.Page>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Page> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Code)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.Path)
            .IsRequired()
            .HasMaxLength(500);

        builder.HasOne(p => p.Parent)
            .WithMany()
            .HasForeignKey(p => p.ParentId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(p => p.PageGroup)
            .WithMany(pg => pg.Pages)
            .HasForeignKey(p => p.PageGroupId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(p => p.PagePermissions)
            .WithOne(pp => pp.Page)
            .HasForeignKey(pp => pp.PageId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(p => p.Code)
            .IsUnique();

        builder.HasIndex(p => p.Path);
    }
}
