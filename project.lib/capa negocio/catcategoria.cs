using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace capa_negocio
{
    internal class CatCategoria
    {
        public string TableName = "Categoria";
        int IdCategoria { get; set; }
        public bool Estado { get; set; }
        public string Nombre { get; set; }

        public object Save(CatCategoria Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");

                if (Inst.IdCategoria == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }               
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "idCategoria");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
        public object Delete(CatCategoria Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                
                if(Inst.IdCategoria < 0)
                {
                    throw new Exception("Especifique IdProducto");
                }
                else
                {
                    return SqlADOConexion.SQLM.DeleteObject(TableName, "IdCategoria", Inst.IdCategoria);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //METODO GET
    }
}
