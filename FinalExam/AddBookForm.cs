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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        // Fields //
        private string title;
        private string ISBN;
        private decimal price;

        // Getter //
        public string GetBookTitle()
        {
            return $"{title}";
        }
        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            if (isValidInt())
            {
                Book book = new Book();
                book.BookISBN = txtISBN.Text;
                book.BookPrice = Convert.ToDecimal(txtPrice.Text);
                book.BookTitle = txtTitle.Text;
                BookDB.AddBook(book);
                price = Convert.ToDecimal(txtPrice.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private bool isValidInt()
        {
            int price;
            if (int.TryParse(txtPrice.Text, out price))
            {
                if (price <= 0)
                {
                    MessageBox.Show("Ain't nothin' free!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

    }
}
