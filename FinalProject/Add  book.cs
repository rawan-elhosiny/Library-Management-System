using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 

namespace FinalProject
{
    public partial class Manage_book : Form
    {
        public Manage_book()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var res1 = txt_title.Text.Trim();
            var res2 = int.Parse(txt_dailyprice.Text.Trim());
            var res3 = txt_author.Text.Trim();
            var res4 = int.Parse(txt_copiescount.Text.Trim());
           var res= Book.Create(res1, res2, res3, res4);
            using var db = new AppDbContext();
            db.Books.Add(res);
            db.SaveChanges();
            MessageBox.Show("Done");

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
