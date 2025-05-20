using GreenGarden.Domain.Common;

namespace GreenGarden.Domain.Entities;

public class Habitat : Entity
{
    public string Name { get; set; }

    public virtual ICollection<Plant> Plants { get; set; }
    public virtual ICollection<PlantHabitat> PlantLink { get; set; }
}
