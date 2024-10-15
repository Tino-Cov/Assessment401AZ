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
    public class AddressOperations
    {//creating operations//
        private readonly DataAccess dataAccess = new DataAccess();

        public void AddAddress(Address address)
        {//adding Address variables //
            string query = "CALL AddAddress(@p_street, @p_city, @p_postcode)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_street", address.Street);
            command.Parameters.AddWithValue("@p_city", address.City);
            command.Parameters.AddWithValue("@p_postcode", address.PostCode);

            dataAccess.ExecuteNonQuery(command);
        }

        public DataTable GetAddress()
        {
            string query = "CALL GetAddress()";
            return dataAccess.ExecuteQuery(query);
        }

        public void UpdateAddress(Address address)
        {//created update function for gui//
            string query = "CALL UpdateAddress(@p_addressID, @p_street, @p_city, @p_postcode, @p_dateofbirth)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_addressID", address.AddressID);
            command.Parameters.AddWithValue("@p_street", address.Street);
            command.Parameters.AddWithValue("@p_city", address.City);
            command.Parameters.AddWithValue("@p_postcode", address.PostCode);

            dataAccess.ExecuteNonQuery(command);
        }

        public void DeleteAddress(int addressID)
        { // delete function //
            string query = "CALL DeleteAddress(@p_addressID)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_addressID", addressID);

            dataAccess.ExecuteNonQuery(command);
        }

    }

}
