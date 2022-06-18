using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;


namespace capa_negocio
{
    public class TabStock
    {
        public string TableName = "ArticuloStock";
        public int IdStock { get; set; }
        public int IdBodega { get; set; }
        public int Cantidad { get; set; }
        public bool Estado { get; set; }
        public decimal ValorCompras { get; set; }
        public decimal valorVentas { get; set; }
        public string Descripcion { get; set; }
        public string Almacenamiento { get; set; }


        public object Save(TabStock Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                if (Inst.IdStock == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdStock");
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Delete(TabStock Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");

                if (Inst.IdStock < 0)
                {
                    throw new Exception("Especifique IdStock");
                }
                else
                {
                    return SqlADOConexion.SQLM.DeleteObject(TableName, "IdStock", Inst.IdStock);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Get(TabStock Inst)
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


   

