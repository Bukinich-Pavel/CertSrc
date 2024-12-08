using Microsoft.Extensions.DependencyInjection;
using Domain.Services;
using Domain.Interfaces;

namespace Domain
{
    public static class ModuleConfiguration
    {
        public static void ConfigureServicesModule(this IServiceCollection services)
        {
            services.AddScoped<IQRCoderCertificate, QRCoderCertificate>();
        }
    }
}