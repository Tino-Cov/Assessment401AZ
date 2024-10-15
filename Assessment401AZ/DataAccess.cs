using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment401AZ
{
    public class DataAccess
    {
        private readonly string connectionString = "Server=assessment401az.ci17jcpofb3i.us-east-1.rds.amazonaws.com;Database=Assessment401AZ;User ID=admin;Password=Tinotenda220804.;Convert Zero Datetime=True;";

        public DataTable ExecuteQuery(string query)
        {
            using (MySqlConnection  connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public void ExecuteNonQuery(MySqlCommand command)  
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }
    }
}

