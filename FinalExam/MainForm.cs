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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            List<Book> allBooks = BookDB.GetAllBooks();
            cbBookTitle.Items.Clear();
            foreach (Book book in allBooks)
            {
                cbBookTitle.Items.Add(book);
            }

            List<Customer> allCustomers = CustomerDB.GetAllCustomers();
            cbCustomer.Items.Clear();
            foreach (Customer cust in allCustomers)
            {
                cbCustomer.Items.Add(cust);
            }
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCust = new AddCustomerForm();
            DialogResult result = addCust.ShowDialog();

            // After AddCustomerForm is closed //
            if (result == DialogResult.OK)
            {
                string fullName = addCust.GetFullName();
                MessageBox.Show($"{fullName} registered.");
                cbCustomer.Items.Add(fullName);
                PopulateComboBoxes();
            }
            else
            {
                MessageBox.Show("Customer not registered.");
            }
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBook = new AddBookForm();
            DialogResult result = addBook.ShowDialog();

            if (result == DialogResult.OK)
            {
                string bookTitle = addBook.GetBookTitle();
                MessageBox.Show($"{bookTitle} registered.");
                cbBookTitle.Items.Add(bookTitle);
                PopulateComboBoxes();
            }
            else
            {
                MessageBox.Show("Book not added.");
            }
        }

        private void BtnRegisterBook_Click(object sender, EventArgs e)
        {
            if (cbBookTitle.SelectedIndex < 0 && cbCustomer.SelectedIndex >= 0)
            {
                MessageBox.Show("Please select a book.");
                return;
            }
            else if (cbCustomer.SelectedIndex < 0 && cbBookTitle.SelectedIndex >= 0)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }
            else if (cbBookTitle.SelectedIndex < 0 && cbCustomer.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a customer and book.");
                return;
            }

            Book book = (Book)cbBookTitle.SelectedItem;
            Customer cust = (Customer)cbCustomer.SelectedItem;
            


            AddRegistrationForm addReg = new AddRegistrationForm(book, cust);
            DialogResult result = addReg.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Registration complete.");
            }
            else
            {
                MessageBox.Show("Registration canceled.");
            }
        }
    }
}
