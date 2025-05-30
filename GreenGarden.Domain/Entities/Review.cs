using GreenGarden.Domain.Common;
using System.Text.Json.Serialization;

namespace GreenGarden.Domain.Entities;

public class Review : Entity
{
    public string VoterName { get; set; }

    public int Stars { get; set; }

    public string Comment { get; set; }

    public int PlantId { get; set; }

    [JsonIgnore]
    public virtual Plant Plant { get; set; }
}
