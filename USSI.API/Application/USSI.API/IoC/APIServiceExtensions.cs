

using USSI.API.Client.IoC;
using USSI.API.Models.Config;

namespace USSI.API.IoC
{
    public static class APIServiceExtensions
    {
        public static IServiceCollection AddAPIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<APIDbSettings>(configuration.GetSection(APIDbSettings.ConfigSection));
            services.AddAPIClientServices(configuration);
            return services;
        }

    }
}
