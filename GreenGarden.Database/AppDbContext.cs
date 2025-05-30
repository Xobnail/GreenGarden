using GreenGarden.Database.Configs;
using GreenGarden.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GreenGarden.Database;

public class AppDbContext : DbContext
{
    public DbSet<Plant> Plants { get; set; }
    public DbSet<Habitat> Habitats { get; set; }
    public DbSet<PlantHabitat> PlantHabitats { get; set; }
    public DbSet<PriceOffer> Promotions { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<LineItem> LineItems { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Plant>().ToTable("Plants");
        modelBuilder.Entity<PriceOffer>().ToTable("PriceOffers");
        modelBuilder.Entity<Review>().ToTable("Reviews");
        modelBuilder.Entity<Tag>().ToTable("Tags");
        modelBuilder.Entity<Habitat>().ToTable("Habitats");
        modelBuilder.Entity<PlantHabitat>().ToTable("PlantsHabitats");

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.SeedData();
    }
}
