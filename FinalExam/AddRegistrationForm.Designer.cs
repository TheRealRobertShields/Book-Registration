namespace FinalExam
{
    partial class AddRegistrationForm
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(108, 33);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Enabled = false;
            this.txtBookTitle.Location = new System.Drawing.Point(108, 95);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(200, 20);
            this.txtBookTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Book Title:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(77, 223);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(104, 33);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(187, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 33);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtISBN
            // 
            this.txtISBN.Enabled = false;
            this.txtISBN.Location = new System.Drawing.Point(108, 131);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(200, 20);
            this.txtISBN.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ISBN:";
            // 
            // txtCustID
            // 
            this.txtCustID.Enabled = false;
            this.txtCustID.Location = new System.Drawing.Point(108, 64);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(200, 20);
            this.txtCustID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CustomerID:";
            // 
            // AddRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 279);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "AddRegistrationForm";
            this.Text = "AddRegistrationForm";
            this.Load += new System.EventHandler(this.AddRegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label5;
    }
}