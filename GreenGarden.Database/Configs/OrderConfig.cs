using GreenGarden.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreenGarden.Database.Configs;

internal class OrderConfig : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> entity)
    {
        entity.HasKey(e => e.Id);

        entity.HasOne(o => o.Customer)
            .WithMany(o => o.Orders)
            .HasForeignKey(o => o.CustomerId);
    }
}
