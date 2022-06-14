using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace capa_negocio
{
    public class TabDetalleVenta
    {
        public string TableName = "DetalleVenta";
        public int IdDetalleVenta { get; set; }
        public int IdArticulo { get; set; }
        public int IdVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotalVenta { get; set; }
        public decimal TotalVenta { get; set; }
        public decimal Descuento { get; set; }
        public decimal IVA { get; set; }

        public object Save(TabDetalleVenta Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("s", "1234");
                if (Inst.IdDetalleVenta == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdDetalleVenta");
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
