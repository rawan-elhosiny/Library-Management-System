namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_managebook = new Button();
            btn_borrowing = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_managebook
            // 
            btn_managebook.AutoSize = true;
            btn_managebook.BackColor = Color.SeaGreen;
            btn_managebook.FlatAppearance.BorderSize = 0;
            btn_managebook.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_managebook.ForeColor = SystemColors.HighlightText;
            btn_managebook.Location = new Point(444, 349);
            btn_managebook.Name = "btn_managebook";
            btn_managebook.Size = new Size(186, 38);
            btn_managebook.TabIndex = 0;
            btn_managebook.Text = "Add Book";
            btn_managebook.UseVisualStyleBackColor = false;
            btn_managebook.Click += btn_managebook_Click;
            // 
            // btn_borrowing
            // 
            btn_borrowing.AutoSize = true;
            btn_borrowing.BackColor = Color.SeaGreen;
            btn_borrowing.FlatAppearance.BorderSize = 0;
            btn_borrowing.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_borrowing.ForeColor = SystemColors.ButtonHighlight;
            btn_borrowing.Location = new Point(444, 194);
            btn_borrowing.Name = "btn_borrowing";
            btn_borrowing.Size = new Size(186, 40);
            btn_borrowing.TabIndex = 3;
            btn_borrowing.Text = "Borrow";
            btn_borrowing.UseVisualStyleBackColor = false;
            btn_borrowing.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(444, 270);
            button1.Name = "button1";
            button1.Size = new Size(186, 38);
            button1.TabIndex = 4;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.WhiteSmoke;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(395, 48);
            label1.Name = "label1";
            label1.Size = new Size(284, 40);
            label1.TabIndex = 5;
            label1.Text = "Library Management System";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1101, 540);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btn_borrowing);
            Controls.Add(btn_managebook);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Management system";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_managebook;
        private Button btn_borrowing;
        private Button button1;
        private Label label1;
    }
}
