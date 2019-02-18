using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ConnectionOleDB
    {
        private OleDbConnection sqlConnection { get; set; } = new OleDbConnection();

        public ConnectionOleDB()
        {
            sqlConnection.ConnectionString = ConfigurationManager.AppSettings["cnxOleDb"].ToString();
        }

        public DataTable GetData(string query)
        {
            sqlConnection.Open();

            OleDbCommand command = new OleDbCommand(query, sqlConnection);

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

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

                OleDbCommand command = new OleDbCommand(query, sqlConnection);

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
