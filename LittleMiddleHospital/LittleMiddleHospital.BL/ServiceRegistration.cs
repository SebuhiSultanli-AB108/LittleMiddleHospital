using Microsoft.Extensions.DependencyInjection;

namespace LittleMiddleHospital.BL;

public static class ServiceRegistration
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        //services.AddScoped<ITopicService, TopicService>();
        return services;
    }
    //public static IServiceCollection AddAutoMapper(this IServiceCollection services)
    //{
    //    services.AddAutoMapper(typeof(ServiceRegistration));
    //    return services;
    //}
    //public static IServiceCollection AddFluentValidation(this IServiceCollection services)
    //{
    //    services.AddFluentValidationAutoValidation();
    //    services.AddValidatorsFromAssemblyContaining(typeof(ServiceRegistration));
    //    return services;
    //}
}