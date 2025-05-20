using GreenGarden.Domain.Common;

namespace GreenGarden.Domain.Entities;

public class Plant : Entity
{
    public string Name { get; set; }

    public virtual PriceOffer Promotion { get; set; } // 1 - 1

    public virtual ICollection<Review> Reviews { get; set; } // 1 - М

    public virtual ICollection<Tag> Tags { get; set; } // М - М

    public virtual ICollection<Habitat> Habitats { get; set; }

    public virtual ICollection<PlantHabitat> HabitatsLink { get; set; } // М - М
}
