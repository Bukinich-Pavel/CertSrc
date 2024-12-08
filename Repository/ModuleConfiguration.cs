using Microsoft.Extensions.DependencyInjection;
using Repository.Operations;
using Repository.Interfaces;

namespace Domain
{
    public static class ModuleConfiguration
    {
        public static void ConfigureRepositoryModule(this IServiceCollection services)
        {
            services.AddScoped<IUsers, Users>();
        }
    }
}