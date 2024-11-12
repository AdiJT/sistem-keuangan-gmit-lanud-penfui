using Microsoft.Extensions.DependencyInjection;

namespace SIKeuanganGMITLanudPenfui.Application;

public static class DepedencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(conf =>
        {
            conf.RegisterServicesFromAssembly(AssemblyReference.Assembly);
        });

        return services;
    }
}
