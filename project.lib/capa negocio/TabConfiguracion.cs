using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace capa_negocio
{
    public class TabConfiguracion
    {
        public string TableName = "Configuracion";
        public int IdConfig { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public bool Estado { get; set; }

        public object Save(TabConfiguracion Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdConfig == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdConfig");
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Delete(TabConfiguracion Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");

                if (Inst.IdConfig < 0)
                {
                    throw new Exception("Especifique IdConfig");
                }
                else
                {
                    return SqlADOConexion.SQLM.DeleteObject(TableName, "IdConfig", Inst.IdConfig);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Get(TabConfiguracion   Inst)
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

