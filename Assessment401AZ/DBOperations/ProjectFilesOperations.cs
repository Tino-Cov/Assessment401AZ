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
    public class ProjectFilesOperations
    {//creating operations//
        private readonly DataAccess dataAccess = new DataAccess();

        public void AddProjectFiles(ProjectFiles projectFiles)
        {//adding projectfiles variables //
            string query = "CALL AddProjectFiles(@p_ProjectName, @p_ProjectStart, @p_ProjectEnd, @p_ProjectAddress, @p_ManagerID)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_ProjectName", projectFiles.ProjectName);
            command.Parameters.AddWithValue("@p_ProjectStart", projectFiles.ProjectStart);
            command.Parameters.AddWithValue("@p_ProjectEnd", projectFiles.ProjectEnd);
            command.Parameters.AddWithValue("@p_ProjectAddress", projectFiles.ProjectAddress);
            command.Parameters.AddWithValue("@p_ManagerID", projectFiles.ManagerID);



            dataAccess.ExecuteNonQuery(command);
        }

        public DataTable GetProjectFiles()
        {
            string query = "CALL GetProjectFiless()";
            return dataAccess.ExecuteQuery(query);
        }

        public void UpdateProjectFiles(ProjectFiles projectFiles)
        {//created update function for gui//
            string query = "CALL UpdateProjectFiles(@p_ProjectID, @p_ProjectName, @p_ProjectStart, @p_ProjectEnd, @p_ProjectAddress, @p_ManagerID)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_ProjectID", projectFiles.ProjectID);
            command.Parameters.AddWithValue("@p_ProjectName", projectFiles.ProjectName);
            command.Parameters.AddWithValue("@p_ProjectStart", projectFiles.ProjectStart);
            command.Parameters.AddWithValue("@p_ProjectEnd", projectFiles.ProjectEnd);
            command.Parameters.AddWithValue("@p_projec taddress", projectFiles.ProjectAddress);
            command.Parameters.AddWithValue("@p_ManagerID", projectFiles.ManagerID);

            dataAccess.ExecuteNonQuery(command);
        }

        public void DeleteProjectFiles(int projectFilesId)
        { // delete function //
            string query = "CALL DeleteProjectFiles(@p_ProjectID)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_ProjectID", projectFilesId);

            dataAccess.ExecuteNonQuery(command);
        }

    }

}

