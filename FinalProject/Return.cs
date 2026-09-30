 using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        private void txt_cusNamee_TextChanged(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var CustomerName = txt_cusNamee.Text.Trim();
            var result = db.Borrowings
                    .Include(b=>b.Customer)
                    .Include(b=>b.Book)
                   .Where(b => b.Customer.Name.Contains(CustomerName) && b.IsReturned == false)
                   .ToList();
            dgv_return.DataSource = result;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            foreach (DataGridViewRow row in dgv_return.SelectedRows)
            {
                int borrowingId =Convert.ToInt32(row.Cells[0].Value);

                var borrowingInDb = db.Borrowings
                    .Include(b => b.Book)
                    .FirstOrDefault(b => b.ID == borrowingId);
                var result = borrowingInDb.ReturnBook();
                if (result > 0)
                {
                    MessageBox.Show($"price={result} for the delay");
                }
                else
                {
                    MessageBox.Show("Done");
                }
            }
            db.SaveChanges();

        }

        private void Return_Load(object sender, EventArgs e)

        {
            using var db = new AppDbContext();
            var result = db.Borrowings
                .Include(b=> b.Book)
                .Include(b=> b.Customer)
                .Where(b => b.IsReturned == false)
                .ToList();
           
            dgv_return.DataSource = result;
            dgv_return.Columns["ID"].Visible = false;
            dgv_return.Columns["TotalPrice"].Visible = false;
            dgv_return.Columns["ReturnDate"].Visible = false;
            dgv_return.Columns["Book"].Visible = false;
            dgv_return.Columns["Customer"].Visible = false;
            dgv_return.Columns["BookId"].Visible = false;





        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
