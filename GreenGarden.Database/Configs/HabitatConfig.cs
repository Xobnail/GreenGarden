using GreenGarden.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreenGarden.Database.Configs;

internal class HabitatConfig : IEntityTypeConfiguration<Habitat>
{
    public void Configure(EntityTypeBuilder<Habitat> entity)
    {
        
    }
}
