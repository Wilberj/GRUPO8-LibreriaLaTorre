using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace capa_negocio
{
    internal class catcategoria
    {
        public string TableName = "Categoria";
        int IdCategoria { get; set; }
        bool Estado { get; set; }
        string Nombre { get; set; }

        public object Save(catcategoria Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");

                if (Inst.IdCategoria == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "idCategoria");
                }

            }
            catch (Exception e)
            {
                throw;
            }



        }
    }
}
