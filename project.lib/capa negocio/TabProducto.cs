using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace capa_negocio
{
    public class TabProducto
    {
        public string TableName = "Producto";
        public int IdProd { get; set; } 
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public object Save(TabProducto Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");

                if (Inst.IdProd == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdProd");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Delete(TabProducto Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");

                if (Inst.IdProd < 0)
                {
                    throw new Exception("Especifique IdProducto");
                }
                else
                {
                    return SqlADOConexion.SQLM.DeleteObject(TableName, "IdProducto", Inst.IdProd);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Get(TabProducto Inst)
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
