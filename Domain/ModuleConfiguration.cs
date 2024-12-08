using Microsoft.Extensions.DependencyInjection;
using Domain.Services;
using Domain.Interfaces;

namespace Domain
{
    public static class ModuleConfiguration
    {
        public static void ConfigureServicesModule(this IServiceCollection services)
        {
            services.ConfigureRepositoryModule();
            services.AddScoped<IQRCoderCertificate, QRCoderCertificate>();
            services.AddScoped<IAuthorization, Authorization>();
        }
    }
}