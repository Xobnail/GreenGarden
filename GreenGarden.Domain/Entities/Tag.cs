using GreenGarden.Domain.Common;
using System.Text.Json.Serialization;

namespace GreenGarden.Domain.Entities;

public class Tag : Entity
{
    public string Name { get; set; }

    [JsonIgnore]
    public virtual ICollection<Plant> Plants { get; set; }
}
