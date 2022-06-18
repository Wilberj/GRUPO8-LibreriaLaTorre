using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace capa_negocio
{
    public class TabProveedor
    {
        public string TableName = "Proveedor";
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }

        public object Save(TabProveedor Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdProveedor == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdProveedor");
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Delete(TabProveedor Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");

                if (Inst.IdProveedor < 0)
                {
                    throw new Exception("Especifique IdBodega");
                }
                else
                {
                    return SqlADOConexion.SQLM.DeleteObject(TableName, "IdProveedor", Inst.IdProveedor);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Get(TabProveedor Inst)
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



