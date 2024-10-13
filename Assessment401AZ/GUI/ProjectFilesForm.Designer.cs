namespace Assessment401AZ.GUI
{
    partial class ProjectFilesForm
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
            dataGridViewProjectFiles = new DataGridView();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            ADD = new Button();
            Go_To_ProjectAssignment = new Button();
            DELETE = new Button();
            UPDATE = new Button();
            txtProjectID = new TextBox();
            txtProjectAddress = new TextBox();
            txtEngineerID = new TextBox();
            txtManagerID = new TextBox();
            txtManagerID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectFiles).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProjectFiles
            // 
            dataGridViewProjectFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjectFiles.Location = new Point(489, 49);
            dataGridViewProjectFiles.Name = "dataGridViewProjectFiles";
            dataGridViewProjectFiles.Size = new Size(476, 219);
            dataGridViewProjectFiles.TabIndex = 0;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(265, 148);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(128, 23);
            dateTimePickerStart.TabIndex = 1;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(265, 198);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(128, 23);
            dateTimePickerEnd.TabIndex = 2;
            // 
            // ADD
            // 
            ADD.Location = new Point(513, 307);
            ADD.Name = "ADD";
            ADD.Size = new Size(119, 38);
            ADD.TabIndex = 3;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            // 
            // Go_To_ProjectAssignment
            // 
            Go_To_ProjectAssignment.Location = new Point(674, 383);
            Go_To_ProjectAssignment.Name = "Go_To_ProjectAssignment";
            Go_To_ProjectAssignment.Size = new Size(119, 38);
            Go_To_ProjectAssignment.TabIndex = 4;
            Go_To_ProjectAssignment.Text = "Go to ProjectAssignment";
            Go_To_ProjectAssignment.UseVisualStyleBackColor = true;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(826, 307);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(119, 38);
            DELETE.TabIndex = 5;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            // 
            // UPDATE
            // 
            UPDATE.Location = new Point(674, 307);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(119, 38);
            UPDATE.TabIndex = 6;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            // 
            // txtProjectID
            // 
            txtProjectID.Location = new Point(265, 49);
            txtProjectID.Name = "txtProjectID";
            txtProjectID.Size = new Size(128, 23);
            txtProjectID.TabIndex = 7;
            // 
            // txtProjectAddress
            // 
            txtProjectAddress.Location = new Point(265, 250);
            txtProjectAddress.Name = "txtProjectAddress";
            txtProjectAddress.Size = new Size(128, 23);
            txtProjectAddress.TabIndex = 8;
            // 
            // txtEngineerID
            // 
            txtEngineerID.Location = new Point(265, 294);
            txtEngineerID.Name = "txtEngineerID";
            txtEngineerID.Size = new Size(128, 23);
            txtEngineerID.TabIndex = 9;
            // 
            // txtProjectName
            // 
            txtManagerID.Location = new Point(265, 99);
            txtManagerID.Name = "txtProjectName";
            txtManagerID.Size = new Size(128, 23);
            txtManagerID.TabIndex = 10;
            // 
            // txtManagerID
            // 
            txtManagerID.Location = new Point(265, 346);
            txtManagerID.Name = "txtManagerID";
            txtManagerID.Size = new Size(128, 23);
            txtManagerID.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 55);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 12;
            label1.Text = "ProjectID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 107);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 13;
            label2.Text = "ProjectName :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 156);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 14;
            label3.Text = "ProjectStartDate :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 206);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 15;
            label4.Text = "ProjectEndDate :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 258);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 16;
            label5.Text = "ProjectAddress :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 302);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 17;
            label6.Text = "EngineerID :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 346);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 18;
            label7.Text = "ManagerID :";
            // 
            // ProjectFilesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 515);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtManagerID);
            Controls.Add(txtManagerID);
            Controls.Add(txtEngineerID);
            Controls.Add(txtProjectAddress);
            Controls.Add(txtProjectID);
            Controls.Add(UPDATE);
            Controls.Add(DELETE);
            Controls.Add(Go_To_ProjectAssignment);
            Controls.Add(ADD);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dataGridViewProjectFiles);
            Name = "ProjectFilesForm";
            Text = "ProjectFilesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectFiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProjectFiles;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Button ADD;
        private Button Go_To_ProjectAssignment;
        private Button DELETE;
        private Button UPDATE;
        private TextBox txtProjectID;
        private TextBox txtProjectAddress;
        private TextBox txtEngineerID;
        private TextBox txtManagerID;
        private TextBox txtManagerID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}