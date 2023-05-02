namespace FaruSneaker
{
    partial class Revenue
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
            txt_TotalCash = new TextBox();
            btn_Bind = new Button();
            dgv_Bill = new DataGridView();
            btn_Remove = new Button();
            btn_Print = new Button();
            btn_search = new CButton();
            txt_search = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Bill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(826, 116);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 78;
            label1.Text = "Tổng doanh thu";
            // 
            // txt_TotalCash
            // 
            txt_TotalCash.Location = new Point(962, 113);
            txt_TotalCash.Name = "txt_TotalCash";
            txt_TotalCash.Size = new Size(171, 27);
            txt_TotalCash.TabIndex = 77;
            // 
            // btn_Bind
            // 
            btn_Bind.BackColor = Color.FromArgb(233, 197, 57);
            btn_Bind.ForeColor = Color.Black;
            btn_Bind.Location = new Point(24, 103);
            btn_Bind.Name = "btn_Bind";
            btn_Bind.Size = new Size(118, 37);
            btn_Bind.TabIndex = 76;
            btn_Bind.Text = "Xem";
            btn_Bind.UseVisualStyleBackColor = false;
            btn_Bind.Click += btn_Bind_Click;
            // 
            // dgv_Bill
            // 
            dgv_Bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Bill.Location = new Point(24, 180);
            dgv_Bill.Name = "dgv_Bill";
            dgv_Bill.RowHeadersWidth = 51;
            dgv_Bill.RowTemplate.Height = 29;
            dgv_Bill.Size = new Size(1109, 339);
            dgv_Bill.TabIndex = 75;
            // 
            // btn_Remove
            // 
            btn_Remove.BackColor = Color.FromArgb(233, 197, 57);
            btn_Remove.ForeColor = Color.Black;
            btn_Remove.Location = new Point(826, 555);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(118, 37);
            btn_Remove.TabIndex = 74;
            btn_Remove.Text = "Xóa ";
            btn_Remove.UseVisualStyleBackColor = false;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // btn_Print
            // 
            btn_Print.BackColor = Color.FromArgb(233, 197, 57);
            btn_Print.ForeColor = Color.Black;
            btn_Print.Location = new Point(1015, 555);
            btn_Print.Name = "btn_Print";
            btn_Print.Size = new Size(118, 37);
            btn_Print.TabIndex = 73;
            btn_Print.Text = "In";
            btn_Print.UseVisualStyleBackColor = false;
            btn_Print.Click += btn_Print_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(232, 232, 232);
            btn_search.BackgroundColor = Color.FromArgb(232, 232, 232);
            btn_search.BorderColor = Color.Transparent;
            btn_search.BorderRadius = 1;
            btn_search.BorderSize = 0;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.ForeColor = Color.Transparent;
            btn_search.Image = Properties.Resources.search;
            btn_search.Location = new Point(569, 15);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(66, 39);
            btn_search.TabIndex = 71;
            btn_search.TextColor = Color.Transparent;
            btn_search.UseVisualStyleBackColor = false;
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.FromArgb(232, 232, 232);
            txt_search.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(59, 15);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(576, 40);
            txt_search.TabIndex = 72;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(48, 48, 48);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1163, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // Revenue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 617);
            Controls.Add(label1);
            Controls.Add(txt_TotalCash);
            Controls.Add(btn_Bind);
            Controls.Add(dgv_Bill);
            Controls.Add(btn_Remove);
            Controls.Add(btn_Print);
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(pictureBox1);
            Name = "Revenue";
            Text = "Revenue";
            Load += Revenue_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Bill).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_TotalCash;
        private Button btn_Bind;
        private DataGridView dgv_Bill;
        private Button btn_Remove;
        private Button btn_Print;
        private CButton btn_search;
        private TextBox txt_search;
        private PictureBox pictureBox1;
    }
}