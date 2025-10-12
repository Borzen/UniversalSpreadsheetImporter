using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.Sqlite;

namespace USSI.API.DataAccess.SQLite.IoC
{
    public static class SQLiteDataAccessExtensions
    {
        public static IServiceCollection AddSQLiteSettingsDataAccess(this IServiceCollection services, string settingsConnectionstring)
        {
            services.AddKeyedTransient<IDbConnection>("settings", (sp,key) => new SqliteConnection(string.IsNullOrEmpty(settingsConnectionstring) ? ".\\USSI.API.db" : settingsConnectionstring));
            return services;
        }

        public static IServiceCollection AddSQLiteImporterService(this IServiceCollection services, string importerConnectionString)
        {
            services.AddKeyedTransient<IDbConnection>("sqlite:write", (sp, key) => new SqliteConnection(string.IsNullOrEmpty("") ? ".\\USSI.API.db" : ""));
            return services;
        }
    }
}
