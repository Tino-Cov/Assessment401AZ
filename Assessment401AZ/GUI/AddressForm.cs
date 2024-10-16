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
    public partial class AddressForm : Form
    {
        private AddressOperations addressOperations = new AddressOperations();
        public AddressForm()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        { // Add button functions//
            Address newAddress = new Address
            {
                Street = txtStreet.Text,
                City = txtCity.Text,
                PostCode = txtPostCode.Text
            };

            addressOperations.AddAddress(newAddress);
            LoadAddresss();
        }


        private void LoadAddresss()
        {
            dataGridViewAddress.DataSource = addressOperations.GetAddress();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        { // Update button created//
            if (dataGridViewAddress.SelectedRows.Count > 0)
            {
                Address selectedAddress = GetSelectedRowAddress();

                if (selectedAddress != null)
                {
                    selectedAddress.Street = txtStreet.Text;
                    selectedAddress.City = txtCity.Text;
                    selectedAddress.PostCode = txtPostCode.Text;

                    addressOperations.UpdateAddress(selectedAddress);
                    LoadAddresss();
                    ClearAddressFields();
                }
                else
                {
                    MessageBox.Show("Please select a Address to update.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Address to update.");
            }
        }

        private Address GetSelectedRowAddress()
        { 
            if (dataGridViewAddress.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewAddress.SelectedRows[0];
                return new Address
                {
                    AddressID = Convert.ToInt32(selectedRow.Cells["AddressID"].Value),
                    Street = Convert.ToString(selectedRow.Cells["Street"].Value),
                    City = Convert.ToString(selectedRow.Cells["City"].Value),
                    PostCode = Convert.ToString(selectedRow.Cells["PostCode"].Value)

                };
            }

            return null;
        }

        private void DELETE_Click(object sender, EventArgs e)
        { // delete row function //
            if (dataGridViewAddress.SelectedRows.Count > 0)
            {
                int AddressId = GetSelectedRowAddressId();

                if (AddressId != -1)
                {
                    addressOperations.DeleteAddress(AddressId);
                    LoadAddresss();
                    ClearAddressFields();
                }
                else
                {
                    MessageBox.Show("Please select a Address to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Address to delete.");
            }
        }

        private void Go_To_EngineersForm_Click(object sender, EventArgs e)
        { //Go to the engineer form button//
            EngineersForm EngineersForm = new EngineersForm();
            EngineersForm.Show();

        }

        private void AddressForm_Load_1(object sender, EventArgs e)
        {
            LoadAddresss();
        }

        private void ClearItemFields()
        {
            txtStreet.Clear();
            txtCity.Clear();
            txtPostCode.Clear();
        }



        private int GetSelectedRowAddressId()
        { 
            if (dataGridViewAddress.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewAddress.SelectedRows[0].Cells["AddressID"].Value);
            }

            return -1;
        }

        private void ClearAddressFields()
        {
            txtStreet.Clear();
            txtCity.Clear();
            txtPostCode.Clear();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ADD_Click_1(object sender, EventArgs e)
        {//Implementing the Add button//
            Address newAddress = new Address
            {
                Street = txtStreet.Text,
                City = txtCity.Text,
                PostCode = txtPostCode.Text
            };

            addressOperations.AddAddress(newAddress);
            LoadAddresss();


        }

        private void UPDATE_Click_1(object sender, EventArgs e)
        { //Implementing the Update button//
            if (dataGridViewAddress.SelectedRows.Count > 0)
            {
                Address selectedAddress = GetSelectedRowAddress();

                if (selectedAddress != null)
                {
                    selectedAddress.Street = txtStreet.Text;
                    selectedAddress.City = txtCity.Text;
                    selectedAddress.PostCode = txtPostCode.Text;

                    addressOperations.UpdateAddress(selectedAddress);
                    LoadAddresss();
                    ClearAddressFields();
                }
                else
                {
                    MessageBox.Show("Please select a Address to update.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Address to update.");
            }
        }

        private void DELETE_Click_1(object sender, EventArgs e)
        {//Implementing the delete button//
            if (dataGridViewAddress.SelectedRows.Count > 0)
            {
                int AddressID = GetSelectedRowAddressId();

                if (AddressID != -1)
                {
                    addressOperations.DeleteAddress(AddressID);
                    LoadAddresss();
                    ClearAddressFields();
                }
                else
                {
                    MessageBox.Show("Please select a Address to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Address to delete.");
            }

        }

        private void GoToEngineersForm_Click(object sender, EventArgs e)
        { // Implemented the Next form code//
            EngineersForm EngineersForm = new EngineersForm();
            EngineersForm.Show();
        }
    }
}
