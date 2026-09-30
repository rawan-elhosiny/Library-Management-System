namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Borrow_ borrow = new Borrow_();
            borrow.ShowDialog();
        }

        private void btn_searchbooks_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_managebook_Click(object sender, EventArgs e)
        {
            Manage_book AddBooks = new Manage_book();
            //اسم الفورم
            AddBooks.ShowDialog();//هتدخلني على الفورم التانية

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Return _return = new Return();
            _return.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
