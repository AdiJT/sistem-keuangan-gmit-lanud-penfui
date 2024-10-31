using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure;

public static class DependecyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("default") ?? throw new ArgumentException("Connection String 'default' not found");

        services.AddDbContext<AppDbContext>(options => 
        {
            options.UseNpgsql(connectionString).EnableDetailedErrors().EnableSensitiveDataLogging();
        });

        services.AddScoped<IUnitOfWork, AppDbContext>();

        return services;
    }
}
