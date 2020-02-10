using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

using System.Threading.Tasks;
using System.Xml;
using Database = Microsoft.Practices.EnterpriseLibrary.Data.Database;

namespace Infrastructure.Data
{
  public static class DataBaseExtensions
    {
        public static async Task<IDataReader> ExecuteReaderAsync(this Database database  , DbCommand command)
        {

            return await Task<IDataReader>.Factory.FromAsync(database.BeginExecuteReader, database.EndExecuteReader, command, null);

        }

        public static async Task<object> ExecuteScalarAsync(this Database database, DbCommand command)
        {

            return await Task<object>.Factory.FromAsync(database.BeginExecuteScalar, database.EndExecuteScalar, command, null);

        }

        public static async Task<XmlReader> ExecuteXmlReaderAsync(this SqlDatabase database, DbCommand command)
        {

            return await Task<XmlReader>.Factory.FromAsync(database.BeginExecuteXmlReader, database.EndExecuteXmlReader, command, null);

        }

        public static async Task<int> ExecuteNonQueryAsync(this Database database, DbCommand command)
        {

            return await Task<int>.Factory.FromAsync(database.BeginExecuteNonQuery, database.EndExecuteNonQuery, command, null);

        }
    }
}
