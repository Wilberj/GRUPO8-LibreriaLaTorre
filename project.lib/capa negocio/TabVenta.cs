using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace capa_negocio
{
    public class TabVenta
    {
        public string TableName = "Venta";
        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        public int Fecha { get; set; }
        public string NombreCliente { get; set; }
        public int NumVenta { get; set; }
        public decimal SubTotalVenta { get; set; }
        public decimal TotalVenta { get; set; }
        public decimal Descuento { get; set; }
        public decimal IVA { get; set; }

        public object Save(TabVenta Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("s", "1234");
                if (Inst.IdVenta == -1)
                {
                    return SqlADOConexion.SQLM.InserObject(TableName, Inst);
                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, Inst, "IdVenta");
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Delete(TabVenta Inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");

                if (Inst.IdVenta < 0)
                {
                    throw new Exception("Especifique IdVenta");
                }
                else
                {
                    return SqlADOConexion.SQLM.DeleteObject(TableName, "IdVenta", Inst.IdVenta);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object Get(TabVenta Inst)
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
