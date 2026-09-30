namespace FinalProject
{
    partial class Return
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
            dgv_return = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txt_cusNamee = new TextBox();
            btn_return = new Button();
            btn_cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_return).BeginInit();
            SuspendLayout();
            // 
            // dgv_return
            // 
            dgv_return.AllowUserToOrderColumns = true;
            dgv_return.BackgroundColor = SystemColors.ControlLight;
            dgv_return.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_return.Location = new Point(49, 147);
            dgv_return.Name = "dgv_return";
            dgv_return.RowHeadersWidth = 51;
            dgv_return.Size = new Size(675, 223);
            dgv_return.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(384, 21);
            label1.Name = "label1";
            label1.Size = new Size(91, 36);
            label1.TabIndex = 0;
            label1.Text = "Return Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(30, 101);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 1;
            label2.Text = " -Customer Name";
            // 
            // txt_cusNamee
            // 
            txt_cusNamee.Location = new Point(172, 94);
            txt_cusNamee.Name = "txt_cusNamee";
            txt_cusNamee.Size = new Size(312, 27);
            txt_cusNamee.TabIndex = 2;
            txt_cusNamee.TextChanged += txt_cusNamee_TextChanged;
            // 
            // btn_return
            // 
            btn_return.BackColor = Color.SeaGreen;
            btn_return.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_return.ForeColor = Color.Ivory;
            btn_return.Location = new Point(265, 416);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(94, 41);
            btn_return.TabIndex = 4;
            btn_return.Text = "Return";
            btn_return.UseVisualStyleBackColor = false;
            btn_return.Click += btn_return_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Transparent;
            btn_cancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancel.ForeColor = SystemColors.ControlDarkDark;
            btn_cancel.Location = new Point(477, 416);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 41);
            btn_cancel.TabIndex = 5;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // Return
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(864, 493);
            Controls.Add(btn_cancel);
            Controls.Add(btn_return);
            Controls.Add(dgv_return);
            Controls.Add(txt_cusNamee);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Return";
            Text = "Return";
            Load += Return_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_return).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_cusNamee;
        private DataGridView dgv_return;
        private Button btn_return;
        private Button btn_cancel;
    }
}