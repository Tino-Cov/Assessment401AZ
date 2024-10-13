using MySql.Data.MySqlClient;
using Assessment401AZ.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment401AZ.DBOperations
{
    public class Address
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public void AddAddress(Address address)
        {
            string query = "CALL AddAddress(@p_street, @p_city, @p_postcode)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_street", address.Street);
            command.Parameters.AddWithValue("@p_city", address.City);
            command.Parameters.AddWithValue("@p_postcode", address.Postcode);

            dataAccess.ExecuteNonQuery(command);
        }

        public DataTable GetAddresss()
        {
            string query = "CALL GetAddresss()";
            return dataAccess.ExecuteQuery(query);
        }

        public void UpdateAddress(Address address)
        {
            string query = "CALL UpdateAddress(@p_id, @p_street, @p_city, @p_postcode, @p_dateofbirth)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_id", address.AddressID);
            command.Parameters.AddWithValue("@p_street", address.Street);
            command.Parameters.AddWithValue("@p_city", address.City);
            command.Parameters.AddWithValue("@p_postcode", address.PostCode);

            dataAccess.ExecuteNonQuery(command);
        }

        public void DeleteAddress(int addressId)
        {
            string query = "CALL DeleteAddress(@p_id)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_id", addressId);

            dataAccess.ExecuteNonQuery(command);
        }

    }

}
