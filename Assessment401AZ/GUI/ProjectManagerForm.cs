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
                Dateofbirth = dateTimePickerDOB.Value.Date,
                Management = txtManagmement.Text,
                Tel = Convert.ToInt32(txtTel.Text),
                EmailAddress = txtEmailAddress.Text,
            };

            projectManagerOperations.AddProjectManager(newProjectManager);
            LoadProjectManagers();
        }


        private void LoadProjectManagers()
        {
            dataGridViewProjectManager.DataSource = projectManagerOperations.GetProjectManager();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjectManager.SelectedRows.Count > 0)
            {
                ProjectManager selectedProjectManager = GetSelectedRowProjectManager();

                if (selectedProjectManager != null)
                {
                    selectedProjectManager.ManagerID = Convert.ToInt32(TxtManagerID.Text);
                    selectedProjectManager.FirstName = txtFirstName.Text;
                    selectedProjectManager.LastName = txtLastName.Text; 
                    selectedProjectManager.Dateofbirth = dateTimePickerDOB.Value;
                    selectedProjectManager.Management = txtManagmement.Text;
                    selectedProjectManager.Tel = Convert.ToInt32(txtTel.Text);
                    selectedProjectManager.EmailAddress = txtEmailAddress.Text;

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
            if (dataGridViewProjectManager.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProjectManager.SelectedRows[0];
                return new ProjectManager
                {

                    FirstName = Convert.ToString(selectedRow.Cells["FirstName"].Value),
                    LastName = Convert.ToString(selectedRow.Cells["LastName"].Value),
                    Dateofbirth = Convert.ToDateTime(selectedRow.Cells["DateofBirth"].Value),
                    Management = Convert.ToString(selectedRow.Cells["Management"].Value),
                    Tel = Convert.ToInt32(selectedRow.Cells["Tel"].Value),
                    EmailAddress = Convert.ToString(selectedRow.Cells["EmailAddress"].Value)
                };
            }

            return null;
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjectManager.SelectedRows.Count > 0)
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
            if (dataGridViewProjectManager.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewProjectManager.SelectedRows[0].Cells["ManagerID"].Value);
            }

            return -1;
        }

        private void ClearProjectManagerFields()
        {
            TxtManagerID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            txtManagmement.Clear();
            txtTel.Clear();
            txtEmailAddress.Clear();
        }

        private void ADD_Click_1(object sender, EventArgs e)
        {
            ProjectManager newProjectManager = new ProjectManager
            {
                
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Dateofbirth = dateTimePickerDOB.Value,
                Management = txtManagmement.Text,
                Tel = Convert.ToInt32(txtTel.Text),
                EmailAddress = txtEmailAddress.Text,
            };

            projectManagerOperations.AddProjectManager(newProjectManager);
            LoadProjectManagers();
        }

        private void UPDATE_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewProjectManager.SelectedRows.Count > 0)
            {
                ProjectManager selectedProjectManager = GetSelectedRowProjectManager();

                if (selectedProjectManager != null)
                {

                    selectedProjectManager.FirstName = txtFirstName.Text;
                    selectedProjectManager.LastName = txtLastName.Text;
                    selectedProjectManager.Dateofbirth = dateTimePickerDOB.Value;
                    selectedProjectManager.Management = txtManagmement.Text;
                    selectedProjectManager.Tel = Convert.ToInt32(txtTel.Text);
                    selectedProjectManager.EmailAddress = txtEmailAddress.Text;

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

        private void DELETE_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewProjectManager.SelectedRows.Count > 0)
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
    }
}
