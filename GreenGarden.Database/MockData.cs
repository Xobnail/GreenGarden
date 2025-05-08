using GreenGarden.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GreenGarden.Database;

public static class MockData
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        var tags = new List<Tag>
        {
            new() { Id = 1, Name = "Blooming" },
            new() { Id = 2, Name = "Indoor" },
            new() { Id = 3, Name = "Garden" },
            new() { Id = 4, Name = "Medicinal" },
            new() { Id = 5, Name = "Exotic" }
        };

        var habitats = new List<Habitat>
        {
            new() { Id = 1, Name = "Tropical Forest" },
            new() { Id = 2, Name = "Desert" },
            new() { Id = 3, Name = "Temperate Climate" },
            new() { Id = 4, Name = "Subtropics" },
            new() { Id = 5, Name = "Mountains" }
        };

        var plants = new List<Plant>
        {
            new() { Id = 1, Name = "Orchid" },
            new() { Id = 2, Name = "Cactus" },
            new() { Id = 3, Name = "Rose" },
            new() { Id = 4, Name = "Aloe Vera" },
            new() { Id = 5, Name = "Bamboo" }
        };

        var priceOffers = new List<PriceOffer>
        {
            new() { Id = 1, NewPrice = 29.99m, Text = "Special offer on orchids!", PlantId = 1 },
            new() { Id = 2, NewPrice = 19.99m, Text = "Discount on cacti this week", PlantId = 2 },
            new() { Id = 3, NewPrice = 15.99m, Text = "Roses at a special price", PlantId = 3 }
        };

        var reviews = new List<Review>
        {
            new() { Id = 1, VoterName = "Ann", Stars = 5, Comment = "Beautiful plant!", PlantId = 1 },
            new() { Id = 2, VoterName = "Ian", Stars = 4, Comment = "I like it very much!", PlantId = 1 },
            new() { Id = 3, VoterName = "Mary", Stars = 3, Comment = "Not bad, but I expected more", PlantId = 2 },
            new() { Id = 4, VoterName = "Alex", Stars = 5, Comment = "Perfect for my garden", PlantId = 3 },
            new() { Id = 5, VoterName = "Helen", Stars = 2, Comment = "Withered quickly", PlantId = 4 }
        };

        plants[0].Tags = new List<Tag> { tags[0], tags[1], tags[4] };
        plants[1].Tags = new List<Tag> { tags[1], tags[4] };
        plants[2].Tags = new List<Tag> { tags[0], tags[2] };
        plants[3].Tags = new List<Tag> { tags[1], tags[3] };
        plants[4].Tags = new List<Tag> { tags[2], tags[4] };

        var plantHabitats = new List<PlantHabitat>
        {
            new() { PlantId = 1, HabitatId = 1, Order = 1 },
            new() { PlantId = 1, HabitatId = 4, Order = 2 },
            new() { PlantId = 2, HabitatId = 2, Order = 1 },
            new() { PlantId = 3, HabitatId = 3, Order = 1 },
            new() { PlantId = 4, HabitatId = 1, Order = 1 },
            new() { PlantId = 4, HabitatId = 2, Order = 2 },
            new() { PlantId = 5, HabitatId = 1, Order = 1 },
            new() { PlantId = 5, HabitatId = 5, Order = 2 }
        };

        modelBuilder.Entity<Tag>().HasData(tags);
        modelBuilder.Entity<Habitat>().HasData(habitats);
        modelBuilder.Entity<Plant>().HasData(plants);
        modelBuilder.Entity<PriceOffer>().HasData(priceOffers);
        modelBuilder.Entity<Review>().HasData(reviews);
        modelBuilder.Entity<PlantHabitat>().HasData(plantHabitats);
    }
}
