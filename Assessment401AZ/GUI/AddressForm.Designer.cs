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

        private void InitializeComponent()
        {
            InitializeComponent(dataGridViewAddress);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(DataGridView dataGridViewAddress)
        {
            dataGridViewAddress = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAddressID = new TextBox();
            txtStreet = new TextBox();
            txtCity = new TextBox();
            txtPostCode = new TextBox();
            ADD = new Button();
            DELETE = new Button();
            UPDATE = new Button();
            GoToEngineersForm = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddress).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAddress
            // 
            dataGridViewAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAddress.Location = new Point(367, 53);
            dataGridViewAddress.Name = "dataGridViewAddress";
            dataGridViewAddress.Size = new Size(371, 163);
            dataGridViewAddress.TabIndex = 0;
            dataGridViewAddress.CellContentClick += dataGridViewAddress_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 98);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "AddressID : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 140);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Street :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 178);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 3;
            label3.Text = "City :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 218);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 4;
            label4.Text = "PostCode :";
            // 
            // txtAddressID
            // 
            txtAddressID.Location = new Point(150, 95);
            txtAddressID.Name = "txtAddressID";
            txtAddressID.Size = new Size(133, 23);
            txtAddressID.TabIndex = 5;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(150, 137);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(133, 23);
            txtStreet.TabIndex = 6;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(150, 175);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(133, 23);
            txtCity.TabIndex = 7;
            // 
            // txtPostCode
            // 
            txtPostCode.Location = new Point(150, 215);
            txtPostCode.Name = "txtPostCode";
            txtPostCode.Size = new Size(133, 23);
            txtPostCode.TabIndex = 8;
            // 
            // ADD
            // 
            ADD.Location = new Point(317, 267);
            ADD.Name = "ADD";
            ADD.Size = new Size(133, 42);
            ADD.TabIndex = 9;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(644, 267);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(133, 42);
            DELETE.TabIndex = 10;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            // 
            // UPDATE
            // 
            UPDATE.Location = new Point(486, 267);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(133, 42);
            UPDATE.TabIndex = 11;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            // 
            // GoToEngineersForm
            // 
            GoToEngineersForm.Location = new Point(486, 361);
            GoToEngineersForm.Name = "GoToEngineersForm";
            GoToEngineersForm.Size = new Size(133, 42);
            GoToEngineersForm.TabIndex = 12;
            GoToEngineersForm.Text = "Go To EngineersForm";
            GoToEngineersForm.UseVisualStyleBackColor = true;
            // 
            // AddressForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GoToEngineersForm);
            Controls.Add(UPDATE);
            Controls.Add(DELETE);
            Controls.Add(ADD);
            Controls.Add(txtPostCode);
            Controls.Add(txtCity);
            Controls.Add(txtStreet);
            Controls.Add(txtAddressID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewAddress);
            Name = "AddressForm";
            Text = "AddressForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAddress;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAddressID;
        private TextBox txtStreet;
        private TextBox txtCity;
        private TextBox txtPostCode;
        private Button ADD;
        private Button DELETE;
        private Button UPDATE;
        private Button GoToEngineersForm;
        private DataGridViewCellEventHandler dataGridViewAddress_CellContentClick;
    }
}