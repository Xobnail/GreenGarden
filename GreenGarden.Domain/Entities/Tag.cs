using GreenGarden.Domain.Common;

namespace GreenGarden.Domain.Entities;

public class Tag : Entity
{
    public string Name { get; set; }
    public virtual ICollection<Plant> Plants { get; set; }
}
