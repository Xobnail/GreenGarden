using GreenGarden.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreenGarden.Database.Configs;

internal class ReviewConfig : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> entity)
    {
        entity.HasKey(e => e.Id);

        entity.HasOne(r => r.Plant)
            .WithMany(p => p.Reviews)
            .HasForeignKey(r => r.PlantId);
    }
}
