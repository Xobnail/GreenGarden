using GreenGarden.Domain.Common;

namespace GreenGarden.Domain.Entities;

public class Order : Entity
{
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }

    public virtual ICollection<LineItem> LineItems { get; set; }
}
