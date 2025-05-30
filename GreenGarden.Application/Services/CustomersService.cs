using GreenGarden.Database;
using GreenGarden.Domain.Abstractions;
using GreenGarden.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GreenGarden.Application.Services;

public class CustomersService(AppDbContext dbContext) : ICustomersService
{
    public async Task<List<Customer>> GetCustomersAsync(CancellationToken cancellationToken)
    {
        var customers = await dbContext.Customers.ToListAsync(cancellationToken);

        return customers;
    }
}