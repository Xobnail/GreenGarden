using GreenGarden.Domain.Common;
using System.Text.Json.Serialization;

namespace GreenGarden.Domain.Entities;

public class PriceOffer : Entity
{
    public decimal NewPrice { get; set; }

    public string Text { get; set; }

    public int PlantId { get; set; }

    [JsonIgnore]
    public virtual Plant Plant { get; set; }
}
