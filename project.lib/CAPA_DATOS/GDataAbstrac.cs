using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace CapaDatos
{
    public abstract class GDataAbstrac
    {
        protected IDbConnection SQLMCon;
        protected abstract IDbConnection CreateConection(string stringCon);
        protected abstract IDbCommand CommandSQL(string commandSql, IDbConnection connection);
        protected abstract IDbDataAdapter CreateDataAdapterSQL(string commandSql, IDbConnection connection);
        protected abstract IDbDataAdapter CreateDataAdapterSQL(IDbCommand commandSql);
        public object ExecuteSqlQuery(string strQuery)
        {
            try
            {                
                SQLMCon.Open();
                var cmd = CommandSQL(strQuery, SQLMCon);
                var scalar = cmd.ExecuteScalar();
                SQLMCon.Close();
                if (scalar == (object)DBNull.Value)
                {
                    return true;
                }
                else
                {
                    return Convert.ToInt32(scalar);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable GetDataSQL(string queryString)
        {
            DataSet ObjDS = new DataSet();
            CreateDataAdapterSQL(queryString, SQLMCon).Fill(ObjDS);
            return ObjDS.Tables[0].Copy();
        }
        public DataTable GetDataSQL(IDbCommand queryString)
        {
            DataSet ObjDS = new DataSet();
            CreateDataAdapterSQL(queryString).Fill(ObjDS);
            return ObjDS.Tables[0].Copy();
        }
        public Object InsertObject(string TableName, object Inst)
        {
            try
            {
                string ColumnNames = "";
                string Values = "";
                Type _type = Inst.GetType();
                PropertyInfo[] lst = _type.GetProperties();
                foreach (PropertyInfo oProperty in lst)
                {
                    string AttributeName = oProperty.Name;
                    var AttributeValue = oProperty.GetValue(Inst);

                    if (AttributeName != "Id")
                    {
                        if (AttributeValue.GetType() == typeof(string))
                        {
                            ColumnNames = ColumnNames + AttributeName.ToString() + ",";
                            Values = Values + "'" + AttributeValue.ToString() + "',";
                        }
                        else if (AttributeValue.GetType() == typeof(DateTime))
                        {
                            ColumnNames = ColumnNames + AttributeName.ToString() + ",";
                            Values = Values + "'" + ((DateTime)AttributeValue).ToString("yyyy/MM/dd") + "',";
                        }
                        else
                        {
                            if (AttributeValue.GetType() == typeof(int)) {
                                if ((Int32)AttributeValue != -1)
                                {
                                    ColumnNames = ColumnNames + AttributeName.ToString() + ",";
                                    Values = Values + AttributeValue.ToString() + ',';
                                }
                            }
                            if (AttributeValue.GetType() == typeof(decimal))
                            {
                                if ((Decimal)AttributeValue != -1)
                                {
                                    ColumnNames = ColumnNames + AttributeName.ToString() + ",";
                                    Values = Values + AttributeValue.ToString() + ',';
                                }
                            }
                        }
                    }
                }
                ColumnNames = ColumnNames.TrimEnd(',');
                Values = Values.TrimEnd(',');
                string strQuery = "INSERT INTO " + TableName + "(" + ColumnNames + ")" + 
                    " VALUES(" + Values + ") SELECT SCOPE_IDENTITY()";
                return ExecuteSqlQuery(strQuery);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Object UpdateObject(string TableName, object Inst, string IdObject)
        {
            try
            {
                string Values = "";
                Type _type = Inst.GetType();
                PropertyInfo[] lst = _type.GetProperties();
                PropertyInfo prop = lst[0];
                foreach (PropertyInfo oProperty in lst)
                {
                    string AttributeName = oProperty.Name;
                    var AttributeValue = oProperty.GetValue(Inst);

                    if (AttributeName != "Id")
                    {
                        if (AttributeName != IdObject)
                        {
                            if (AttributeValue.GetType() == typeof(string) || AttributeValue.GetType() == typeof(DateTime))
                            {
                                Values = Values + AttributeName + "= '" + AttributeValue.ToString() + "',";
                            }
                            else
                            {
                                Values = Values + AttributeName + "=" + AttributeValue.ToString() + ',';
                            }
                        }
                        else
                        {
                            prop = oProperty;
                        }
                    }
                }
                Values = Values.TrimEnd(',');
                string strQuery = "UPDATE " + TableName + " SET " + Values + " WHERE " + IdObject + " = " + prop.GetValue(Inst).ToString();
                return ExecuteSqlQuery(strQuery);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Object TakeList(string TableName, Object Inst, string? Condition)
        {
            try
            {
                string ConditionString = "";
                if (Condition != null)
                {
                    ConditionString = " WHERE " + Condition;
                }
                string queryString = "SELECT * FROM " + TableName + ConditionString;
                DataTable Table = GetDataSQL(queryString);
                List<Object> ListD = ConvertDataTable(Table, Inst);
                return ListD;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Object TakeListWithProcedure(string ProcedureName, Object Inst, List<Object> Params)
        {
            try
            {
                SQLMCon.Open();
                var Command = CommandSQL(ProcedureName, SQLMCon);
                Command.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters((SqlCommand)Command);
                SQLMCon.Close();
                if (Params.Count != 0)
                {
                    int i = 0;
                    foreach (var param in Params)
                    {
                        var p = (SqlParameter)Command.Parameters[i + 1];
                        p.Value = param;
                        i++;
                    }
                }
                DataTable Table = GetDataSQL(Command);
                List<Object> ListD = ConvertDataTable(Table, Inst);
                return ListD;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static List<Object> ConvertDataTable(DataTable dt, Object Inst)
        {
            List<Object> data = new List<object>();
            foreach (DataRow row in dt.Rows)
            {
                var item = GetItem(row, Inst);
                data.Add(item);
            }
            return data;
        }
        private static Object GetItem(DataRow dr, Object Inst)
        {
            Type temp = Inst.GetType();
            var obj = Activator.CreateInstance(Inst.GetType());
            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                    {
                        if (column.DataType == typeof(bool))
                        {
                            pro.SetValue(obj, Convert.ToInt32(dr[column.ColumnName]), null);
                        }
                        else
                        {
                            pro.SetValue(obj, dr[column.ColumnName], null);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return obj;
        }
    }
}
