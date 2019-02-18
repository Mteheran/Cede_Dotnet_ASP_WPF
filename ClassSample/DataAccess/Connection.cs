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

        //public DataTable GetData(string query)
        //{
        //    sqlConnection.Open();

        //    SqlCommand command = new SqlCommand(query, sqlConnection);

        //    SqlDataAdapter adapter = new SqlDataAdapter(command);

        //    DataTable table = new DataTable();

        //    adapter.Fill(table);

        //    sqlConnection.Close();

        //    return table;
        //}


        public DataTable GetData(string query)
        {
            sqlConnection.Open();

            SqlCommand command = new SqlCommand(query, sqlConnection);


            SqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();

            table.Columns.Add(new DataColumn("ID"));
            table.Columns.Add(new DataColumn("NombreDepartamento"));

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    table.Rows.Add(reader.GetValue(0), reader.GetValue(0));
                }
            }

            //SqlDataAdapter adapter = new SqlDataAdapter(command);

            //DataTable table = new DataTable();

            //adapter.Fill(table);

            //sqlConnection.Close();

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
