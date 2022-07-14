using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CAPA_NEGOCIO
{
    public class TabProducto
    {
        public string TableName = "Producto";
        public int Id_Producto { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
        public string Nombre { get; set; }
      

        public int Id_Categoria { get; set; }

        public object Save(TabProducto Inst)
        {
            try
            {
                SqlADOConnection.InitConnection("sa", "1234");

                if (Inst.Id_Producto == -1)
                {
                    return SqlADOConnection.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConnection.SQLM.UpdateObject(TableName, Inst, "Id_Producto");
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public object Get(TabProducto Inst)
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
