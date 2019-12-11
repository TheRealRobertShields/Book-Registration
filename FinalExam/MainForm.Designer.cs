namespace FinalExam
{
    partial class MainForm
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
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbBookTitle = new System.Windows.Forms.ComboBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRegisterBook = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(76, 69);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(219, 21);
            this.cbCustomer.TabIndex = 0;
            // 
            // cbBookTitle
            // 
            this.cbBookTitle.FormattingEnabled = true;
            this.cbBookTitle.Location = new System.Drawing.Point(76, 114);
            this.cbBookTitle.Name = "cbBookTitle";
            this.cbBookTitle.Size = new System.Drawing.Size(219, 21);
            this.cbBookTitle.TabIndex = 1;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(323, 65);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(115, 56);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(323, 130);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(115, 56);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // btnRegisterBook
            // 
            this.btnRegisterBook.Location = new System.Drawing.Point(180, 218);
            this.btnRegisterBook.Name = "btnRegisterBook";
            this.btnRegisterBook.Size = new System.Drawing.Size(115, 56);
            this.btnRegisterBook.TabIndex = 3;
            this.btnRegisterBook.Text = "Register Book";
            this.btnRegisterBook.UseVisualStyleBackColor = true;
            this.btnRegisterBook.Click += new System.EventHandler(this.BtnRegisterBook_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(76, 159);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 328);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnRegisterBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.cbBookTitle);
            this.Controls.Add(this.cbCustomer);
            this.Name = "MainForm";
            this.Text = "Book Registration";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbBookTitle;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRegisterBook;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

