using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Connection
    {
        private SqlConnection sqlConnection { get; set; } = new SqlConnection();  

        public Connection()
        {
            sqlConnection.ConnectionString = ConfigurationManager.AppSettings["cnx"].ToString();
        }

        public DataTable GetData(string query)
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand(query, sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            sqlConnection.Close();

            return table;
        }

        public bool Execute(string query)
        {
            try
            {            
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);
            
                command.ExecuteNonQuery();

                sqlConnection.Close();

            }
            catch (System.Exception ex)
            {
                return false;
            }

            return true;

        }
    }
}
