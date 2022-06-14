using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace capa_negocio
{
    public class TabCliente
    {
        public string TableName = "IdCliente";
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public int FechaIngreso { get; set; }
        public int NumeroTelefono { get; set; }

        public object Save(TabCliente Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("s", "1234");
                if (Inst.IdCliente == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdCliente");
                }
            }


            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
