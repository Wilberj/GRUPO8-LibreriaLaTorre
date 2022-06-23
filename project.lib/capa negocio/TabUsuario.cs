using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace capa_negocio
{
    public class TabUsuario
    {
        public string TableName = "Usuario";
        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int IdRol { get; set; }
        public bool Estado { get; set; }

        public object Save(TabUsuario Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("s", "1234");
                if (Inst.IdUsuario == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, null); //revisar el null 
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Delete(TabUsuario Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");

                if (Inst.IdUsuario < 0)
                {
                    throw new Exception("Especifique IdUsuario");
                }
                else
                {
                    return SqlADOConexion.SQLM.DeleteObject(TableName, "IdUsuario", Inst.IdUsuario);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Get(TabUsuario Inst)
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
