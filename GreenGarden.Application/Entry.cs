using GreenGarden.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using GreenGarden.Domain.Abstractions;

namespace GreenGarden.Application;

public static class Entry
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IPlantsService, PlantsService>();
        services.AddScoped<ICustomersService, CustomersService>();

        return services;
    }
}
