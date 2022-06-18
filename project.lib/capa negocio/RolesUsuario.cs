using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace capa_negocio
{
    public class TabRolesUsuario
    {
        public string TableName = "RolesUsuario";
        public int IdRol { get; set; }
        public string TipoRol { get; set; }
        public string TipoPermiso { get; set; }
        public bool Estado { get; set; }

        public object Save(TabRolesUsuario Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdRol == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdRol");
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Delete(TabRolesUsuario Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");

                if (Inst.IdRol < 0)
                {
                    throw new Exception("Especifique IdRol");
                }
                else
                {
                    return SqlADOConexion.SQLM.DeleteObject(TableName, "IdRol", Inst.IdRol);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Get(TabRolesUsuario Inst)
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

   
