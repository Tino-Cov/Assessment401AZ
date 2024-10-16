﻿using MySql.Data.MySqlClient;
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
    {//creating operations//
        private readonly DataAccess dataAccess = new DataAccess();

        public void AddProjectAssignment(Models.ProjectAssignment projectAssignment)
        {//adding ProjectAssignment variables //
            string query = "CALL AddProjectAssignment(@p_projectid, @p_ProjectManagerList @p_projectaddress, @p_managerid)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_ProjectManagerList", projectAssignment.ProjectManagerList);
            command.Parameters.AddWithValue("@projectid", projectAssignment.ProjectID);
            command.Parameters.AddWithValue("@p_projectaddress", projectAssignment.ProjectAddress);


            dataAccess.ExecuteNonQuery(command);
        }

        public DataTable GetProjectAssignments()
        {
            string query = "CALL GetProjectAssignments()";
            return dataAccess.ExecuteQuery(query);
        }

        public void UpdateProjectAssignment(Models.ProjectAssignment projectAssignment)
        {//created update function for gui//
            string query = "CALL UpdateProjectAssignment(@p_projectname, @p_ProjectManagerList, @projectid, @p_projectaddress)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_projectname", projectAssignment.ProjectName);
            command.Parameters.AddWithValue("@p_ProjectManagerList", projectAssignment.ProjectManagerList);
            command.Parameters.AddWithValue("@p_projectid", projectAssignment.ProjectID);
            command.Parameters.AddWithValue("@p_projectaddress", projectAssignment.ProjectAddress);


            dataAccess.ExecuteNonQuery(command);
        }

        public void DeleteProjectAssignment(int projectAssignmentname)
        { // delete function //
            string query = "CALL DeleteProjectAssignment(@p_name)";
            MySqlCommand command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@p_name", projectAssignmentname);

            dataAccess.ExecuteNonQuery(command);
        }

    }

}
