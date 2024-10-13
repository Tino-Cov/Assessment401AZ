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
            ADD = new Button();
            UPDATE = new Button();
            DELETE = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dateTimePickerDOB = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEngineers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEngineers
            // 
            dataGridViewEngineers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEngineers.Location = new Point(342, 86);
            dataGridViewEngineers.Name = "dataGridViewEngineers";
            dataGridViewEngineers.Size = new Size(421, 188);
            dataGridViewEngineers.TabIndex = 0;
            dataGridViewEngineers.CellContentClick += this.dataGridViewEngineers_CellContentClick;
            // 
            // ADD
            // 
            ADD.Location = new Point(342, 311);
            ADD.Name = "ADD";
            ADD.Size = new Size(124, 46);
            ADD.TabIndex = 1;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            ADD.Click += this.button1_Click;
            // 
            // UPDATE
            // 
            UPDATE.Location = new Point(487, 311);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(124, 46);
            UPDATE.TabIndex = 2;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            UPDATE.Click += this.button2_Click;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(639, 311);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(124, 46);
            DELETE.TabIndex = 2;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            DELETE.Click += this.button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 78);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "EngineerID :";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 115);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "FirstName :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 158);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Lastname :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 203);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 6;
            label4.Text = "Dateofbirth :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 250);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 7;
            label5.Text = "Tel :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 295);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 8;
            label6.Text = "AddressID :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(127, 250);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(156, 23);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(127, 295);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(156, 23);
            textBox5.TabIndex = 13;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(128, 203);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(159, 23);
            dateTimePickerDOB.TabIndex = 14;
            // 
            // EngineersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DELETE);
            Controls.Add(UPDATE);
            Controls.Add(ADD);
            Controls.Add(dataGridViewEngineers);
            Name = "EngineersForm";
            Text = "EngineersForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEngineers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEngineers;
        private Button ADD;
        private Button UPDATE;
        private Button DELETE;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DateTimePicker dateTimePickerDOB;
    }
}