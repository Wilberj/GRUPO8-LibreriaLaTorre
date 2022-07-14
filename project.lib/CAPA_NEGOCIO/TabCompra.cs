using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CAPA_NEGOCIO
{
    public class TabCompra
    {
        public string TableName = "Compra";
        public int Id_Compra { get; set; }
        public int Id_Proveedor { get; set; }
        public DateTime Fecha_Compra { get; set; }
        public Decimal Total { get; set; }
        public int Id_Usuario { get; set; }
        public Decimal Sub_Total { get; set; }
        public Decimal IVA { get; set; }
        public Decimal Descuento { get; set; }
        public int Estado { get; set; }

        public Object Save(TabCompra Inst)
        {
            try
            {
                SqlADOConnection.InitConnection("sa", "1234");
                if (Inst.Id_Compra == -1)
                {
                    return SqlADOConnection.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConnection.SQLM.UpdateObject(TableName, Inst, "Id_Compra");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Object GetList(TabCompra Inst)
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
