using GamaGameHub.Core.Contracts;
using GamaGameHub.Core.Services;
using GamaGameHub.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class GamaGameHubServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IGameCreatorService, GameCreatorService>();
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<IHomeService, HomeService>();

            return services;
        }
    }
}
