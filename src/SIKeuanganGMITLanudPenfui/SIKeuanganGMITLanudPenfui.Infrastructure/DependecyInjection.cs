using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SIKeuanganGMITLanudPenfui.Application.Services;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Authentication;
using SIKeuanganGMITLanudPenfui.Infrastructure.Authentication.Contracts;
using SIKeuanganGMITLanudPenfui.Infrastructure.Configurations;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;
using SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;
using SIKeuanganGMITLanudPenfui.Infrastructure.Services.FileUpload;

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
        services.AddScoped<IRepositoriTransaksi, RepositoriTransaksi>();
        services.AddScoped<IRepositoriUser, RepositoriUser>();
        services.AddScoped<IRepositoriKas, RepositoriKas>();
        services.AddScoped<IRepositoriFeedBack, RepositoriFeedBack>();
        services.AddScoped<IRepositoriInformasiGereja, RepositoriInformasiGereja>();

        services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                options.SlidingExpiration = true;
                options.LoginPath = new PathString("/Dashboard/Login");
            });

        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
        services.AddScoped<ISignInManager, SignInManager>();

        services.AddScoped<IFileUploadService, FileUploadService>();
        services.AddScoped<IFileService, FileUploadService>();

        return services;
    }
}
