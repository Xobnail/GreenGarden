using GreenGarden.Domain.Common;
using System.Text.Json.Serialization;

namespace GreenGarden.Domain.Entities;

public class Habitat : Entity
{
    public string Name { get; set; }

    [JsonIgnore]
    public virtual ICollection<Plant> Plants { get; set; }

    [JsonIgnore]
    public virtual ICollection<PlantHabitat> PlantLink { get; set; }
}
