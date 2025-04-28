using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GreenGarden.Database;

public static class Entry
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

        return services;
    }
}
