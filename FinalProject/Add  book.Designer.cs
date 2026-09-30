namespace FinalProject
{
    partial class Manage_book
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
            lbl_title = new Label();
            lbl_author = new Label();
            lbl_dailyprice = new Label();
            txt_title = new TextBox();
            txt_author = new TextBox();
            txt_dailyprice = new TextBox();
            btn_add = new Button();
            btn_close = new Button();
            label2 = new Label();
            txt_copiescount = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.BackColor = Color.Transparent;
            lbl_title.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.SeaGreen;
            lbl_title.Location = new Point(30, 114);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(112, 27);
            lbl_title.TabIndex = 1;
            lbl_title.Text = "Book Title";
            // 
            // lbl_author
            // 
            lbl_author.AutoSize = true;
            lbl_author.BackColor = Color.Transparent;
            lbl_author.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_author.ForeColor = Color.SeaGreen;
            lbl_author.Location = new Point(30, 177);
            lbl_author.Name = "lbl_author";
            lbl_author.Size = new Size(66, 23);
            lbl_author.TabIndex = 2;
            lbl_author.Text = "Author";
            // 
            // lbl_dailyprice
            // 
            lbl_dailyprice.AutoSize = true;
            lbl_dailyprice.BackColor = Color.Transparent;
            lbl_dailyprice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_dailyprice.ForeColor = Color.SeaGreen;
            lbl_dailyprice.Location = new Point(30, 254);
            lbl_dailyprice.Name = "lbl_dailyprice";
            lbl_dailyprice.Size = new Size(100, 23);
            lbl_dailyprice.TabIndex = 3;
            lbl_dailyprice.Text = "Daily Price ";
            // 
            // txt_title
            // 
            txt_title.Location = new Point(159, 114);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(279, 27);
            txt_title.TabIndex = 4;
            // 
            // txt_author
            // 
            txt_author.Location = new Point(159, 173);
            txt_author.Name = "txt_author";
            txt_author.Size = new Size(279, 27);
            txt_author.TabIndex = 5;
            // 
            // txt_dailyprice
            // 
            txt_dailyprice.Location = new Point(159, 254);
            txt_dailyprice.Name = "txt_dailyprice";
            txt_dailyprice.Size = new Size(279, 27);
            txt_dailyprice.TabIndex = 6;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.SeaGreen;
            btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = SystemColors.HighlightText;
            btn_add.Location = new Point(263, 423);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(106, 37);
            btn_add.TabIndex = 7;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Transparent;
            btn_close.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.ForeColor = SystemColors.ControlDarkDark;
            btn_close.Location = new Point(486, 423);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(97, 37);
            btn_close.TabIndex = 8;
            btn_close.Text = "Cancel";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(30, 319);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 9;
            label2.Text = "Copies Count ";
            // 
            // txt_copiescount
            // 
            txt_copiescount.Location = new Point(159, 319);
            txt_copiescount.Name = "txt_copiescount";
            txt_copiescount.Size = new Size(279, 27);
            txt_copiescount.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(352, 26);
            label1.Name = "label1";
            label1.Size = new Size(120, 33);
            label1.TabIndex = 0;
            label1.Text = "Add Book";
            label1.Click += label1_Click;
            // 
            // Manage_book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 491);
            Controls.Add(label1);
            Controls.Add(txt_copiescount);
            Controls.Add(label2);
            Controls.Add(btn_close);
            Controls.Add(btn_add);
            Controls.Add(txt_dailyprice);
            Controls.Add(txt_author);
            Controls.Add(txt_title);
            Controls.Add(lbl_dailyprice);
            Controls.Add(lbl_author);
            Controls.Add(lbl_title);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Manage_book";
            Text = "ADD Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_title;
        private Label lbl_author;
        private Label lbl_dailyprice;
        private TextBox txt_title;
        private TextBox txt_author;
        private TextBox txt_dailyprice;
        private Button btn_add;
        private Button btn_close;
        private Label label2;
        private TextBox txt_copiescount;
        private Label label1;
    }
}