using Assessment401AZ.DBOperations;
using Assessment401AZ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment401AZ.GUI
{

    public partial class ProjectManagerForm : Form
    {
        private ProjectManagerOperations projectManagerOperations = new ProjectManagerOperations();

        public ProjectManagerForm()
        {

            InitializeComponent();
        }



        private void ADD_Click(object sender, EventArgs e)
        {
            ProjectManager newProjectManager = new ProjectManager
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                EmailAddress = txtEmailAddress.Text,
                Dateofbirth = dateTimePickerDOB.Value,
                Tel = txtTel.Text
            };

            projectManagerOperations.AddProjectManager(newProjectManager);
            LoadProjectManagers();
        }


        private void LoadProjectManagers()
        {
            dataGridViewProjectManagers.DataSource = projectManagerOperations.GetProjectManagers();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjectManagers.SelectedRows.Count > 0)
            {
                ProjectManager selectedProjectManager = GetSelectedRowProjectManager();

                if (selectedProjectManager != null)
                {
                    selectedProjectManager.FirstName = txtFirstName.Text;
                    selectedProjectManager.LastName = txtLastName.Text;
                    selectedProjectManager.EmailAddress = txtEmailAddress.Text;
                    selectedProjectManager.Dateofbirth = dateTimePickerDOB.Value;
                    selectedProjectManager.Tel = txtTel.Text;

                    projectManagerOperations.UpdateProjectManager(selectedProjectManager);
                    LoadProjectManagers();
                    ClearProjectManagerFields();
                }
                else
                {
                    MessageBox.Show("Please select a ProjectManager to update.");
                }
            }
            else
            {
                MessageBox.Show("Please select a ProjectManager to update.");
            }
        }

        private ProjectManager GetSelectedRowProjectManager()
        {
            if (dataGridViewProjectManagers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProjectManagers.SelectedRows[0];
                return new ProjectManager
                {
                    ManagerID = Convert.ToInt32(selectedRow.Cells["ManagerID"].Value),
                    FirstName = Convert.ToString(selectedRow.Cells["FirstName"].Value),
                    LastName = Convert.ToString(selectedRow.Cells["LastName"].Value),
                    EmailAddress = Convert.ToString(selectedRow.Cells["EmailAddress"].Value),
                    Dateofbirth = Convert.ToDateTime(selectedRow.Cells["DateofBirth"].Value),
                    Tel = Convert.ToInt32(selectedRow.Cells["Tel"].Value)
                };
            }

            return null;
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjectManagers.SelectedRows.Count > 0)
            {
                int ProjectManagerId = GetSelectedRowProjectManagerId();

                if (ProjectManagerId != -1)
                {
                    projectManagerOperations.DeleteProjectManager(ProjectManagerId);
                    LoadProjectManagers();
                    ClearProjectManagerFields();
                }
                else
                {
                    MessageBox.Show("Please select a Projectmanager to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select a ProjectManager to delete.");
            }
        }

        private int GetSelectedRowProjectManagerId()
        {
            if (dataGridViewProjectManagers.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewProjectManagers.SelectedRows[0].Cells["ManagerID"].Value);
            }

            return -1;
        }

        private void ClearProjectManagerFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmailAddress.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            txtTel.Clear();
        }
    }
}
