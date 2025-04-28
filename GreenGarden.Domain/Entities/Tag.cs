using GreenGarden.Domain.Common;

namespace GreenGarden.Domain.Entities;

public class Tag : Entity
{
    public string Name { get; set; }
    public ICollection<Plant> Plants { get; set; }
}
