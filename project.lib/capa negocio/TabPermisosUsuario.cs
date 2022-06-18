using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace capa_negocio
{
        public class TabPermisosUsuarios
        {
            public string TableName = "Permisos";
            public int IdPermiso { get; set; }
            public int IdRol { get; set; }
            public string TipoPermiso { get; set; }
            public bool Estado { get; set; }

            public object Save(TabPermisosUsuarios Inst)
            {
                try
                {
                    SqlADOConexion.IniciarConexion("sa", "1234");
                    if (Inst.IdPermiso == -1)
                    {
                        return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                    }
                    else
                    {
                        return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdPermiso");
                    }
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public object Delete(TabPermisosUsuarios Inst)
            {
                try
                {
                    SqlADOConexion.IniciarConexion("sa", "1234");

                    if (Inst.IdPermiso < 0)
                    {
                        throw new Exception("Especifique IdPermiso");
                    }
                    else
                    {
                        return SqlADOConexion.SQLM.DeleteObject(TableName, "IdConfig", Inst.IdPermiso);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public object Get(TabPermisosUsuarios Inst)
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