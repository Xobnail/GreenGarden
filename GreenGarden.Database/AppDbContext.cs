using GreenGarden.Domain.Entities;
using Microsoft.EntityFrameworkCore;

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

        modelBuilder.Entity<Plant>(entity =>
        {
            entity.HasKey(e => e.Id);

            // 1 - 1
            entity.HasOne(d => d.Promotion)
                .WithOne(p => p.Plant)
                .HasForeignKey<PriceOffer>(p => p.PlantId);

            // 1 - M
            entity.HasMany(d => d.Reviews)
                .WithOne(p => p.Plant)
                .HasForeignKey(d => d.PlantId);

            // M - M without explicit connection table
            entity.HasMany(d => d.Tags)
                .WithMany(t => t.Plants);

            // M - M with explicit connection table
            entity.HasMany(d => d.Habitats)
                .WithMany(h => h.Plants)
                .UsingEntity<PlantHabitat>();
        });

        modelBuilder.Entity<PriceOffer>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.HasOne(p => p.Plant)
                .WithOne(p => p.Promotion)
                .HasForeignKey<PriceOffer>(p => p.PlantId);
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.HasOne(r => r.Plant)
                .WithMany(p => p.Reviews)
                .HasForeignKey(r => r.PlantId);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.HasOne(o => o.Customer)
                .WithMany(o => o.Orders)
                .HasForeignKey(o => o.CustomerId);
        });

        modelBuilder.Entity<LineItem>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.HasOne(e => e.ChosenPlant);

            entity.HasOne(e => e.Order)
                .WithMany(e => e.LineItems)
                .HasForeignKey(e => e.OrderId);
        });

        modelBuilder.SeedData();
    }
}
