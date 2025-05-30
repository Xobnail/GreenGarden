using GreenGarden.Domain.Common;
using System.Text.Json.Serialization;

namespace GreenGarden.Domain.Entities;

public class LineItem : Entity
{
    public int LineNum { get; set; }

    public int ChosenPlantId { get; set; }
    public virtual Plant ChosenPlant { get; set; }

    public int OrderId { get; set; }

    [JsonIgnore]
    public virtual Order Order { get; set; }

    public int NumPlants { get; set; }
}
