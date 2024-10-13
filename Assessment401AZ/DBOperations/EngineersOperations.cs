using Assessment401AZ.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment401AZ.DBOperations
{
    public class EngineersOperations
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public void AddEngineers(Engineers engineers)
        {
            string query = "CALL AddEngineers(@p_first, @p_lastname, @p_dateofbirth, @p_tel, @p_addressid)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_firstname", engineers.FirstName);
            command.Parameters.AddWithValue("@p_lastname", engineers.LastName);
            command.Parameters.AddWithValue("@p_dateofbirth", engineers.Dateofbirth.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@p_tel", engineers.Tel);
            command.Parameters.AddWithValue("@p_addressid", engineers.AddressID);


            dataAccess.ExecuteNonQuery(command);
        }

        public DataTable GetEngineerss()
        {
            string query = "CALL GetEngineerss()";
            return dataAccess.ExecuteQuery(query);
        }

        public void UpdateEngineers(Engineers engineers)
        {
            string query = "CALL UpdateEngineers(@p_engineerid, @p_firstname, @p_lastname, @p_addressid, @p_dateofbirth)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_engineerid", engineers.EngineerID);
            command.Parameters.AddWithValue("@p_firstname", engineers.FirstName);
            command.Parameters.AddWithValue("@p_lastname", engineers.LastName);
            command.Parameters.AddWithValue("@p_dateofbirth", engineers.Dateofbirth.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@p_tel", engineers.Tel);
            command.Parameters.AddWithValue("@p_addressid", engineers.AddressID);

            dataAccess.ExecuteNonQuery(command);
        }

        public void DeleteEngineers(int engineersID)
        {
            string query = "CALL DeleteEngineers(@p_engineerid)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_engineerid", engineersID);

            dataAccess.ExecuteNonQuery(command);
        }

    }

}
