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
    public partial class AddRegistrationForm : Form
    {
        public AddRegistrationForm(Book book, Customer cust)
        {
            InitializeComponent();
            existingBook = book;
            existingCust = cust;
        }

        private Book existingBook;
        private Customer existingCust;

        private void AddRegistrationForm_Load(object sender, EventArgs e)
        {
            txtBookTitle.Text = existingBook.BookTitle;
            txtCustomerName.Text = $"{existingCust.FirstName} {existingCust.LastName}";
            txtISBN.Text = existingBook.BookISBN;
            txtCustID.Text = existingCust.CustomerID.ToString();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.BookISBN = txtISBN.Text;
            reg.CustomerID = Convert.ToInt16(txtCustID.Text);
            BookRegistrationDB.RegisterBook(reg);
            DialogResult = DialogResult.OK;
        }
    }
}
