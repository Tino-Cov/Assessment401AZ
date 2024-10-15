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
            labelProjectID = new Label();
            labelProjectAddress = new Label();
            labelManagerID = new Label();
            labelProjectEnd = new Label();
            labelProjectStart = new Label();
            labelProjectName = new Label();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            txtProjectID = new TextBox();
            txtManagerID = new TextBox();
            txtProjectAddress = new TextBox();
            txtProjectName = new TextBox();
            ADD = new Button();
            DELETE = new Button();
            UPDATE = new Button();
            Go_To_ProjectAssignment = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectFiles).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProjectFiles
            // 
            dataGridViewProjectFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjectFiles.Location = new Point(373, 35);
            dataGridViewProjectFiles.Name = "dataGridViewProjectFiles";
            dataGridViewProjectFiles.Size = new Size(607, 267);
            dataGridViewProjectFiles.TabIndex = 0;
            // 
            // labelProjectID
            // 
            labelProjectID.AutoSize = true;
            labelProjectID.Location = new Point(46, 63);
            labelProjectID.Name = "labelProjectID";
            labelProjectID.Size = new Size(61, 15);
            labelProjectID.TabIndex = 1;
            labelProjectID.Text = "ProjectID :";
            // 
            // labelProjectAddress
            // 
            labelProjectAddress.AutoSize = true;
            labelProjectAddress.Location = new Point(46, 249);
            labelProjectAddress.Name = "labelProjectAddress";
            labelProjectAddress.Size = new Size(92, 15);
            labelProjectAddress.TabIndex = 2;
            labelProjectAddress.Text = "ProjectAddress :";
            // 
            // labelManagerID
            // 
            labelManagerID.AutoSize = true;
            labelManagerID.Location = new Point(46, 346);
            labelManagerID.Name = "labelManagerID";
            labelManagerID.Size = new Size(71, 15);
            labelManagerID.TabIndex = 4;
            labelManagerID.Text = "ManagerID :";
            // 
            // labelProjectEnd
            // 
            labelProjectEnd.AutoSize = true;
            labelProjectEnd.Location = new Point(46, 201);
            labelProjectEnd.Name = "labelProjectEnd";
            labelProjectEnd.Size = new Size(70, 15);
            labelProjectEnd.TabIndex = 5;
            labelProjectEnd.Text = "ProjectEnd :";
            // 
            // labelProjectStart
            // 
            labelProjectStart.AutoSize = true;
            labelProjectStart.Location = new Point(46, 153);
            labelProjectStart.Name = "labelProjectStart";
            labelProjectStart.Size = new Size(74, 15);
            labelProjectStart.TabIndex = 6;
            labelProjectStart.Text = "ProjectStart :";
            // 
            // labelProjectName
            // 
            labelProjectName.AutoSize = true;
            labelProjectName.Location = new Point(46, 105);
            labelProjectName.Name = "labelProjectName";
            labelProjectName.Size = new Size(82, 15);
            labelProjectName.TabIndex = 7;
            labelProjectName.Text = "ProjectName :";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(145, 149);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 8;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(145, 195);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 9;
            // 
            // txtProjectID
            // 
            txtProjectID.Location = new Point(145, 60);
            txtProjectID.Name = "txtProjectID";
            txtProjectID.Size = new Size(200, 23);
            txtProjectID.TabIndex = 10;
            // 
            // txtManagerID
            // 
            txtManagerID.Location = new Point(145, 343);
            txtManagerID.Name = "txtManagerID";
            txtManagerID.Size = new Size(200, 23);
            txtManagerID.TabIndex = 11;
            // 
            // txtProjectAddress
            // 
            txtProjectAddress.Location = new Point(145, 246);
            txtProjectAddress.Name = "txtProjectAddress";
            txtProjectAddress.Size = new Size(200, 23);
            txtProjectAddress.TabIndex = 13;
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new Point(145, 102);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(200, 23);
            txtProjectName.TabIndex = 14;
            // 
            // ADD
            // 
            ADD.Location = new Point(373, 343);
            ADD.Name = "ADD";
            ADD.Size = new Size(157, 45);
            ADD.TabIndex = 15;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            ADD.Click += ADD_Click_1;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(823, 347);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(157, 45);
            DELETE.TabIndex = 16;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            // 
            // UPDATE
            // 
            UPDATE.Location = new Point(595, 347);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(157, 45);
            UPDATE.TabIndex = 17;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            UPDATE.Click += UPDATE_Click_1;
            // 
            // Go_To_ProjectAssignment
            // 
            Go_To_ProjectAssignment.Location = new Point(595, 443);
            Go_To_ProjectAssignment.Name = "Go_To_ProjectAssignment";
            Go_To_ProjectAssignment.Size = new Size(157, 45);
            Go_To_ProjectAssignment.TabIndex = 18;
            Go_To_ProjectAssignment.Text = "Go to ProjectAssignment";
            Go_To_ProjectAssignment.UseVisualStyleBackColor = true;
            // 
            // ProjectFilesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 529);
            Controls.Add(Go_To_ProjectAssignment);
            Controls.Add(UPDATE);
            Controls.Add(DELETE);
            Controls.Add(ADD);
            Controls.Add(txtProjectName);
            Controls.Add(txtProjectAddress);
            Controls.Add(txtManagerID);
            Controls.Add(txtProjectID);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(labelProjectName);
            Controls.Add(labelProjectStart);
            Controls.Add(labelProjectEnd);
            Controls.Add(labelManagerID);
            Controls.Add(labelProjectAddress);
            Controls.Add(labelProjectID);
            Controls.Add(dataGridViewProjectFiles);
            Name = "ProjectFilesForm";
            Text = "ProjectFilesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectFiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProjectFiles;
        private Label labelProjectID;
        private Label labelProjectAddress;
        private Label labelManagerID;
        private Label labelProjectEnd;
        private Label labelProjectStart;
        private Label labelProjectName;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private TextBox txtProjectID;
        private TextBox txtManagerID;
        private TextBox txtProjectAddress;
        private TextBox txtProjectName;
        private Button ADD;
        private Button DELETE;
        private Button UPDATE;
        private Button Go_To_ProjectAssignment;
    }
}