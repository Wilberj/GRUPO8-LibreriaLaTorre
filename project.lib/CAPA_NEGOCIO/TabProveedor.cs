using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CAPA_NEGOCIO
{
    public class TabProveedor
    {
        public string TableName = "proveedor";
        public int Id_Proveedor { get; set; }
        public string Nombre { get; set; }
        public string Dirección { get; set; }
        public string  Telefono { get; set; }
        public int Estado { get; set; }


        public object Save(TabProveedor Inst)
        {
            try
            {
                SqlADOConnection.InitConnection("sa", "1234");

                if (Inst.Id_Proveedor == -1)
                {
                    return SqlADOConnection.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConnection.SQLM.UpdateObject(TableName, Inst, "Id_Proveedor");
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public object Get(TabProveedor Inst)
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
