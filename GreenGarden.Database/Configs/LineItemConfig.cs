using GreenGarden.Domain.Common;
using GreenGarden.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreenGarden.Database.Configs;

internal class LineItemConfig : IEntityTypeConfiguration<LineItem>
{
    public void Configure(EntityTypeBuilder<LineItem> entity)
    {
        entity.HasKey(e => e.Id);

        entity.HasOne(e => e.ChosenPlant);

        entity.HasOne(e => e.Order)
            .WithMany(e => e.LineItems)
            .HasForeignKey(e => e.OrderId);
    }
}
