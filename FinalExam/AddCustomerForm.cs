using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        // Fields //
        private string fName;
        private string lName;

        // Getter //
        public string GetFullName()
        {
            return $"{fName} {lName}";
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtFName.Text.Trim() == "" && txtLName.Text.Trim() != "" && cbCustTitle.SelectedIndex != -1)
                MessageBox.Show("Enter customer's first name.");
            else if (txtFName.Text.Trim() != "" && txtLName.Text.Trim() == "" && cbCustTitle.SelectedIndex != -1)
                MessageBox.Show("Enter customer's last name.");
            else if (txtFName.Text.Trim() != "" && txtLName.Text.Trim() != "" && cbCustTitle.SelectedIndex == -1)
                MessageBox.Show("Enter customer's title.");
            else if (txtFName.Text.Trim() != "" && txtLName.Text.Trim() != "" && cbCustTitle.SelectedIndex != -1)
            {
                MessageBox.Show("Saved to the DB");
                Customer cust = new Customer();
                cust.FirstName = txtFName.Text.Trim();
                cust.LastName = txtLName.Text.Trim();
                cust.DateOfBirth = dtpCustDOB.Value;
                CustomerDB.AddCustomer(cust, cbCustTitle.SelectedItem.ToString());
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Form needs to be filled out.");
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            cbCustTitle.Items.Add("Mr.");
            cbCustTitle.Items.Add("Ms.");
            cbCustTitle.Items.Add("Dr.");
            cbCustTitle.Items.Add("Mrs.");
        }
    }
}
