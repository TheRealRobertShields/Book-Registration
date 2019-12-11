namespace FinalExam
{
    partial class AddCustomerForm
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
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.dtpCustDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblCustTitle = new System.Windows.Forms.Label();
            this.cbCustTitle = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(108, 47);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(200, 20);
            this.txtFName.TabIndex = 1;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(108, 88);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(200, 20);
            this.txtLName.TabIndex = 2;
            // 
            // dtpCustDOB
            // 
            this.dtpCustDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCustDOB.Location = new System.Drawing.Point(108, 129);
            this.dtpCustDOB.Name = "dtpCustDOB";
            this.dtpCustDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpCustDOB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date of Birth:";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(96, 182);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(144, 34);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // lblCustTitle
            // 
            this.lblCustTitle.AutoSize = true;
            this.lblCustTitle.Location = new System.Drawing.Point(76, 18);
            this.lblCustTitle.Name = "lblCustTitle";
            this.lblCustTitle.Size = new System.Drawing.Size(30, 13);
            this.lblCustTitle.TabIndex = 5;
            this.lblCustTitle.Text = "Title:";
            // 
            // cbCustTitle
            // 
            this.cbCustTitle.FormattingEnabled = true;
            this.cbCustTitle.Location = new System.Drawing.Point(108, 13);
            this.cbCustTitle.Name = "cbCustTitle";
            this.cbCustTitle.Size = new System.Drawing.Size(121, 21);
            this.cbCustTitle.TabIndex = 0;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 253);
            this.Controls.Add(this.cbCustTitle);
            this.Controls.Add(this.lblCustTitle);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpCustDOB);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Name = "AddCustomerForm";
            this.Text = "Add Customer Form";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.DateTimePicker dtpCustDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblCustTitle;
        private System.Windows.Forms.ComboBox cbCustTitle;
    }
}