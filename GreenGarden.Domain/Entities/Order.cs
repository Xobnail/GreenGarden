using GreenGarden.Domain.Common;
using System.Text.Json.Serialization;

namespace GreenGarden.Domain.Entities;

public class Order : Entity
{
    public int CustomerId { get; set; }

    [JsonIgnore]
    public virtual Customer Customer { get; set; }

    public virtual ICollection<LineItem> LineItems { get; set; }
}
