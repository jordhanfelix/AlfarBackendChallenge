
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AlfarBackEndChallenge.Application
{
    public static class ApplicationServiceConfiguration
    {
        public static IServiceCollection AddApplicationServicesConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
