namespace Assessment401AZ.GUI
{
    partial class ProjectManagerForm
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
        // named all lables and textboxes needed //
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewProjectManager = new DataGridView();
            labelManagerID = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelEmailAddress = new Label();
            dateTimePickerDOB = new DateTimePicker();
            labelDateofbirth = new Label();
            labelTel = new Label();
            TxtManagerID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtTel = new TextBox();
            txtEmailAddress = new TextBox();
            ADD = new Button();
            UPDATE = new Button();
            DELETE = new Button();
            labelManagement = new Label();
            txtManagmement = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectManager).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProjectManager
            // 
            dataGridViewProjectManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjectManager.Location = new Point(464, 71);
            dataGridViewProjectManager.Name = "dataGridViewProjectManager";
            dataGridViewProjectManager.Size = new Size(558, 269);
            dataGridViewProjectManager.TabIndex = 0;
            // 
            // labelManagerID
            // 
            labelManagerID.AutoSize = true;
            labelManagerID.Location = new Point(41, 71);
            labelManagerID.Name = "labelManagerID";
            labelManagerID.Size = new Size(71, 15);
            labelManagerID.TabIndex = 3;
            labelManagerID.Text = "ManagerID :";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(40, 133);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(67, 15);
            labelFirstName.TabIndex = 4;
            labelFirstName.Text = "FirstName :";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(41, 194);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(66, 15);
            labelLastName.TabIndex = 5;
            labelLastName.Text = "LastName :";
            // 
            // labelEmailAddress
            // 
            labelEmailAddress.AutoSize = true;
            labelEmailAddress.Location = new Point(41, 425);
            labelEmailAddress.Name = "labelEmailAddress";
            labelEmailAddress.Size = new Size(84, 15);
            labelEmailAddress.TabIndex = 6;
            labelEmailAddress.Text = "EmailAddress :";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(168, 249);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(204, 23);
            dateTimePickerDOB.TabIndex = 7;
            // 
            // labelDateofbirth
            // 
            labelDateofbirth.AutoSize = true;
            labelDateofbirth.Location = new Point(41, 257);
            labelDateofbirth.Name = "labelDateofbirth";
            labelDateofbirth.Size = new Size(73, 15);
            labelDateofbirth.TabIndex = 8;
            labelDateofbirth.Text = "Dateofbirth :";
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.Location = new Point(41, 364);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(27, 15);
            labelTel.TabIndex = 9;
            labelTel.Text = "Tel :";
            // 
            // TxtManagerID
            // 
            TxtManagerID.Location = new Point(168, 68);
            TxtManagerID.Name = "TxtManagerID";
            TxtManagerID.Size = new Size(204, 23);
            TxtManagerID.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(168, 130);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(204, 23);
            txtFirstName.TabIndex = 11;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(168, 194);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(204, 23);
            txtLastName.TabIndex = 12;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(168, 356);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(204, 23);
            txtTel.TabIndex = 13;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(168, 417);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(204, 23);
            txtEmailAddress.TabIndex = 14;
            // 
            // ADD
            // 
            ADD.Location = new Point(416, 373);
            ADD.Name = "ADD";
            ADD.Size = new Size(169, 57);
            ADD.TabIndex = 15;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            ADD.Click += ADD_Click_1;
            // 
            // UPDATE
            // 
            UPDATE.Location = new Point(639, 373);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(169, 57);
            UPDATE.TabIndex = 16;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            UPDATE.Click += UPDATE_Click_1;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(843, 373);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(169, 57);
            DELETE.TabIndex = 17;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            DELETE.Click += DELETE_Click_1;
            // 
            // labelManagement
            // 
            labelManagement.AutoSize = true;
            labelManagement.Location = new Point(41, 308);
            labelManagement.Name = "labelManagement";
            labelManagement.Size = new Size(84, 15);
            labelManagement.TabIndex = 18;
            labelManagement.Text = "Management :";
            // 
            // txtManagmement
            // 
            txtManagmement.Location = new Point(168, 305);
            txtManagmement.Name = "txtManagmement";
            txtManagmement.Size = new Size(204, 23);
            txtManagmement.TabIndex = 19;
            // 
            // ProjectManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 567);
            Controls.Add(txtManagmement);
            Controls.Add(labelManagement);
            Controls.Add(DELETE);
            Controls.Add(UPDATE);
            Controls.Add(ADD);
            Controls.Add(txtEmailAddress);
            Controls.Add(txtTel);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(TxtManagerID);
            Controls.Add(labelTel);
            Controls.Add(labelDateofbirth);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(labelEmailAddress);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(labelManagerID);
            Controls.Add(dataGridViewProjectManager);
            Name = "ProjectManagerForm";
            Text = "ProjectManagerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectManager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProjectManager;
        private Label labelManagerID;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelEmailAddress;
        private DateTimePicker dateTimePickerDOB;
        private Label labelDateofbirth;
        private Label labelTel;
        private TextBox TxtManagerID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtTel;
        private TextBox txtEmailAddress;
        private Button ADD;
        private Button UPDATE;
        private Button DELETE;
        private Label labelManagement;
        private TextBox txtManagmement;
    }
}