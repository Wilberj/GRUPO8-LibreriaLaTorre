using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace capa_negocio
{
    public class TabCliente
    {
        public string TableName = "Cliente";
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
        public object Delete(TabCliente Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");

                if (Inst.IdCliente < 0)
                {
                    throw new Exception("Especifique IdCliente");
                }
                else
                {
                    return SqlADOConexion.SQLM.DeleteObject(TableName, "IdCliente", Inst.IdCliente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Get(TabCliente Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                return SqlADOConexion.SQLM.TakeList(TableName, Inst, null);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
