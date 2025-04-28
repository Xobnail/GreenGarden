using GreenGarden.Domain.Common;

namespace GreenGarden.Domain.Entities;

public class PriceOffer : Entity
{
    public decimal NewPrice { get; set; }

    public string Text { get; set; }

    public int PlantId { get; set; }

    public Plant Plant { get; set; }
}
