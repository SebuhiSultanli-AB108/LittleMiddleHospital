using LittleMiddleHospital.Core.RepositoryInterfaces;
using LittleMiddleHospital.DAL.RepositoryImplements;
using Microsoft.Extensions.DependencyInjection;

namespace LittleMiddleHospital.DAL;

public static class ServiceRegistration
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPatienceRepository, PatienceRepository>();
        services.AddScoped<IInsuranceRepository, InsuranceRepository>();
        return services;
    }
}