namespace FinalProject
{
    partial class Borrow_
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            txt_days = new TextBox();
            btn_borrow_ = new Button();
            btn_close_ = new Button();
            label10 = new Label();
            txt_bookname = new TextBox();
            txt_cusEmail = new TextBox();
            txt_cusID = new TextBox();
            txt_cusPhone = new TextBox();
            txt_cusName = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            dgv_book = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_book).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(12, 142);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(27, 259);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 2;
            label2.Text = "National ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(12, 379);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 3;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SeaGreen;
            label4.Location = new Point(46, 486);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 4;
            label4.Text = "E-Mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(560, 124);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 8;
            label5.Text = "Book Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SeaGreen;
            label8.Location = new Point(560, 387);
            label8.Name = "label8";
            label8.Size = new Size(155, 25);
            label8.TabIndex = 13;
            label8.Text = "Number Of Days ";
            label8.Click += label8_Click;
            // 
            // txt_days
            // 
            txt_days.Location = new Point(721, 383);
            txt_days.Name = "txt_days";
            txt_days.Size = new Size(205, 27);
            txt_days.TabIndex = 17;
            // 
            // btn_borrow_
            // 
            btn_borrow_.BackColor = Color.SeaGreen;
            btn_borrow_.FlatAppearance.BorderSize = 0;
            btn_borrow_.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_borrow_.ForeColor = SystemColors.HighlightText;
            btn_borrow_.Location = new Point(336, 594);
            btn_borrow_.Name = "btn_borrow_";
            btn_borrow_.Size = new Size(99, 42);
            btn_borrow_.TabIndex = 19;
            btn_borrow_.Text = "Borrow ";
            btn_borrow_.UseVisualStyleBackColor = false;
            btn_borrow_.Click += btn_borrow__Click;
            // 
            // btn_close_
            // 
            btn_close_.BackColor = Color.Transparent;
            btn_close_.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close_.ForeColor = SystemColors.ControlDarkDark;
            btn_close_.Location = new Point(625, 594);
            btn_close_.Name = "btn_close_";
            btn_close_.Size = new Size(99, 42);
            btn_close_.TabIndex = 21;
            btn_close_.Text = "close ";
            btn_close_.UseVisualStyleBackColor = false;
            btn_close_.Click += btn_close__Click;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.HighlightText;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SeaGreen;
            label10.Location = new Point(430, 37);
            label10.Name = "label10";
            label10.Size = new Size(131, 38);
            label10.TabIndex = 22;
            label10.Text = "Borrow";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_bookname
            // 
            txt_bookname.Location = new Point(692, 124);
            txt_bookname.Name = "txt_bookname";
            txt_bookname.Size = new Size(234, 27);
            txt_bookname.TabIndex = 27;
            txt_bookname.TextChanged += txt_bookname_TextChanged;
            txt_bookname.KeyPress += txt_bookname_KeyPress;
            // 
            // txt_cusEmail
            // 
            txt_cusEmail.Location = new Point(165, 482);
            txt_cusEmail.Name = "txt_cusEmail";
            txt_cusEmail.Size = new Size(180, 27);
            txt_cusEmail.TabIndex = 28;
            txt_cusEmail.KeyPress += txt_cusEmail_KeyPress;
            // 
            // txt_cusID
            // 
            txt_cusID.Location = new Point(165, 257);
            txt_cusID.Name = "txt_cusID";
            txt_cusID.Size = new Size(180, 27);
            txt_cusID.TabIndex = 29;
            txt_cusID.KeyPress += txt_cusID_KeyPress;
            // 
            // txt_cusPhone
            // 
            txt_cusPhone.Location = new Point(165, 379);
            txt_cusPhone.Name = "txt_cusPhone";
            txt_cusPhone.Size = new Size(180, 27);
            txt_cusPhone.TabIndex = 30;
            txt_cusPhone.KeyPress += txt_cusPhone_KeyPress;
            // 
            // txt_cusName
            // 
            txt_cusName.Location = new Point(165, 140);
            txt_cusName.Name = "txt_cusName";
            txt_cusName.Size = new Size(180, 27);
            txt_cusName.TabIndex = 31;
            txt_cusName.TextChanged += txt_cusName_TextChanged;
            txt_cusName.KeyPress += txt_cusName_KeyPress;
            // 
            // dgv_book
            // 
            dgv_book.AllowUserToAddRows = false;
            dgv_book.BackgroundColor = SystemColors.ControlLight;
            dgv_book.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_book.Location = new Point(532, 167);
            dgv_book.Name = "dgv_book";
            dgv_book.RowHeadersWidth = 51;
            dgv_book.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_book.Size = new Size(523, 153);
            dgv_book.TabIndex = 10;
            // 
            // Borrow_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1067, 720);
            Controls.Add(txt_cusName);
            Controls.Add(txt_cusPhone);
            Controls.Add(txt_cusID);
            Controls.Add(txt_cusEmail);
            Controls.Add(txt_bookname);
            Controls.Add(label10);
            Controls.Add(btn_close_);
            Controls.Add(btn_borrow_);
            Controls.Add(txt_days);
            Controls.Add(label8);
            Controls.Add(dgv_book);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Borrow_";
            Text = "Borrow";
            Load += Borrow__Load;
            ((System.ComponentModel.ISupportInitialize)dgv_book).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private TextBox txt_days;
        private Button btn_borrow_;
        private Button btn_close_;
        private Label label10;
        private TextBox txt_bookname;
        private TextBox txt_cusEmail;
        private TextBox txt_cusID;
        private TextBox txt_cusPhone;
        private TextBox txt_cusName;
        private FolderBrowserDialog folderBrowserDialog1;
        private DataGridView dgv_book;
    }
}