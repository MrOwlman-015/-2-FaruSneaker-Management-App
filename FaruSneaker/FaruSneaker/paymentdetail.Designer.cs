namespace FaruSneaker
{
    partial class paymentdetail
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
            rtx_IntoCash = new TextBox();
            rtx_Discount = new TextBox();
            rtx_Price = new TextBox();
            rtx_PName = new TextBox();
            rtx_PID = new TextBox();
            btn_Update = new Button();
            groupBox1 = new GroupBox();
            dgv_choose = new DataGridView();
            btn_Remove = new Button();
            btn_Pay = new Button();
            dgv_product = new DataGridView();
            nbr_Num = new NumericUpDown();
            btn_Add = new Button();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_choose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nbr_Num).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources._while;
            groupBox2.Controls.Add(rtx_IntoCash);
            groupBox2.Controls.Add(rtx_Discount);
            groupBox2.Controls.Add(rtx_Price);
            groupBox2.Controls.Add(rtx_PName);
            groupBox2.Controls.Add(rtx_PID);
            groupBox2.Controls.Add(btn_Update);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(btn_Remove);
            groupBox2.Controls.Add(btn_Pay);
            groupBox2.Controls.Add(dgv_product);
            groupBox2.Controls.Add(nbr_Num);
            groupBox2.Controls.Add(btn_Add);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label18);
            groupBox2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1352, 679);
            groupBox2.TabIndex = 89;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // rtx_IntoCash
            // 
            rtx_IntoCash.Location = new Point(885, 76);
            rtx_IntoCash.Name = "rtx_IntoCash";
            rtx_IntoCash.Size = new Size(234, 32);
            rtx_IntoCash.TabIndex = 108;
            // 
            // rtx_Discount
            // 
            rtx_Discount.Location = new Point(885, 39);
            rtx_Discount.Name = "rtx_Discount";
            rtx_Discount.Size = new Size(234, 32);
            rtx_Discount.TabIndex = 107;
            // 
            // rtx_Price
            // 
            rtx_Price.Location = new Point(525, 39);
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
            btn_Update.Location = new Point(550, 615);
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
            groupBox1.Text = "Mặt hàng đã chọn";
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
            btn_Remove.Location = new Point(283, 615);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(194, 37);
            btn_Remove.TabIndex = 97;
            btn_Remove.Text = "Xóa";
            btn_Remove.UseVisualStyleBackColor = false;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // btn_Pay
            // 
            btn_Pay.BackColor = Color.FromArgb(233, 197, 57);
            btn_Pay.ForeColor = Color.Black;
            btn_Pay.Location = new Point(820, 615);
            btn_Pay.Name = "btn_Pay";
            btn_Pay.Size = new Size(194, 37);
            btn_Pay.TabIndex = 96;
            btn_Pay.Text = "Thanh toán";
            btn_Pay.UseVisualStyleBackColor = false;
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
            // nbr_Num
            // 
            nbr_Num.Location = new Point(525, 76);
            nbr_Num.Name = "nbr_Num";
            nbr_Num.Size = new Size(233, 32);
            nbr_Num.TabIndex = 88;
            nbr_Num.ValueChanged += nbr_Num_ValueChanged;
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(782, 47);
            label12.Name = "label12";
            label12.Size = new Size(79, 24);
            label12.TabIndex = 84;
            label12.Text = "Chiết khấu";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(782, 84);
            label13.Name = "label13";
            label13.Size = new Size(78, 24);
            label13.TabIndex = 85;
            label13.Text = "Thành tiền";
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
            label16.Location = new Point(395, 47);
            label16.Name = "label16";
            label16.Size = new Size(59, 24);
            label16.TabIndex = 71;
            label16.Text = "Đơn giá";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(395, 84);
            label17.Name = "label17";
            label17.Size = new Size(69, 24);
            label17.TabIndex = 74;
            label17.Text = "Số lượng";
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
            // paymentdetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 703);
            Controls.Add(groupBox2);
            Name = "paymentdetail";
            Text = "paymentdetail";
            Load += paymentdetail_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_choose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_product).EndInit();
            ((System.ComponentModel.ISupportInitialize)nbr_Num).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btn_Remove;
        private Button btn_Pay;
        private DataGridView dgv_product;
        private NumericUpDown nbr_Num;
        private Button btn_Add;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private DataGridView dgv_choose;
        private Button btn_Update;
        private TextBox rtx_PID;
        private TextBox rtx_PName;
        private TextBox rtx_Price;
        private TextBox rtx_Discount;
        private TextBox rtx_IntoCash;
    }
}