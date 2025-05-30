using GreenGarden.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreenGarden.Database.Configs;

internal class PlantConfig : IEntityTypeConfiguration<Plant>
{
    public void Configure(EntityTypeBuilder<Plant> entity)
    {
        entity.HasKey(e => e.Id);

        // 1 - 1
        entity.HasOne(d => d.Promotion)
            .WithOne(p => p.Plant)
            .HasForeignKey<PriceOffer>(p => p.PlantId);

        // 1 - M
        entity.HasMany(d => d.Reviews)
            .WithOne(p => p.Plant)
            .HasForeignKey(d => d.PlantId);

        // M - M without explicit connection table
        entity.HasMany(d => d.Tags)
            .WithMany(t => t.Plants);

        // M - M with explicit connection table
        entity.HasMany(d => d.Habitats)
            .WithMany(h => h.Plants)
            .UsingEntity<PlantHabitat>();
    }
}
