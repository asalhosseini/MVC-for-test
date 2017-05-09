using System.Data.OleDb;
using System.Data;

namespace DAL
{
    public abstract class BaseAdapter<T> where T : DataTable, new()
    {
        protected virtual T select_All(string pQuerySelectAll)
        {
            T retTable = new T();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = pQuerySelectAll;
            cmd.Connection = ConnectionManager.GetConnection2selectunit;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(retTable);
            return retTable;
        }

        protected virtual T select_By(string pQuerySelect, OleDbParameter[] pParamsWhere)
        {
            T retTable = new T();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = pQuerySelect;
            cmd.Parameters.AddRange(pParamsWhere);
            cmd.Connection = ConnectionManager.GetConnection2selectunit;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(retTable);
            return retTable;
        }

        public bool execute_Command_NonQuery(string pQuery, OleDbParameter[] pParams)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = pQuery;
            cmd.Connection = ConnectionManager.GetConnection2selectunit;
            cmd.Parameters.AddRange(pParams);
            ConnectionManager.Open_Connection2selectunit;
            int i = cmd.ExecuteNonQuery();
            ConnectionManager.Close_Connection_From_selectunit;
            return i > 0;
        }
    }
}
            