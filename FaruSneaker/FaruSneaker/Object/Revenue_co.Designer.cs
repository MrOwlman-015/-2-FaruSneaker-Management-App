namespace FaruSneaker.Object
{
    partial class Revenue_co
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btn_Print = new Button();
            btn_Remove = new Button();
            dgv_Bill = new DataGridView();
            btn_Bind = new Button();
            txt_TotalCash = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Bill).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(48, 48, 48);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1178, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            // 
            // btn_Print
            // 
            btn_Print.BackColor = Color.FromArgb(233, 197, 57);
            btn_Print.ForeColor = Color.Black;
            btn_Print.Location = new Point(1016, 602);
            btn_Print.Name = "btn_Print";
            btn_Print.Size = new Size(133, 37);
            btn_Print.TabIndex = 64;
            btn_Print.Text = "Lưu";
            btn_Print.UseVisualStyleBackColor = false;
            btn_Print.Click += btn_Print_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.BackColor = Color.FromArgb(233, 197, 57);
            btn_Remove.ForeColor = Color.Black;
            btn_Remove.Location = new Point(808, 602);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(133, 37);
            btn_Remove.TabIndex = 65;
            btn_Remove.Text = "Xóa ";
            btn_Remove.UseVisualStyleBackColor = false;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // dgv_Bill
            // 
            dgv_Bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Bill.Location = new Point(25, 238);
            dgv_Bill.Name = "dgv_Bill";
            dgv_Bill.RowHeadersWidth = 51;
            dgv_Bill.RowTemplate.Height = 29;
            dgv_Bill.Size = new Size(1124, 339);
            dgv_Bill.TabIndex = 66;
            // 
            // btn_Bind
            // 
            btn_Bind.BackColor = Color.FromArgb(233, 197, 57);
            btn_Bind.ForeColor = Color.Black;
            btn_Bind.Location = new Point(25, 156);
            btn_Bind.Name = "btn_Bind";
            btn_Bind.Size = new Size(133, 37);
            btn_Bind.TabIndex = 67;
            btn_Bind.Text = "Xem";
            btn_Bind.UseVisualStyleBackColor = false;
            btn_Bind.Click += btn_Bind_Click;
            // 
            // txt_TotalCash
            // 
            txt_TotalCash.Location = new Point(963, 166);
            txt_TotalCash.Name = "txt_TotalCash";
            txt_TotalCash.Size = new Size(186, 27);
            txt_TotalCash.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(827, 169);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 69;
            label1.Text = "Tổng doanh thu";
            // 
            // Revenue_co
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(txt_TotalCash);
            Controls.Add(btn_Bind);
            Controls.Add(dgv_Bill);
            Controls.Add(btn_Remove);
            Controls.Add(btn_Print);
            Controls.Add(pictureBox1);
            Name = "Revenue_co";
            Size = new Size(1178, 664);
            Load += Revenue_co_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Bill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_Print;
        private Button btn_Remove;
        private DataGridView dgv_Bill;
        private Button btn_Bind;
        private TextBox txt_TotalCash;
        private Label label1;
    }
}
