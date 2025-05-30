using GreenGarden.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreenGarden.Database.Configs;

internal class PlantHabitatConfig : IEntityTypeConfiguration<PlantHabitat>
{
    public void Configure(EntityTypeBuilder<PlantHabitat> entity)
    {
        
    }
}
