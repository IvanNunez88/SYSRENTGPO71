using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SYSRENT.Application.Data;
using SYSRENT.Infrastructure.Context;

namespace SYSRENT.Infrastructure;

public static class InfrastructureServicesRegistration
{


    public static IServiceCollection AddServicesInfrasttructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ISqlDbConnection, SqlDapperConnection>();

        return services;
    }
}
