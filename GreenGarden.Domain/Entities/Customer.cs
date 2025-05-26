using GreenGarden.Domain.Common;

namespace GreenGarden.Domain.Entities;

public class Customer : Entity
{
    public string Name { get; set; }

    public string Address { get; set; }

    public string Number { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
}
