using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment401AZ.DBOperations
{
    public class ProjectFiles
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public void AddProjectFiles(ProjectFiles projectFiles)
        {
            string query = "CALL AddProjectFiles(@p_projectname, @p_startdate, @p_enddate, @p_projectaddress, @p_engineerid, @p_managerid)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_projectname", projectFiles.ProjectName);
            command.Parameters.AddWithValue("@p_StartDate", projectFiles.StartDate);
            command.Parameters.AddWithValue("@p_enddate", projectFiles.EndDate);
            command.Parameters.AddWithValue("@p_projectaddress", projectFiles.ProjectAddress);
            command.Parameters.AddWithValue("@p_engineerid", projectFiles.EngineerID);
            command.Parameters.AddWithValue("@p_managerid", projectFiles.ManagerID);



            dataAccess.ExecuteNonQuery(command);
        }

        public DataTable GetProjectFiless()
        {
            string query = "CALL GetProjectFiless()";
            return dataAccess.ExecuteQuery(query);
        }

        public void UpdateProjectFiles(ProjectFiles projectFiles)
        {
            string query = "CALL UpdateProjectFiles(@p_id, @p_projectname, @p_startdate, @p_enddate, @p_projectaddress, @p_engineerid, @p_managerid)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_id", projectFiles.ProjectID);
            command.Parameters.AddWithValue("@p_projectname", projectFiles.ProjectName);
            command.Parameters.AddWithValue("@p_StartDate", projectFiles.StartDate);
            command.Parameters.AddWithValue("@p_enddate", projectFiles.EndDate);
            command.Parameters.AddWithValue("@p_projec taddress", projectFiles.ProjectAddress);
            command.Parameters.AddWithValue("@p_engineerid", projectFiles.EngineerID);
            command.Parameters.AddWithValue("@p_managerid", projectFiles.ManagerID);

            dataAccess.ExecuteNonQuery(command);
        }

        public void DeleteProjectFiles(int projectFilesId)
        {
            string query = "CALL DeleteProjectFiles(@p_id)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_id", projectFilesId);

            dataAccess.ExecuteNonQuery(command);
        }

    }

}

