using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USSI.API.Core.DataServices.Interfaces;
using USSI.API.DataAccess.SQLite.InitDb;
using System.Data;
using Microsoft.Data.Sqlite;

namespace USSI.API.DataAccess.SQLite.IoC
{
    public static class SQLiteDataAccessExtensions
    {
        public static IServiceCollection AddSQLiteDataAccess(this IServiceCollection services, string settingsConnectionstring)
        {
            services.AddSingleton<IDBUpRunner, SQLiteDBUpRunner>();
            services.AddKeyedTransient<IDbConnection>("settings", (sp,key) => new SqliteConnection(string.IsNullOrEmpty(settingsConnectionstring) ? ".\\USSI.API.db" : settingsConnectionstring));
            services.AddKeyedTransient<IDbConnection>("write", (sp, key) => new SqliteConnection(string.IsNullOrEmpty("") ? ".\\USSI.API.db" : ""));
            return services;
        }
    }
}
