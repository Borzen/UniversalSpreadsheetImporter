using USSI.API.DataAccess.SQLite.IoC;
using USSI.API.Models.Config;

namespace USSI.API.IoC
{
    public static class APIServiceExtensions
    {
        public static IServiceCollection AddAPIServices(this IServiceCollection services, IConfiguration configuration)
        {
            APIDbSettings dbSettings = new APIDbSettings();
            configuration.GetSection("APIDb").Bind(dbSettings);
            var sqlType = GetSQLType(dbSettings.DatabaseType);
            switch(sqlType)
            {
                case SQLType.SQLite:
                    services.AddSQLiteDataAccess(dbSettings.ConnectionString);
                    break;
            }
            return services;
        }

        private static SQLType GetSQLType(string contigedSql)
        {
            switch (contigedSql.ToLower())
            {
                case "sqllite":
                default:
                    return SQLType.SQLite;
            }
        }
    }
}
