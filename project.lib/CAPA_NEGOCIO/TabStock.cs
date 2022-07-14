using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CAPA_NEGOCIO
{
    public class TabStock
    {
        public string TableName = "stock_articulos";
        public int Id_StockArticulo { get; set; }
        public int Id_Producto { get; set; }
        public int Id_Bodega { get; set; }
        public int Id_Compra { get; set; }
        public int Cantidad { get; set; }
        public int Estado { get; set; }
        public int Valor_Unitario { get; set; }
        public int Precio_Compra { get; set; }
        public int Precio_Venta { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Ingreso {get; set;} 
        public int Condicion_Prod { get; set; }
        public string Color { get; set; }
        public int IdMarca { get; set; }
        public string Dimensiones { get; set; }

        public Object Save(TabStock Inst)
        {
            try
            {
                SqlADOConnection.InitConnection("sa", "1234");
                if (Inst.Id_StockArticulo == -1)
                {
                    return SqlADOConnection.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConnection.SQLM.UpdateObject(TableName, Inst, " Id_StockArticulo");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Object GetList(TabStock Inst)
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
