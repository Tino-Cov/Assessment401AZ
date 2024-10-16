﻿using Assessment401AZ.DBOperations;
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

    public partial class EngineersForm : Form
    {
        private EngineersOperations engineerOperations = new EngineersOperations();

        public EngineersForm()
        {

            InitializeComponent();
        }



        private void ADD_Click(object sender, EventArgs e)
        {// Add button functions//
            Engineers newEngineers = new Engineers
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                AddressID = Convert.ToInt32(txtAddressID),
                Dateofbirth = dateTimePickerDOB.Value,
                Tel = Convert.ToInt32(txtTel)
            };

            engineerOperations.AddEngineers(newEngineers);
            LoadEngineerss();
        }


        private void LoadEngineerss()
        {
            dataGridViewEngineers.DataSource = engineerOperations.GetEngineerss();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {// Update button created//
            if (dataGridViewEngineers.SelectedRows.Count > 0)
            {
                Engineers selectedEngineers = GetSelectedRowEngineers();

                if (selectedEngineers != null)
                {
                    selectedEngineers.FirstName = txtFirstName.Text;
                    selectedEngineers.LastName = txtLastName.Text;
                    selectedEngineers.AddressID = Convert.ToInt32(txtAddressID);
                    selectedEngineers.Dateofbirth = dateTimePickerDOB.Value;
                    selectedEngineers.Tel = Convert.ToInt32(txtTel);

                    engineerOperations.UpdateEngineers(selectedEngineers);
                    LoadEngineerss();
                    ClearEngineersFields();
                }
                else
                {
                    MessageBox.Show("Please select a Engineers to update.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Engineers to update.");
            }
        }

        private Engineers GetSelectedRowEngineers()
        {
            if (dataGridViewEngineers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEngineers.SelectedRows[0];
                return new Engineers
                {
                    EngineerID = Convert.ToInt32(selectedRow.Cells["EngineerID"].Value),
                    FirstName = Convert.ToString(selectedRow.Cells["FirstName"].Value),
                    LastName = Convert.ToString(selectedRow.Cells["LastName"].Value),
                    AddressID = Convert.ToInt32(selectedRow.Cells["AddressID"].Value),
                    Dateofbirth = Convert.ToDateTime(selectedRow.Cells["DateofBirth"].Value),
                    Tel = Convert.ToInt32(selectedRow.Cells["Tel"].Value)
                };
            }

            return null;
        }

        private void DELETE_Click(object sender, EventArgs e)
        { // delete row function //
            if (dataGridViewEngineers.SelectedRows.Count > 0)
            {
                int EngineersId = GetSelectedRowEngineersId();

                if (EngineersId != -1)
                {
                    engineerOperations.DeleteEngineers(EngineersId);
                    LoadEngineerss();
                    ClearEngineersFields();
                }
                else
                {
                    MessageBox.Show("Please select a engineer to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Engineers to delete.");
            }
        }

        private int GetSelectedRowEngineersId()
        {
            if (dataGridViewEngineers.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewEngineers.SelectedRows[0].Cells["EngineerID"].Value);
            }

            return -1;
        }

        private void ClearEngineersFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddressID.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            txtTel.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ADD_Click_1(object sender, EventArgs e)
        {//Implementing the Add button//
            Engineers newEngineers = new Engineers
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                AddressID = Convert.ToInt32(txtAddressID),
                Dateofbirth = dateTimePickerDOB.Value,
                Tel = Convert.ToInt32(txtTel)
            };

            engineerOperations.AddEngineers(newEngineers);
            LoadEngineerss();
        }

        private void UPDATE_Click_1(object sender, EventArgs e)
        {//Implementing the Update button//
            if (dataGridViewEngineers.SelectedRows.Count > 0)
            {
                Engineers selectedEngineers = GetSelectedRowEngineers();

                if (selectedEngineers != null)
                {
                    selectedEngineers.FirstName = txtFirstName.Text;
                    selectedEngineers.LastName = txtLastName.Text;
                    selectedEngineers.AddressID = Convert.ToInt32(txtAddressID);
                    selectedEngineers.Dateofbirth = dateTimePickerDOB.Value;
                    selectedEngineers.Tel = Convert.ToInt32(txtTel);

                    engineerOperations.UpdateEngineers(selectedEngineers);
                    LoadEngineerss();
                    ClearEngineersFields();
                }
                else
                {
                    MessageBox.Show("Please select a Engineers to update.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Engineers to update.");
            }
        }

        private void DELETE_Click_1(object sender, EventArgs e)
        {//Implementing the delete button//
            if (dataGridViewEngineers.SelectedRows.Count > 0)
            {
                int EngineersId = GetSelectedRowEngineersId();

                if (EngineersId != -1)
                {
                    engineerOperations.DeleteEngineers(EngineersId);
                    LoadEngineerss();
                    ClearEngineersFields();
                }
                else
                {
                    MessageBox.Show("Please select a engineer to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Engineers to delete.");
            }
        }
    }
}

