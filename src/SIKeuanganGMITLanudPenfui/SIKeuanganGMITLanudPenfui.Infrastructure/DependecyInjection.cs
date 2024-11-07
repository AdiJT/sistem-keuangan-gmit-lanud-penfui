using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;
using SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

namespace SIKeuanganGMITLanudPenfui.Infrastructure;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new ArgumentException("Connection String 'DefaultConnection' not found");

        services.AddDbContext<AppDbContext>(options => 
        {
            options.UseNpgsql(connectionString).EnableDetailedErrors().EnableSensitiveDataLogging();
        });

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IRepositoriAkun, RepositoriAkun>();
        services.AddScoped<IRepositoriJenisAkun, RepositoriJenisAkun>();
        services.AddScoped<IRepositoriKelompokAkun, RepositoriKelompokAkun>();
        services.AddScoped<IRepositoriGolonganAkun, RepositoriGolonganAkun>();
        services.AddScoped<IRepositoriRAPBJ, RepositoriRAPBJ>();
        services.AddScoped<IRepositoriDetailRAPBJ, RepositoriDetailRAPBJ>();
        services.AddScoped<IRepositoriBelanja, RepositoriBelanja>();
        services.AddScoped<IRepositoriPenerimaan, RepositoriPenerimaan>();
        services.AddScoped<IRepositoriUser, RepositoriUser>();

        return services;
    }
}
