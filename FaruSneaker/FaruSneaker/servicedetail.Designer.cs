namespace FaruSneaker
{
    partial class servicedetail
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
            groupBox2 = new GroupBox();
            rtx_Des = new TextBox();
            label1 = new Label();
            rtx_Price = new TextBox();
            rtx_PName = new TextBox();
            rtx_PID = new TextBox();
            btn_Update = new Button();
            groupBox1 = new GroupBox();
            dgv_choose = new DataGridView();
            btn_Remove = new Button();
            dgv_product = new DataGridView();
            btn_Add = new Button();
            label15 = new Label();
            label16 = new Label();
            label18 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_choose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_product).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources._while;
            groupBox2.Controls.Add(rtx_Des);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(rtx_Price);
            groupBox2.Controls.Add(rtx_PName);
            groupBox2.Controls.Add(rtx_PID);
            groupBox2.Controls.Add(btn_Update);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(btn_Remove);
            groupBox2.Controls.Add(dgv_product);
            groupBox2.Controls.Add(btn_Add);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label18);
            groupBox2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1352, 679);
            groupBox2.TabIndex = 90;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin các dịch vụ";
            // 
            // rtx_Des
            // 
            rtx_Des.Location = new Point(707, 77);
            rtx_Des.Name = "rtx_Des";
            rtx_Des.Size = new Size(234, 32);
            rtx_Des.TabIndex = 108;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(617, 85);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 107;
            label1.Text = "Mô tả";
            // 
            // rtx_Price
            // 
            rtx_Price.Location = new Point(707, 39);
            rtx_Price.Name = "rtx_Price";
            rtx_Price.Size = new Size(234, 32);
            rtx_Price.TabIndex = 106;
            // 
            // rtx_PName
            // 
            rtx_PName.Location = new Point(145, 77);
            rtx_PName.Name = "rtx_PName";
            rtx_PName.Size = new Size(234, 32);
            rtx_PName.TabIndex = 105;
            // 
            // rtx_PID
            // 
            rtx_PID.Location = new Point(145, 39);
            rtx_PID.Name = "rtx_PID";
            rtx_PID.Size = new Size(234, 32);
            rtx_PID.TabIndex = 104;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.FromArgb(233, 197, 57);
            btn_Update.ForeColor = Color.Black;
            btn_Update.Location = new Point(666, 615);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(194, 37);
            btn_Update.TabIndex = 101;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_choose);
            groupBox1.Location = new Point(550, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 444);
            groupBox1.TabIndex = 99;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dịch vụ đã chọn";
            // 
            // dgv_choose
            // 
            dgv_choose.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_choose.Location = new Point(11, 31);
            dgv_choose.Name = "dgv_choose";
            dgv_choose.RowHeadersWidth = 51;
            dgv_choose.RowTemplate.Height = 29;
            dgv_choose.Size = new Size(552, 407);
            dgv_choose.TabIndex = 0;
            // 
            // btn_Remove
            // 
            btn_Remove.BackColor = Color.FromArgb(233, 197, 57);
            btn_Remove.ForeColor = Color.Black;
            btn_Remove.Location = new Point(330, 615);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(194, 37);
            btn_Remove.TabIndex = 97;
            btn_Remove.Text = "Xóa";
            btn_Remove.UseVisualStyleBackColor = false;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // dgv_product
            // 
            dgv_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_product.Location = new Point(14, 144);
            dgv_product.Name = "dgv_product";
            dgv_product.RowHeadersWidth = 51;
            dgv_product.RowTemplate.Height = 29;
            dgv_product.Size = new Size(510, 444);
            dgv_product.TabIndex = 90;
            dgv_product.CellClick += dgv_product_CellClick;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(233, 197, 57);
            btn_Add.ForeColor = Color.Black;
            btn_Add.Location = new Point(14, 615);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(194, 37);
            btn_Add.TabIndex = 82;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(14, 50);
            label15.Name = "label15";
            label15.Size = new Size(97, 24);
            label15.TabIndex = 69;
            label15.Text = "Mã sản phẩm";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(617, 47);
            label16.Name = "label16";
            label16.Size = new Size(59, 24);
            label16.TabIndex = 71;
            label16.Text = "Đơn giá";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(14, 84);
            label18.Name = "label18";
            label18.Size = new Size(100, 24);
            label18.TabIndex = 78;
            label18.Text = "Tên sản phẩm";
            // 
            // servicedetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 703);
            Controls.Add(groupBox2);
            Name = "servicedetail";
            Text = "servicedetail";
            Load += servicedetail_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_choose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_product).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox rtx_Price;
        private TextBox rtx_PName;
        private TextBox rtx_PID;
        private Button btn_Update;
        private GroupBox groupBox1;
        private DataGridView dgv_choose;
        private Button btn_Remove;
        private DataGridView dgv_product;
        private Button btn_Add;
        private Label label15;
        private Label label16;
        private Label label18;
        private TextBox rtx_Des;
        private Label label1;
    }
}