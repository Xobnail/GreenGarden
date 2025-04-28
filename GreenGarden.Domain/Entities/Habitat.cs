using GreenGarden.Domain.Common;

namespace GreenGarden.Domain.Entities;

public class Habitat : Entity
{
    public string Name { get; set; }

    public ICollection<Plant> Plants { get; set; }
    public ICollection<PlantHabitat> PlantLink { get; set; }
}
