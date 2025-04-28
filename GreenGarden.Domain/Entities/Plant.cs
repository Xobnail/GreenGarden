using GreenGarden.Domain.Common;

namespace GreenGarden.Domain.Entities;

public class Plant : Entity
{
    public string Name { get; set; }

    public PriceOffer Promotion { get; set; } // 1 - 1

    public ICollection<Review> Reviews { get; set; } // 1 - М

    public ICollection<Tag> Tags { get; set; } // М - М

    public ICollection<Habitat> Habitats { get; set; }
    public ICollection<PlantHabitat> HabitatsLink { get; set; } // М - М
}
