using GreenGarden.Domain.Entities;

namespace GreenGarden.Domain.Abstractions;

public interface ICustomersService
{
    public Task<List<Customer>> GetCustomersAsync(CancellationToken cancellationToken);
}
