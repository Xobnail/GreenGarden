using System.Text.Json.Serialization;

namespace GreenGarden.Domain.Entities;

public class PlantHabitat
{
    public int PlantId { get; set; }
    public int HabitatId { get; set; }
    public byte Order {  get; set; }

    [JsonIgnore]
    public virtual Plant Plant { get; set; }

    [JsonIgnore]
    public virtual Habitat Habitat { get; set; }
}
