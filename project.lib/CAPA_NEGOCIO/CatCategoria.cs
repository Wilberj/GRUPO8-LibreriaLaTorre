using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CAPA_NEGOCIO
{
    public class CatCategoria
    {
        public string TableName = "categoria";
       public  int Id_Categoria { get; set; }
       
        public string Nombre { get; set; }
        public int Estado { get; set; }
        public Object Save(CatCategoria Inst)
        {
            try
            {
                SqlADOConnection.InitConnection("sa", "1234");

                if (Inst.Id_Categoria == -1)
                {
                    return SqlADOConnection.SQLM.InsertObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConnection.SQLM.UpdateObject(TableName, Inst, "Id_Categoria");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Object GetList(CatCategoria Inst)
        {
            try
            {
                SqlADOConnection.InitConnection("sa", "1234");
                return SqlADOConnection.SQLM.TakeList(TableName, Inst, null);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
