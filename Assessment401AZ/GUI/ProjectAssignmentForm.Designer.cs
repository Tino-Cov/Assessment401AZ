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
            Go_To_ProjectFiles = new Button();
            DELETE = new Button();
            UPDATE = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            dataGridViewProjectAssignment.Location = new Point(444, 30);
            dataGridViewProjectAssignment.Name = "dataGridViewProjectAssignment";
            dataGridViewProjectAssignment.Size = new Size(482, 188);
            dataGridViewProjectAssignment.TabIndex = 0;
            // 
            // ADD
            // 
            ADD.Location = new Point(426, 283);
            ADD.Name = "ADD";
            ADD.Size = new Size(157, 48);
            ADD.TabIndex = 1;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            // 
            // Go_To_ProjectFiles
            // 
            Go_To_ProjectFiles.Location = new Point(616, 363);
            Go_To_ProjectFiles.Name = "Go_To_ProjectFiles";
            Go_To_ProjectFiles.Size = new Size(157, 48);
            Go_To_ProjectFiles.TabIndex = 2;
            Go_To_ProjectFiles.Text = "Go to ProjectFiles";
            Go_To_ProjectFiles.UseVisualStyleBackColor = true;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(803, 283);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(157, 48);
            DELETE.TabIndex = 3;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            // 
            // UPDATE
            // 
            UPDATE.Location = new Point(616, 283);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(157, 48);
            UPDATE.TabIndex = 4;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 92);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 5;
            label1.Text = "ProjectName :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 152);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 6;
            label2.Text = "ProjectID :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 218);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 7;
            label3.Text = "ProjectAddress :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 283);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 8;
            label4.Text = "ManagerID :";
            label4.Click += label4_Click;
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new Point(156, 81);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(126, 23);
            txtProjectName.TabIndex = 9;
            // 
            // txtProjectID
            // 
            txtProjectID.Location = new Point(156, 149);
            txtProjectID.Name = "txtProjectID";
            txtProjectID.Size = new Size(126, 23);
            txtProjectID.TabIndex = 10;
            // 
            // txtProjectAddress
            // 
            txtProjectAddress.Location = new Point(156, 210);
            txtProjectAddress.Name = "txtProjectAddress";
            txtProjectAddress.Size = new Size(126, 23);
            txtProjectAddress.TabIndex = 11;
            // 
            // txtManagerID
            // 
            txtManagerID.Location = new Point(156, 283);
            txtManagerID.Name = "txtManagerID";
            txtManagerID.Size = new Size(126, 23);
            txtManagerID.TabIndex = 12;
            // 
            // ProjectAssignmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 470);
            Controls.Add(txtManagerID);
            Controls.Add(txtProjectAddress);
            Controls.Add(txtProjectID);
            Controls.Add(txtProjectName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UPDATE);
            Controls.Add(DELETE);
            Controls.Add(Go_To_ProjectFiles);
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
        private Button Go_To_ProjectFiles;
        private Button DELETE;
        private Button UPDATE;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProjectName;
        private TextBox txtProjectID;
        private TextBox txtProjectAddress;
        private TextBox txtManagerID;
    }
}