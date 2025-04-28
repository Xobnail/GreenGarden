using GreenGarden.Domain.Common;

namespace GreenGarden.Domain.Entities;

public class Review : Entity
{
    public string VoterName { get; set; }

    public int Stars { get; set; }

    public string Comment { get; set; }

    public int PlantId { get; set; }

    public Plant Plant { get; set; }
}
