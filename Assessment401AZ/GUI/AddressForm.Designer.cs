namespace Assessment401AZ.GUI
{
    partial class AddressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewAddress = new DataGridView();
            ADD = new Button();
            GoToEngineersForm = new Button();
            DELETE = new Button();
            UPDATE = new Button();
            labelAddressID = new Label();
            labelStreet = new Label();
            labelPostCode = new Label();
            labelCity = new Label();
            txtAddressID = new TextBox();
            txtStreet = new TextBox();
            txtCity = new TextBox();
            txtPostCode = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddress).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAddress
            // 
            dataGridViewAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAddress.Location = new Point(504, 24);
            dataGridViewAddress.Name = "dataGridViewAddress";
            dataGridViewAddress.Size = new Size(486, 284);
            dataGridViewAddress.TabIndex = 0;
            // 
            // ADD
            // 
            ADD.Location = new Point(444, 328);
            ADD.Name = "ADD";
            ADD.Size = new Size(170, 62);
            ADD.TabIndex = 1;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            // 
            // GoToEngineersForm
            // 
            GoToEngineersForm.Location = new Point(671, 414);
            GoToEngineersForm.Name = "GoToEngineersForm";
            GoToEngineersForm.Size = new Size(170, 62);
            GoToEngineersForm.TabIndex = 2;
            GoToEngineersForm.Text = "Go to EngineersForm";
            GoToEngineersForm.UseVisualStyleBackColor = true;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(881, 328);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(170, 62);
            DELETE.TabIndex = 3;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            // 
            // UPDATE
            // 
            UPDATE.Location = new Point(671, 328);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(170, 62);
            UPDATE.TabIndex = 4;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            // 
            // labelAddressID
            // 
            labelAddressID.AutoSize = true;
            labelAddressID.Location = new Point(95, 99);
            labelAddressID.Name = "labelAddressID";
            labelAddressID.Size = new Size(66, 15);
            labelAddressID.TabIndex = 5;
            labelAddressID.Text = "AddressID :";
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Location = new Point(95, 152);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(43, 15);
            labelStreet.TabIndex = 6;
            labelStreet.Text = "Street :";
            // 
            // labelPostCode
            // 
            labelPostCode.AutoSize = true;
            labelPostCode.Location = new Point(95, 260);
            labelPostCode.Name = "labelPostCode";
            labelPostCode.Size = new Size(64, 15);
            labelPostCode.TabIndex = 7;
            labelPostCode.Text = "PostCode :";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(95, 204);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(34, 15);
            labelCity.TabIndex = 8;
            labelCity.Text = "City :";
            // 
            // txtAddressID
            // 
            txtAddressID.Location = new Point(223, 92);
            txtAddressID.Name = "txtAddressID";
            txtAddressID.Size = new Size(209, 23);
            txtAddressID.TabIndex = 9;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(223, 144);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(209, 23);
            txtStreet.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(223, 196);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(209, 23);
            txtCity.TabIndex = 11;
            // 
            // txtPostCode
            // 
            txtPostCode.Location = new Point(223, 251);
            txtPostCode.Name = "txtPostCode";
            txtPostCode.Size = new Size(209, 23);
            txtPostCode.TabIndex = 12;
            // 
            // AddressForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 508);
            Controls.Add(txtPostCode);
            Controls.Add(txtCity);
            Controls.Add(txtStreet);
            Controls.Add(txtAddressID);
            Controls.Add(labelCity);
            Controls.Add(labelPostCode);
            Controls.Add(labelStreet);
            Controls.Add(labelAddressID);
            Controls.Add(UPDATE);
            Controls.Add(DELETE);
            Controls.Add(GoToEngineersForm);
            Controls.Add(ADD);
            Controls.Add(dataGridViewAddress);
            Name = "AddressForm";
            Text = "AddressForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAddress;
        private Button ADD;
        private Button GoToEngineersForm;
        private Button DELETE;
        private Button UPDATE;
        private Label labelAddressID;
        private Label labelStreet;
        private Label labelPostCode;
        private Label labelCity;
        private TextBox txtAddressID;
        private TextBox txtStreet;
        private TextBox txtCity;
        private TextBox txtPostCode;
    }
}