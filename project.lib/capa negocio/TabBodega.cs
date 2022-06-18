using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;
namespace capa_negocio
{

    public class TabBodega
    {
        public string TableName = "Bodega";
        public int IdBodega { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }
        public string Traslado { get; set; }

        public object Save(TabBodega Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdBodega == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdBodega");
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Delete(TabBodega Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");

                if (Inst.IdBodega < 0)
                {
                    throw new Exception("Especifique IdBodega");
                }
                else
                {
                    return SqlADOConexion.SQLM.DeleteObject(TableName, "IdBodega", Inst.IdBodega);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Get(TabBodega Inst)
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

