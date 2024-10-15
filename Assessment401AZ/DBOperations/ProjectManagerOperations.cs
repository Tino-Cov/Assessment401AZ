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
    public class ProjectManagerOperations
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public void AddProjectManager(ProjectManager projectManager)
        {
            string query = "CALL AddProjectManager( @p_FirstName, @p_LastName, @p_Dateofbirth, @p_Management, @p_Tel, @p_EmailAddress)";
            MySqlCommand command = new MySqlCommand(query);

            
            command.Parameters.AddWithValue("@p_FirstName", projectManager.FirstName);
            command.Parameters.AddWithValue("@p_LastName", projectManager.LastName);
            command.Parameters.AddWithValue("@p_Dateofbirth", projectManager.Dateofbirth.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@p_Management", projectManager.Management);
            command.Parameters.AddWithValue("@p_Tel", projectManager.Tel);
            command.Parameters.AddWithValue("@p_EmailAddress", projectManager.EmailAddress);


            dataAccess.ExecuteNonQuery(command);
        }

        public DataTable GetProjectManager()
        {
            string query = "CALL GetProjectManager()";
            return dataAccess.ExecuteQuery(query);
        }

        public void UpdateProjectManager(ProjectManager projectManager)
        {
            string query = "CALL UpdateProjectManager(@p_ManagerID, @p_FirstName, @p_LastName, @p_Dateofbirth, @p_Management, @p_Tel, @p_EmailAddress)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_ManagerID", projectManager.ManagerID);
            command.Parameters.AddWithValue("@p_FirstName", projectManager.FirstName);
            command.Parameters.AddWithValue("@p_LastName", projectManager.LastName);
            command.Parameters.AddWithValue("@p_Dateofbirth", projectManager.Dateofbirth.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@p_Management", projectManager.Management);
            command.Parameters.AddWithValue("@p_Tel", projectManager.Tel);
            command.Parameters.AddWithValue("@p_EmailAddress", projectManager.EmailAddress);

            dataAccess.ExecuteNonQuery(command);
        }

        public void DeleteProjectManager(int projectManagerID)
        {
            string query = "CALL DeleteProjectManager(@p_ManagerID)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_ManagerID", projectManagerID);

            dataAccess.ExecuteNonQuery(command);
        }

    }

}
