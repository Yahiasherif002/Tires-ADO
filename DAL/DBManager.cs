using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    public class DBManager
    {
        SqlConnection sqlCN;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDA;
        DataTable dt;

        public DBManager()
        {
            try
            {
                sqlCN = new SqlConnection();
                sqlCN.ConnectionString = ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString;

                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Connection = sqlCN;

                sqlDA = new SqlDataAdapter(sqlCmd);
                dt = new DataTable();
            }
              catch (SqlException ex)
            {
                throw ex;
            }
         }
        public int executeNonQuery(string query)
        {
            int excutedQuery = -1;
            try
            {
                if(sqlCN?.State == ConnectionState.Closed)
                {
                    sqlCN.Open();
                    sqlCmd.CommandText = query;
                    sqlCmd.Parameters.Clear();
                    excutedQuery = sqlCmd.ExecuteNonQuery();
                    sqlCN.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return excutedQuery; 
        }

        public object executeScalar(string query)
        {
            object excutedQuery = new object();
            try
            {
                if (sqlCN?.State == ConnectionState.Closed)
                {
                    sqlCN.Open();
                    sqlCmd.CommandText = query;
                    sqlCmd.Parameters.Clear();
                    excutedQuery = sqlCmd.ExecuteScalar();
                    sqlCN.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return excutedQuery;
        }

        public DataTable executeReader(string query)
        { dt.Clear();
            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = query;
                sqlDA.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return dt;
        }

    }
}
