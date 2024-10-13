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
    public class ProjectAssignmentOperationns
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public void AddProjectAssignment(Models.ProjectAssignment projectAssignment)
        {
            string query = "CALL AddProjectAssignment(@p_projectid, @p_projectaddress, @p_managerid)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@projectid", projectAssignment.ProjectID);
            command.Parameters.AddWithValue("@p_projectaddress", projectAssignment.ProjectAddress);
            command.Parameters.AddWithValue("@p_managerid", projectAssignment.ManagerID);

            dataAccess.ExecuteNonQuery(command);
        }

        public DataTable GetProjectAssignments()
        {
            string query = "CALL GetProjectAssignments()";
            return dataAccess.ExecuteQuery(query);
        }

        public void UpdateProjectAssignment(Models.ProjectAssignment projectAssignment)
        {
            string query = "CALL UpdateProjectAssignment(@p_projectname, @projectid, @p_projectaddress, @p_managerid)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_name", projectAssignment.ProjectName);
            command.Parameters.AddWithValue("@p_projectid", projectAssignment.ProjectID);
            command.Parameters.AddWithValue("@p_projectaddress", projectAssignment.ProjectAddress);
            command.Parameters.AddWithValue("@p_managerid", projectAssignment.ManagerID);

            dataAccess.ExecuteNonQuery(command);
        }

        public void DeleteProjectAssignment(int projectAssignmentname)
        {
            string query = "CALL DeleteProjectAssignment(@p_name)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_name", projectAssignmentname);

            dataAccess.ExecuteNonQuery(command);
        }

    }

}
