using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using AlfarBackEndChallenge.Application.Contracts.Infrastructure.Persistence;
using AlfarBackEndChallenge.Application.Contracts.Infrastructure.Services;
using AlfarBackEndChallenge.Application.Models.Configs;
using AlfarBackEndChallenge.Infrastructure.Persistence;
using AlfarBackEndChallenge.Infrastructure.Persistence.Repositories;
using AlfarBackEndChallenge.Infrastructure.Services;

namespace AlfarBackEndChallenge.Infrastructure
{
    public static class InfrastructureServiceConfiguration
    {
        private const string API_SETTINGS = "Settings";

        public static IServiceCollection AddInfrastructureServicesConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            Settings apiSettings = new Settings();
            new ConfigureFromConfigurationOptions<Settings>(configuration.GetSection(API_SETTINGS)).Configure(apiSettings);
            services.AddSingleton(apiSettings);

            // Database settings 
            string? provider = configuration.GetValue("Provider", "SqlServer");
            string migrationAssembly = $"AlfarBackEndChallenge.Infrastructure.{provider}";
            services.AddDbContext<ApplicationDbContext>(options => _ = provider switch
            {
                "SqlServer" => options.UseSqlServer(
                    configuration.GetConnectionString(apiSettings.ConnectionStrings),
                    b =>
                    {
                        b.MigrationsAssembly(migrationAssembly);
                    }),

                ///TODO: another database configurations

                _ => throw new Exception($"Unsupported provider: {provider}")
            });

            //services DI
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}

