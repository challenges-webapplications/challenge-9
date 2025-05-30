using challenge9.ShopContext.Domain.Models.Entities;

using Microsoft.EntityFrameworkCore;

namespace challenge9.Shared.Infraestructure.Persistence.Configuration;

public class Challenge9Context(DbContextOptions options) : DbContext(options)
{
    public DbSet<Discount> Discount { get; set; }
    public DbSet<Membership> Membership { get; set; }
    public DbSet<Product> Product { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        base.OnConfiguring(builder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Discount>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.DiscountPercentage).IsRequired();
            entity.Property(c => c.membershipStatus).IsRequired();
            entity.Property(c => c.productPrice).IsRequired();
            entity.Property(c => c.productType).IsRequired();
        });
        builder.Entity<Membership>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.membershipStatus).IsRequired();
            entity.Property(c => c.membershipType).IsRequired();
        });

        builder.Entity<Product>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Name).IsRequired();
            entity.Property(c => c.productType).IsRequired();
            entity.Property(c => c.productPrice).IsRequired();
        });
    }
}