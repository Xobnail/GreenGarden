namespace GreenGarden.Domain.Entities;

public class PlantHabitat
{
    public int PlantId { get; set; }
    public int HabitatId { get; set; }
    public byte Order {  get; set; }
    public virtual Plant Plant { get; set; }
    public virtual Habitat Habitat { get; set; }
}
