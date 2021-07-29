using System.Data;
using System.Data.SqlClient;

namespace Quality_Video_Rental_Store_Auckland
{

    public class DatabaseLogics
    {
        public string connString = "Data Source=DESKTOP-LTQK306;Initial Catalog=Quality_Video_Rental_Store_Auckland;Integrated Security=True";
        
        public SqlConnection sqlConn;
        public SqlCommand sqlCmd;
        public void DbChanges(string dbConnectionQuery)
        {
            sqlConn = new SqlConnection(connString);
            sqlConn.Open();
            sqlCmd = new SqlCommand(dbConnectionQuery, sqlConn);
            sqlCmd.ExecuteNonQuery();
            sqlConn.Close();
        }

        public SqlDataReader sqlDataRdr;
        public DataTable SaveChanges(string dbChangesQuery)
        {
            DataTable tbl = new DataTable();

            sqlConn = new SqlConnection(connString);

            sqlConn.Open();

            sqlCmd = new SqlCommand(dbChangesQuery, sqlConn);

            sqlDataRdr = sqlCmd.ExecuteReader();

            tbl.Load(sqlDataRdr);

            sqlConn.Close();

            return tbl;
        }
    }
}
