using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CAPA_NEGOCIO
{
    public class TabUsuario
    {
        public string TableName = "usuario";
        public int Id_Usuario { get; set; }
        public string Username { get; set; }
        public int Estado { get; set; }

        public Object Save(TabUsuario Inst)
        {
            try
            {
                SqlADOConnection.InitConnection("sa", "1234");
                if (Inst.Id_Usuario == -1)
                {
                    return SqlADOConnection.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConnection.SQLM.UpdateObject(TableName, Inst, "Id_Usuario");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Object GetList(TabUsuario Inst)
        {
            try
            {
                SqlADOConnection.InitConnection("sa", "1234");
                return SqlADOConnection.SQLM.TakeList(TableName, Inst, null);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
