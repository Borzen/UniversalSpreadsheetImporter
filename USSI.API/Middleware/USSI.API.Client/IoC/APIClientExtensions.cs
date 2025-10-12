using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using USSI.API.Client.Controlers.Admin;
using USSI.API.Client.Interfaces.Controllers.Admin;
using USSI.API.DataAccess.SQLite.IoC;
using USSI.API.Models.Config;

namespace USSI.API.Client.IoC
{
    public static class APIClientExtensions
    {
        public static IServiceCollection AddAPIClientServices(this IServiceCollection services, IConfiguration configuration)
        {
            APIDbSettings dbSettings = new APIDbSettings();
            configuration.GetSection("APIDb").Bind(dbSettings);
            var sqlType = GetSQLType(dbSettings.DatabaseType);
            switch (sqlType)
            {
                case SQLType.SQLite:
                    services.AddSQLiteSettingsDataAccess(dbSettings.ConnectionString);
                    break;
            }

            services.AddSingleton<IDbInit, DbInit>();
            return services;
        }

        private static SQLType GetSQLType(string contigedSql)
        {
            switch (contigedSql.ToLower())
            {
                case "sqlite":
                default:
                    return SQLType.SQLite;
            }
        }
    }
}
