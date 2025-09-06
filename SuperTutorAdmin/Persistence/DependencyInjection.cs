using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddDbContext(this IServiceCollection services, string connectionString)
    {
        return services.AddDbContext<AdminDbContext>(o =>
            o.UseNpgsql(connectionString, 
                optionsAction => optionsAction.MigrationsHistoryTable("Migrations", "migration")));
    }
}