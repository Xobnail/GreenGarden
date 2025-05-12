using GreenGarden.Database;
using GreenGarden.Domain.Abstractions;
using GreenGarden.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GreenGarden.Application.Services;

public class PlantsService(AppDbContext dbContext) : IPlantsService
{
    public async Task<List<Plant>> GetPlantsAsync(CancellationToken cancellationToken)
    {
        var plants = await dbContext.Plants.ToListAsync(cancellationToken);

        return plants;
    }
}
