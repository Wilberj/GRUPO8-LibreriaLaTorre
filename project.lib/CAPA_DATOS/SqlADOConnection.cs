using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class SqlADOConnection
    {
        static string UserSQLConnection = "";
        public static SqlServerGDatos SQLM;

        static public bool InitConnection(string user, string password)
        {
            try
            {
                UserSQLConnection = "Data Source=.; Initial Catalog=BDproyectolibreria;Integrated Security=True;";
                //UserSQLConnection = "Data Source=CRYPTOHEGELIAN\\SQLSERVER;Initial Catalog=BDproyectolibreria;Integrated Security=True;MultipleActiveResultSets=True;";

                
                SQLM = new SqlServerGDatos(UserSQLConnection);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
