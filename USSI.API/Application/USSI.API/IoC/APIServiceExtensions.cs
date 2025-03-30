

using USSI.API.Client.IoC;

namespace USSI.API.IoC
{
    public static class APIServiceExtensions
    {
        public static IServiceCollection AddAPIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAPIClientServices(configuration);
            return services;
        }

    }
}
