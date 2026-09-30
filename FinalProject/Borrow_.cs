using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.WebSockets;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Borrow_ : Form
    {
        public Borrow_()
        {
            InitializeComponent();
        }
        private void Borrow__Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_bookname_TextChanged(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var book = db.Books;
            var bookname = txt_bookname.Text.Trim();
            var result = db.Books
                   .Where(b => b.Title.Contains(bookname))
                   .ToList();
            dgv_book.DataSource = result;
        }

        private void cb_cusName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cusName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cusName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            { e.Handled = true; }
        }

        private void txt_cusID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            { e.Handled = true; }
        }

        private void txt_cusPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            { e.Handled = true; }

        }

        private void txt_cusEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '_' && e.KeyChar != '.')
            { e.Handled = true; }
        }

        private void txt_bookname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            { e.Handled = true; }
        }

        private void btn_borrow__Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_cusName.Text))
            { MessageBox.Show("Enter Customer Name"); return; }
            if (string.IsNullOrWhiteSpace(txt_cusPhone.Text))
            { MessageBox.Show("Enter phone number"); return; }
            if (string.IsNullOrWhiteSpace(txt_cusID.Text))
            { MessageBox.Show("Enter National ID"); return; }
            if (string.IsNullOrWhiteSpace(txt_days.Text))
            { MessageBox.Show("Enter Number of Days"); return; }
            var res1 = txt_cusName.Text.Trim();
            var res2 = txt_cusID.Text.Trim();
            var res3 = txt_cusPhone.Text.Trim();
            var res4 = txt_cusEmail.Text.Trim();
            using var db = new AppDbContext();
            var _customer = db.Customers.FirstOrDefault(c => c.NationalId == res2);
            bool hasUnreturned = db.Borrowings.Any(b => b.NationalId == res2 && b.IsReturned == false);
            if (hasUnreturned)

            { MessageBox.Show("This customer already has an unreturned book!"); return; }
            
                        if (_customer == null)
            {
                _customer = Customer.Add(res2, res1,res3 ,res4 );
                db.Customers.Add(_customer);
                db.SaveChanges();
            }
                        
            if (dgv_book.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select Book");
                return;
            }
            int days = int.Parse(txt_days.Text);
            DateTime borrowDate = DateTime.Today;
            foreach (DataGridViewRow row in dgv_book.SelectedRows)
            {
                var selectedBook = (Book)row.DataBoundItem;
                var bookInDb = db.Books.Find(selectedBook.BookId);
                if (bookInDb.CopiesCount > 0)
                {
                   
                    var res = Borrowing.Create(_customer, bookInDb, borrowDate, days);
                    db.Borrowings.Add(res);
                    MessageBox.Show($"Done.Price={res.TotalPrice}");
                }
            }
            db.SaveChanges();

        }

        private void btn_close__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
