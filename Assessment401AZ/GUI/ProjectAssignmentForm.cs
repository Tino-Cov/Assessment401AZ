using Assessment401AZ.DBOperations;
using Assessment401AZ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment401AZ.GUI
{
    public partial class ProjectAssignmentForm : Form
    {
        private ProjectAssignmentOperationns projectAssignmentOperationns = new ProjectAssignmentOperationns();
        public ProjectAssignmentForm()
        {
            InitializeComponent();
        }
        private void ADD_Click(object sender, EventArgs e)
        {
            ProjectAssignment newProjectAssignment = new ProjectAssignment
            {
                ProjectManagerList = txtProjectManagerList.Text,
                ProjectID = Convert.ToInt32(txtProjectID),
                ProjectAddress = txtProjectAddress.Text,
               
            };

            projectAssignmentOperationns.AddProjectAssignment(newProjectAssignment);
            LoadProjectAssignments();
        }


        private void LoadProjectAssignments()
        {
            dataGridViewProjectAssignment.DataSource = projectAssignmentOperationns.GetProjectAssignments();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjectAssignment.SelectedRows.Count > 0)
            {
                ProjectAssignment selectedProjectAssignment = GetSelectedRowProjectAssignment();

                if (selectedProjectAssignment != null)
                {
                    selectedProjectAssignment.ProjectName = Convert.ToInt32(txtProjectName);
                    selectedProjectAssignment.ProjectID = Convert.ToInt32(txtProjectID);
                    selectedProjectAssignment.ProjectAddress = txtProjectAddress.Text;
                    selectedProjectAssignment.ProjectManagerList = txtProjectManagerList.Text;

                    projectAssignmentOperationns.UpdateProjectAssignment(selectedProjectAssignment);
                    LoadProjectAssignments();
                    ClearProjectAssignmentFields();
                }
                else
                {
                    MessageBox.Show("Please select a ProjectAssignment to update.");
                }
            }
            else
            {
                MessageBox.Show("Please select a ProjectAssignment to update.");
            }
        }

        private ProjectAssignment GetSelectedRowProjectAssignment()
        {
            if (dataGridViewProjectAssignment.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProjectAssignment.SelectedRows[0];
                return new ProjectAssignment
                {
                    ProjectName = Convert.ToInt32(selectedRow.Cells["ProjectName"].Value),
                    ProjectManagerList = Convert.ToString(selectedRow.Cells["ProjectManagerList"].Value),
                    ProjectID = Convert.ToInt32(selectedRow.Cells["ProjectID"].Value),
                    ProjectAddress = Convert.ToString(selectedRow.Cells["ProjectAddress"].Value),
                   

                };
            }

            return null;
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjectAssignment.SelectedRows.Count > 0)
            {
                int ProjectAssignmentId = GetSelectedRowProjectAssignmentId();

                if (ProjectAssignmentId != -1)
                {
                    projectAssignmentOperationns.DeleteProjectAssignment(ProjectAssignmentId);
                    LoadProjectAssignments();
                    ClearProjectAssignmentFields();
                }
                else
                {
                    MessageBox.Show("Please select a ProjectAssignment to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select a ProjectAssignment to delete.");
            }
        }

        private void Go_To_ProjectFiles_Click(object sender, EventArgs e)
        {
            EngineersForm EngineersForm = new EngineersForm();
            EngineersForm.Show();

        }

        private void ProjectAssignmentForm_Load_1(object sender, EventArgs e)
        {
            LoadProjectAssignments();
        }

        private void ClearItemFields()
        {
            txtProjectName.Clear();
            txtProjectAddress.Clear();
            txtProjectManagerList.Clear();
        }



        private int GetSelectedRowProjectAssignmentId()
        {
            if (dataGridViewProjectAssignment.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewProjectAssignment.SelectedRows[0].Cells["ProjectName"].Value);
            }

            return -1;
        }

        private void ClearProjectAssignmentFields()
        {
            txtProjectName.Clear();
            txtProjectAddress.Clear();
            txtProjectManagerList.Clear();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ADD_Click_1(object sender, EventArgs e)
        {

        }
    }
}
