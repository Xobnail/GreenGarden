using GreenGarden.Domain.Entities;

namespace GreenGarden.Domain.Abstractions;

public interface IPlantsService
{
    public Task<List<Plant>> GetPlantsAsync(CancellationToken cancellationToken);
    public Task<int> TestAsync(CancellationToken cancellationToken);
}
