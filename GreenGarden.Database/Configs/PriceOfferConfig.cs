using GreenGarden.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreenGarden.Database.Configs;

internal class PriceOfferConfig : IEntityTypeConfiguration<PriceOffer>
{
    public void Configure(EntityTypeBuilder<PriceOffer> entity)
    {
        entity.HasKey(e => e.Id);

        entity.HasOne(p => p.Plant)
            .WithOne(p => p.Promotion)
            .HasForeignKey<PriceOffer>(p => p.PlantId);
    }
}
