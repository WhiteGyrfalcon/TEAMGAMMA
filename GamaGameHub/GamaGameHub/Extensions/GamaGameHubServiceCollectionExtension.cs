using GamaGameHub.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class GamaGameHubServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            //services.AddScoped<IClientService, ClientService>();

            return services;
        }
    }
}
