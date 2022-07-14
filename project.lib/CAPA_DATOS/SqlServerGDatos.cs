using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class SqlServerGDatos:GDataAbstrac
    {
        public SqlServerGDatos(string ConnectionString)
        {
            SQLMCon = CreateConection(ConnectionString);
        }
        protected override IDbConnection CreateConection(string stringCon)
        {
            return new SqlConnection(stringCon);
        }
        protected override IDbCommand CommandSQL(string commandSql, IDbConnection connection)
        {
            var CMD = new SqlCommand(commandSql, (SqlConnection)connection);
            return CMD;
        }
        protected override IDbDataAdapter CreateDataAdapterSQL(string commandSql, IDbConnection connection)
        {
            var DA = new SqlDataAdapter((SqlCommand)CommandSQL(commandSql, connection));
            return DA;
        }
        protected override IDbDataAdapter CreateDataAdapterSQL(IDbCommand commandSql)
        {
            var DA = new SqlDataAdapter((SqlCommand)commandSql);
            return DA;
        }
    }
}