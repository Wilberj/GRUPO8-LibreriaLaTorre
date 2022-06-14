using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace capa_negocio
{
    internal class TabCompra
    {
        public string TableName = "Compra";
        public int IdCompra { get; set; }
        public int IdProveedor { get; set; }
        public int IdUsuario { get; set; }
        public decimal SubTotalCompra { get; set; }
        public decimal TotalCompra { get; set; }
        public bool IdEstado { get; set; }
        public decimal Descuento { get; set; }
        public decimal IVA { get; set; }

        public object Save(TabCompra Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");

                if (Inst.IdCompra == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdCompra");
                }
            }
            catch (Exception e)
            {
                throw;
            }

        }

    }





}
