namespace Assessment401AZ.GUI
{
    partial class EngineersForm
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
            dataGridViewEngineers = new DataGridView();
            labelTel = new Label();
            labelAddressID = new Label();
            dateTimePickerDOB = new DateTimePicker();
            labelDOB = new Label();
            labelLastName = new Label();
            labelFirstName = new Label();
            labelEngineerID = new Label();
            txtEngineerID = new TextBox();
            txtTel = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtAddressID = new TextBox();
            ADD = new Button();
            DELETE = new Button();
            UPDATE = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEngineers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEngineers
            // 
            dataGridViewEngineers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEngineers.Location = new Point(473, 33);
            dataGridViewEngineers.Name = "dataGridViewEngineers";
            dataGridViewEngineers.Size = new Size(575, 312);
            dataGridViewEngineers.TabIndex = 0;
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.Location = new Point(53, 349);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(27, 15);
            labelTel.TabIndex = 1;
            labelTel.Text = "Tel :";
            // 
            // labelAddressID
            // 
            labelAddressID.AutoSize = true;
            labelAddressID.Location = new Point(53, 394);
            labelAddressID.Name = "labelAddressID";
            labelAddressID.Size = new Size(66, 15);
            labelAddressID.TabIndex = 2;
            labelAddressID.Text = "AddressID :";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(179, 283);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(217, 23);
            dateTimePickerDOB.TabIndex = 3;
            // 
            // labelDOB
            // 
            labelDOB.AutoSize = true;
            labelDOB.Location = new Point(53, 291);
            labelDOB.Name = "labelDOB";
            labelDOB.Size = new Size(73, 15);
            labelDOB.TabIndex = 4;
            labelDOB.Text = "Dateofbirth :";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(53, 224);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(66, 15);
            labelLastName.TabIndex = 5;
            labelLastName.Text = "LastName :";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(60, 161);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(67, 15);
            labelFirstName.TabIndex = 6;
            labelFirstName.Text = "FirstName :";
            // 
            // labelEngineerID
            // 
            labelEngineerID.AutoSize = true;
            labelEngineerID.Location = new Point(60, 99);
            labelEngineerID.Name = "labelEngineerID";
            labelEngineerID.Size = new Size(70, 15);
            labelEngineerID.TabIndex = 7;
            labelEngineerID.Text = "EngineerID :";
            // 
            // txtEngineerID
            // 
            txtEngineerID.Location = new Point(179, 96);
            txtEngineerID.Name = "txtEngineerID";
            txtEngineerID.Size = new Size(217, 23);
            txtEngineerID.TabIndex = 8;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(179, 341);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(217, 23);
            txtTel.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(179, 216);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(217, 23);
            txtLastName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(179, 153);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(217, 23);
            txtFirstName.TabIndex = 11;
            // 
            // txtAddressID
            // 
            txtAddressID.Location = new Point(179, 394);
            txtAddressID.Name = "txtAddressID";
            txtAddressID.Size = new Size(217, 23);
            txtAddressID.TabIndex = 12;
            // 
            // ADD
            // 
            ADD.Location = new Point(473, 377);
            ADD.Name = "ADD";
            ADD.Size = new Size(157, 48);
            ADD.TabIndex = 13;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(891, 377);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(157, 48);
            DELETE.TabIndex = 14;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            // 
            // UPDATE
            // 
            UPDATE.Location = new Point(678, 377);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(157, 48);
            UPDATE.TabIndex = 15;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            // 
            // EngineersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 535);
            Controls.Add(UPDATE);
            Controls.Add(DELETE);
            Controls.Add(ADD);
            Controls.Add(txtAddressID);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtTel);
            Controls.Add(txtEngineerID);
            Controls.Add(labelEngineerID);
            Controls.Add(labelFirstName);
            Controls.Add(labelLastName);
            Controls.Add(labelDOB);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(labelAddressID);
            Controls.Add(labelTel);
            Controls.Add(dataGridViewEngineers);
            Name = "EngineersForm";
            Text = "EngineersForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEngineers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEngineers;
        private Label labelTel;
        private Label labelAddressID;
        private DateTimePicker dateTimePickerDOB;
        private Label labelDOB;
        private Label labelLastName;
        private Label labelFirstName;
        private Label labelEngineerID;
        private TextBox txtEngineerID;
        private TextBox txtTel;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtAddressID;
        private Button ADD;
        private Button DELETE;
        private Button UPDATE;
    }
}