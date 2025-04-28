namespace GreenGarden.Domain.Entities;

public class PlantHabitat
{
    public int PlantId { get; set; }
    public int HabitatId { get; set; }
    public byte Order {  get; set; }
    public Plant Plant { get; set; }
    public Habitat Habitat { get; set; }
}
