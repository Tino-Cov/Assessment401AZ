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
    public partial class ProjectFilesForm : Form
    {
        private ProjectFilesOperations projectFilesOperations = new ProjectFilesOperations();
        public ProjectFilesForm()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            ProjectFiles newProjectFiles = new ProjectFiles
            {
                ProjectName = txtProjectName.Text,
                ProjectStart = dateTimePickerStart.Value,
                ProjectEnd = dateTimePickerEnd.Value,
                ManagerID = Convert.ToInt32(txtManagerID)
            };

            projectFilesOperations.AddProjectFiles(newProjectFiles);
            LoadProjectFiless();
        }


        private void LoadProjectFiless()
        {
            dataGridViewProjectFiles.DataSource = projectFilesOperations.GetProjectFiles();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjectFiles.SelectedRows.Count > 0)
            {
                ProjectFiles selectedProjectFiles = GetSelectedRowProjectFiles();

                if (selectedProjectFiles != null)
                {
                    selectedProjectFiles.ProjectName = txtProjectName.Text;
                    selectedProjectFiles.ProjectStart = dateTimePickerStart.Value;
                    selectedProjectFiles.ProjectEnd = dateTimePickerEnd.Value;
                    selectedProjectFiles.ManagerID = Convert.ToInt32(txtManagerID);

                    projectFilesOperations.UpdateProjectFiles(selectedProjectFiles);
                    LoadProjectFiless();
                    ClearProjectFilesFields();
                }
                else
                {
                    MessageBox.Show("Please select a ProjectFiles to update.");
                }
            }
            else
            {
                MessageBox.Show("Please select a ProjectFiles to update.");
            }
        }

        private ProjectFiles GetSelectedRowProjectFiles()
        {
            if (dataGridViewProjectFiles.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProjectFiles.SelectedRows[0];
                return new ProjectFiles
                {
                    ProjectID = Convert.ToInt32(selectedRow.Cells["ProjectID"].Value),
                    ProjectStart = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value),
                    ProjectEnd = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value),
                    ManagerID = Convert.ToInt32(selectedRow.Cells["ProjectID"].Value),

                };
            }

            return null;
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjectFiles.SelectedRows.Count > 0)
            {
                int ProjectFilesId = GetSelectedRowProjectFilesId();

                if (ProjectFilesId != -1)
                {
                    projectFilesOperations.DeleteProjectFiles(ProjectFilesId);
                    LoadProjectFiless();
                    ClearProjectFilesFields();
                }
                else
                {
                    MessageBox.Show("Please select a ProjectFiles to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select a ProjectFiles to delete.");
            }
        }

        private void Go_To_ProjectAssignment_Click(object sender, EventArgs e)
        {
            EngineersForm EngineersForm = new EngineersForm();
            EngineersForm.Show();

        }

        private void ProjectFilesForm_Load_1(object sender, EventArgs e)
        {
            LoadProjectFiless();
        }

        private void ClearItemFields()
        {
            txtProjectName.Clear();
            dateTimePickerStart.Text = "";
            dateTimePickerEnd.Text = "";
            txtManagerID.Clear();
        }



        private int GetSelectedRowProjectFilesId()
        {
            if (dataGridViewProjectFiles.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewProjectFiles.SelectedRows[0].Cells["ProjectFilesID"].Value);
            }

            return -1;
        }

        private void ClearProjectFilesFields()
        {
            txtProjectName.Clear();
            dateTimePickerStart.Text = "";
            dateTimePickerEnd.Text = "";
            txtManagerID.Clear();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
