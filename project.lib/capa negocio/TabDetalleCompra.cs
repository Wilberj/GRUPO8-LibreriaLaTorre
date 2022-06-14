using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace capa_negocio
{
    public class TabDetalleCompra
    {
        public string TableName = "DetalleCompra";
        public int IdDetalleCompra { get; set; }
        public int IdCompra { get; set; }
        public int IdProveedor { get; set; }
        public int IdUsuario { get; set; }
        public decimal SubTotalCompra { get; set; }
        public decimal TotalCompra { get; set; }
        public bool IdEstado { get; set; }
        public decimal Descuento { get; set; }
        public decimal IVA { get; set; }
        public int IdArticuloStock { get; set; }
        public int Cantidad { get; set; }

        public object Save(TabDetalleCompra Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("s", "1234");
                if (Inst.IdDetalleCompra == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdDetalleCompra");
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
