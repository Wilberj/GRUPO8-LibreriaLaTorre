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
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdUsuario");
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
