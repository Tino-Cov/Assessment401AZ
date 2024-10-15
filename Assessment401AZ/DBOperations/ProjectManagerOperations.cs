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
    {//creating operations//
        private readonly DataAccess dataAccess = new DataAccess();

        public void AddProjectManager(ProjectManager projectManager)
        { //adding projectmanager variables //
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
        {//created update function for gui//
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
        { // delete function //
            string query = "CALL DeleteProjectManager(@p_ManagerID)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_ManagerID", projectManagerID);

            dataAccess.ExecuteNonQuery(command);
        }

    }

}
