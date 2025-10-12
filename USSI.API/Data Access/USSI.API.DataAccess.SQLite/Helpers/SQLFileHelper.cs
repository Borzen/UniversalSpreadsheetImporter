using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USSI.API.DataAccess.SQLite.Helpers
{
    internal static class SQLFileHelper
    {
        internal static string StoredProcFolder = "USSI.API.DataAccess.SQLite.SQLFiles.StoredProcs";
        internal static class Template
        {
            internal static string StoredProcFolder = ".Templates";

            internal static string GetAll = "GetTemplates.sql";
            internal static string GetById = "GetTemplateById.sql";
            internal static string Insert = "InsertTemplate.sql";
            internal static string Update = "UpdateTemplate.sql";
            internal static string Delete = "DeleteTemplate.sql";
        }
        internal static class TemplateColumn
        {
            internal static string StoredProcFolder = ".TemplateColumns";

            internal static string GetAll = "GetTemplateColumns.sql";
            internal static string GetById = "GetTemplateColumnById.sql";
            internal static string Insert = "InsertTemplateColumn.sql";
            internal static string Update = "UpdateTemplateColumn.sql";
            internal static string Delete = "DeleteTemplateColumn.sql";

            internal static string DeleteByTemplateId = "DeleteTemplateColumnByTemplateId.sql";
            internal static string GetByTemplateId = "GetTemplateColumnsByTemplateId.sql";
        }
    }
}
