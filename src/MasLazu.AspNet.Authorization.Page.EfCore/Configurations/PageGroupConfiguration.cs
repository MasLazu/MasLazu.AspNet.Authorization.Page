using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MasLazu.AspNet.Authorization.Page.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Page.EfCore.Configurations;

public class PageGroupConfiguration : IEntityTypeConfiguration<PageGroup>
{
    public void Configure(EntityTypeBuilder<PageGroup> builder)
    {
        builder.HasKey(pg => pg.Id);

        builder.Property(pg => pg.Code)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(pg => pg.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(pg => pg.Icon)
            .HasMaxLength(100);

        builder.HasMany(pg => pg.Pages)
            .WithOne(p => p.PageGroup)
            .HasForeignKey(p => p.PageGroupId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasIndex(pg => pg.Code)
            .IsUnique();
    }
}
