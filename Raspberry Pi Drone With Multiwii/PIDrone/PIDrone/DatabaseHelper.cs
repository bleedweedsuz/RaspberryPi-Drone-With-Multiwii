using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PIDrone
{
    public class DatabaseHelper
    {
        public static SqlConnection sqlConnection;
        public static SqlDataReader sqlDataReader;
        public static void OpenConnection()
        {
            String dataBaseFile = Application.StartupPath + "\\Database\\PiDroneDB.mdf";
            //String connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + dataBaseFile + ";Integrated Security=True;User Instance=True;MultipleActiveResultSets=true;";

            String connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + dataBaseFile + ";Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }
        public static void ExecuteQry(String qry,Boolean state)
        {
            SqlCommand sqlCommand = new SqlCommand(qry, sqlConnection);
            if (state)
            {
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                sqlDataReader = sqlCommand.ExecuteReader();
            }
        }
        public static void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public static void ExecuteProcedure(String procedureName, Boolean state)
        {
            SqlCommand sqlCommand = new SqlCommand(procedureName, sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            if (state)
            {
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                sqlDataReader = sqlCommand.ExecuteReader();
            }
        }
        public static void ExecuteProcedureWithParameter(SqlCommand sqlCommand,Boolean state)
        {
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            if (state)
            {
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                sqlDataReader = sqlCommand.ExecuteReader();
            }
        }
        public static Int64 getNextSnNo(String column, String table)
        {
            Int64 nextSn = 1;
            try
            {
                DatabaseHelper.OpenConnection();
                String qry = "select MAX(" + column + ") from " + table + "";
                DatabaseHelper.ExecuteQry(qry, false);
                DatabaseHelper.sqlDataReader.Read();
                if (DatabaseHelper.sqlDataReader.HasRows)
                {
                    nextSn = Convert.ToInt64(DatabaseHelper.sqlDataReader[0]) + 1;
                }
                else
                {
                    nextSn = 1;
                }
                DatabaseHelper.sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DatabaseHelper.CloseConnection();
            }
            return nextSn;
        }
        public static void ExecuteQryNonQry(String qry, List<SqlParameter> sqlParameter)
        {
            SqlCommand sqlCommand = new SqlCommand(qry, sqlConnection);
            for (int i = 0; i < sqlParameter.Count; i++)
            {
                sqlCommand.Parameters.Add(sqlParameter[i]);
            }
            sqlCommand.ExecuteNonQuery();
        }
    }
}
