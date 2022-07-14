using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos; 

namespace CAPA_NEGOCIO
{
    public class TabDetalleCompra
    {
        public string TableName = "detalle_compra";
        public int Id_DetalleCompra { get; set; }
        public int Id_Compra { get; set; }
        public int Cantidad_Compra { get; set; }
        public int Precio_Compra { get; set; }
        public string Articulo { get; set; }
        public int Subtotal_Compra { get; set; }
        public int IVA { get; set; }
        public int Total_Compra { get; set; }
        public int Descuento { get; set; }

        public Object Save(TabDetalleCompra Inst)
        {
            try
            {
                SqlADOConnection.InitConnection("sa", "1234");
                if (Inst.Id_DetalleCompra == -1)
                {
                    return SqlADOConnection.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConnection.SQLM.UpdateObject(TableName, Inst, "Id_DetalleCompra");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Object GetList(TabDetalleCompra Inst)
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

