namespace Assessment401AZ.GUI
{
    partial class ProjectAssignmentForm
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
            dataGridViewProjectAssignment = new DataGridView();
            ADD = new Button();
            UPDATE = new Button();
            Go_To_ProjectFiles = new Button();
            DELETE = new Button();
            labelProjectName = new Label();
            labelProjectID = new Label();
            labelProjectAddress = new Label();
            labelManagerID = new Label();
            txtProjectName = new TextBox();
            txtProjectID = new TextBox();
            txtProjectAddress = new TextBox();
            txtManagerID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectAssignment).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProjectAssignment
            // 
            dataGridViewProjectAssignment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjectAssignment.Location = new Point(416, 37);
            dataGridViewProjectAssignment.Name = "dataGridViewProjectAssignment";
            dataGridViewProjectAssignment.Size = new Size(608, 219);
            dataGridViewProjectAssignment.TabIndex = 0;
            // 
            // ADD
            // 
            ADD.Location = new Point(426, 306);
            ADD.Name = "ADD";
            ADD.Size = new Size(151, 45);
            ADD.TabIndex = 1;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            // 
            // UPDATE
            // 
            UPDATE.Location = new Point(649, 306);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(151, 45);
            UPDATE.TabIndex = 2;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            // 
            // Go_To_ProjectFiles
            // 
            Go_To_ProjectFiles.Location = new Point(670, 403);
            Go_To_ProjectFiles.Name = "Go_To_ProjectFiles";
            Go_To_ProjectFiles.Size = new Size(151, 45);
            Go_To_ProjectFiles.TabIndex = 3;
            Go_To_ProjectFiles.Text = "Go to ProjectFiles";
            Go_To_ProjectFiles.UseVisualStyleBackColor = true;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(844, 306);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(151, 45);
            DELETE.TabIndex = 4;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            // 
            // labelProjectName
            // 
            labelProjectName.AutoSize = true;
            labelProjectName.Location = new Point(15, 79);
            labelProjectName.Name = "labelProjectName";
            labelProjectName.Size = new Size(82, 15);
            labelProjectName.TabIndex = 5;
            labelProjectName.Text = "ProjectName :";
            // 
            // labelProjectID
            // 
            labelProjectID.AutoSize = true;
            labelProjectID.Location = new Point(15, 135);
            labelProjectID.Name = "labelProjectID";
            labelProjectID.Size = new Size(61, 15);
            labelProjectID.TabIndex = 6;
            labelProjectID.Text = "ProjectID :";
            // 
            // labelProjectAddress
            // 
            labelProjectAddress.AutoSize = true;
            labelProjectAddress.Location = new Point(15, 191);
            labelProjectAddress.Name = "labelProjectAddress";
            labelProjectAddress.Size = new Size(92, 15);
            labelProjectAddress.TabIndex = 7;
            labelProjectAddress.Text = "ProjectAddress :";
            // 
            // labelManagerID
            // 
            labelManagerID.AutoSize = true;
            labelManagerID.Location = new Point(15, 241);
            labelManagerID.Name = "labelManagerID";
            labelManagerID.Size = new Size(71, 15);
            labelManagerID.TabIndex = 8;
            labelManagerID.Text = "ManagerID :";
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new Point(168, 67);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(170, 23);
            txtProjectName.TabIndex = 9;
            // 
            // txtProjectID
            // 
            txtProjectID.Location = new Point(168, 127);
            txtProjectID.Name = "txtProjectID";
            txtProjectID.Size = new Size(170, 23);
            txtProjectID.TabIndex = 10;
            // 
            // txtProjectAddress
            // 
            txtProjectAddress.Location = new Point(168, 188);
            txtProjectAddress.Name = "txtProjectAddress";
            txtProjectAddress.Size = new Size(170, 23);
            txtProjectAddress.TabIndex = 11;
            // 
            // txtManagerID
            // 
            txtManagerID.Location = new Point(168, 237);
            txtManagerID.Name = "txtManagerID";
            txtManagerID.Size = new Size(170, 23);
            txtManagerID.TabIndex = 12;
            // 
            // ProjectAssignmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 496);
            Controls.Add(txtManagerID);
            Controls.Add(txtProjectAddress);
            Controls.Add(txtProjectID);
            Controls.Add(txtProjectName);
            Controls.Add(labelManagerID);
            Controls.Add(labelProjectAddress);
            Controls.Add(labelProjectID);
            Controls.Add(labelProjectName);
            Controls.Add(DELETE);
            Controls.Add(Go_To_ProjectFiles);
            Controls.Add(UPDATE);
            Controls.Add(ADD);
            Controls.Add(dataGridViewProjectAssignment);
            Name = "ProjectAssignmentForm";
            Text = "ProjectAssignmentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectAssignment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProjectAssignment;
        private Button ADD;
        private Button UPDATE;
        private Button Go_To_ProjectFiles;
        private Button DELETE;
        private Label labelProjectName;
        private Label labelProjectID;
        private Label labelProjectAddress;
        private Label labelManagerID;
        private TextBox txtProjectName;
        private TextBox txtProjectID;
        private TextBox txtProjectAddress;
        private TextBox txtManagerID;
    }
}