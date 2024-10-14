
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ADD = new Button();
            Go_To_ProjectAssignment = new Button();
            DELETE = new Button();
            UPDATE = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtManagerID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtTel = new TextBox();
            txtEmailAddress = new TextBox();
            dateTimePickerDOB = new DateTimePicker();
            Go_To_ProjectFiles = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(385, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(617, 273);
            dataGridView1.TabIndex = 0;
            // 
            // ADD
            // 
            ADD.Location = new Point(423, 334);
            ADD.Name = "ADD";
            ADD.Size = new Size(132, 50);
            ADD.TabIndex = 1;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            ADD.Click += ADD_Click;
            // 
            // Go_To_ProjectAssignment
            // 
            Go_To_ProjectAssignment.Location = new Point(498, 425);
            Go_To_ProjectAssignment.Name = "Go_To_ProjectAssignment";
            Go_To_ProjectAssignment.Size = new Size(161, 50);
            Go_To_ProjectAssignment.TabIndex = 2;
            Go_To_ProjectAssignment.Text = "Go to ProjectAssignment";
            Go_To_ProjectAssignment.UseVisualStyleBackColor = true;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(847, 334);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(132, 50);
            DELETE.TabIndex = 3;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            DELETE.Click += DELETE_Click;
            // 
            // UPDATE
            // 
            UPDATE.Location = new Point(637, 334);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(132, 50);
            UPDATE.TabIndex = 4;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            UPDATE.Click += UPDATE_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 74);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 5;
            label1.Text = "ManagerID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 134);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "FirstName :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 187);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 7;
            label3.Text = "LastName :";
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 298);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 8;
            label4.Text = "Tel :";
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 239);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 9;
            label5.Text = "Dateofbirth :";
            
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 352);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 10;
            label6.Text = "EmailAddress :";
            
            // 
            // txtManagerID
            // 
            txtManagerID.Location = new Point(134, 69);
            txtManagerID.Name = "txtManagerID";
            txtManagerID.Size = new Size(200, 23);
            txtManagerID.TabIndex = 11;
            txtManagerID.TextChanged += textBox1_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(134, 123);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 12;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(134, 176);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 13;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(134, 290);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(200, 23);
            txtTel.TabIndex = 14;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(134, 344);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(200, 23);
            txtEmailAddress.TabIndex = 15;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(134, 233);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(200, 23);
            dateTimePickerDOB.TabIndex = 16;
            // 
            // Go_To_ProjectFiles
            // 
            Go_To_ProjectFiles.Location = new Point(737, 425);
            Go_To_ProjectFiles.Name = "Go_To_ProjectFiles";
            Go_To_ProjectFiles.Size = new Size(161, 50);
            Go_To_ProjectFiles.TabIndex = 17;
            Go_To_ProjectFiles.Text = "Go to ProjectFiles ";
            Go_To_ProjectFiles.UseVisualStyleBackColor = true;
            // 
            // ProjectManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 507);
            Controls.Add(Go_To_ProjectFiles);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(txtEmailAddress);
            Controls.Add(txtTel);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtManagerID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UPDATE);
            Controls.Add(DELETE);
            Controls.Add(Go_To_ProjectAssignment);
            Controls.Add(ADD);
            Controls.Add(dataGridView1);
            Name = "ProjectManagerForm";
            Text = "ProjectManagerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button ADD;
        private Button Go_To_ProjectAssignment;
        private Button DELETE;
        private Button UPDATE;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtManagerID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtTel;
        private TextBox txtEmailAddress;
        private DateTimePicker dateTimePickerDOB;
        private Button Go_To_ProjectFiles;
        private EventHandler label4_Click;
        private EventHandler label5_Click;
        private EventHandler label6_Click;
        private EventHandler textBox1_TextChanged;
    }
}