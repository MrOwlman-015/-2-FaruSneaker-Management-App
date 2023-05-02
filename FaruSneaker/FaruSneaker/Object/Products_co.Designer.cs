namespace FaruSneaker.Object
{
    partial class Products_co
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
            btn_search = new CButton();
            label1 = new Label();
            txt_search = new TextBox();
            groupBox1 = new GroupBox();
            txt_importprice = new TextBox();
            txt_price = new TextBox();
            txt_pbrand = new TextBox();
            txt_pname = new TextBox();
            txt_pid = new TextBox();
            dgv_product = new DataGridView();
            btn_update = new Button();
            btn_delete = new Button();
            label11 = new Label();
            btn_add = new Button();
            btn_Image = new Button();
            pictureBox3 = new PictureBox();
            label10 = new Label();
            dtm_productImportDate = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            nbr_productNum = new NumericUpDown();
            label7 = new Label();
            nbr_productSize = new NumericUpDown();
            label6 = new Label();
            cbx_productColor = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btn_Clear = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nbr_productNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nbr_productSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            btn_search.Location = new Point(570, 15);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(81, 39);
            btn_search.TabIndex = 59;
            btn_search.TextColor = Color.Transparent;
            btn_search.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(48, 48, 48);
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1056, 25);
            label1.Name = "label1";
            label1.Size = new Size(101, 24);
            label1.TabIndex = 57;
            label1.Text = "Đăng xuất";
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.FromArgb(232, 232, 232);
            txt_search.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(60, 15);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(591, 40);
            txt_search.TabIndex = 60;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btn_Clear);
            groupBox1.Controls.Add(txt_importprice);
            groupBox1.Controls.Add(txt_price);
            groupBox1.Controls.Add(txt_pbrand);
            groupBox1.Controls.Add(txt_pname);
            groupBox1.Controls.Add(txt_pid);
            groupBox1.Controls.Add(dgv_product);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(btn_Image);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dtm_productImportDate);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(nbr_productNum);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(nbr_productSize);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbx_productColor);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(29, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1133, 575);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // txt_importprice
            // 
            txt_importprice.Location = new Point(15, 218);
            txt_importprice.Name = "txt_importprice";
            txt_importprice.Size = new Size(234, 32);
            txt_importprice.TabIndex = 38;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(286, 146);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(234, 32);
            txt_price.TabIndex = 37;
            // 
            // txt_pbrand
            // 
            txt_pbrand.Location = new Point(15, 146);
            txt_pbrand.Name = "txt_pbrand";
            txt_pbrand.Size = new Size(234, 32);
            txt_pbrand.TabIndex = 36;
            // 
            // txt_pname
            // 
            txt_pname.Location = new Point(286, 69);
            txt_pname.Name = "txt_pname";
            txt_pname.Size = new Size(234, 32);
            txt_pname.TabIndex = 35;
            // 
            // txt_pid
            // 
            txt_pid.Location = new Point(15, 68);
            txt_pid.Name = "txt_pid";
            txt_pid.Size = new Size(234, 32);
            txt_pid.TabIndex = 34;
            // 
            // dgv_product
            // 
            dgv_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_product.Location = new Point(546, 69);
            dgv_product.Name = "dgv_product";
            dgv_product.RowHeadersWidth = 51;
            dgv_product.RowTemplate.Height = 29;
            dgv_product.Size = new Size(564, 458);
            dgv_product.TabIndex = 33;
            dgv_product.CellClick += dgv_product_CellClick;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(233, 197, 57);
            btn_update.ForeColor = Color.Black;
            btn_update.Location = new Point(387, 490);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(133, 37);
            btn_update.TabIndex = 32;
            btn_update.Text = "Cập nhật ";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(233, 197, 57);
            btn_delete.ForeColor = Color.Black;
            btn_delete.Location = new Point(202, 490);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(133, 37);
            btn_delete.TabIndex = 31;
            btn_delete.Text = "Xóa ";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(780, 41);
            label11.Name = "label11";
            label11.Size = new Size(140, 24);
            label11.TabIndex = 30;
            label11.Text = "THEO DÕI SẢN PHẨM";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(233, 197, 57);
            btn_add.ForeColor = Color.Black;
            btn_add.Location = new Point(15, 490);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(133, 37);
            btn_add.TabIndex = 28;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += button2_Click;
            // 
            // btn_Image
            // 
            btn_Image.BackColor = Color.FromArgb(224, 224, 224);
            btn_Image.ForeColor = Color.Black;
            btn_Image.Location = new Point(387, 376);
            btn_Image.Name = "btn_Image";
            btn_Image.Size = new Size(133, 32);
            btn_Image.TabIndex = 27;
            btn_Image.Text = "Thêm hình ảnh";
            btn_Image.UseVisualStyleBackColor = false;
            btn_Image.Click += ptb_Image_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources.logo1;
            pictureBox3.Location = new Point(286, 198);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(234, 156);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(15, 431);
            label10.Name = "label10";
            label10.Size = new Size(115, 24);
            label10.TabIndex = 25;
            label10.Text = "Ngày nhập hàng";
            // 
            // dtm_productImportDate
            // 
            dtm_productImportDate.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtm_productImportDate.Location = new Point(136, 425);
            dtm_productImportDate.Name = "dtm_productImportDate";
            dtm_productImportDate.Size = new Size(233, 32);
            dtm_productImportDate.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(15, 191);
            label9.Name = "label9";
            label9.Size = new Size(103, 24);
            label9.TabIndex = 23;
            label9.Text = "Giá nhập hàng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(286, 119);
            label8.Name = "label8";
            label8.Size = new Size(59, 24);
            label8.TabIndex = 21;
            label8.Text = "Đơn giá";
            // 
            // nbr_productNum
            // 
            nbr_productNum.Location = new Point(136, 322);
            nbr_productNum.Name = "nbr_productNum";
            nbr_productNum.Size = new Size(79, 32);
            nbr_productNum.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 380);
            label7.Name = "label7";
            label7.Size = new Size(81, 24);
            label7.TabIndex = 18;
            label7.Text = "Kích thước";
            // 
            // nbr_productSize
            // 
            nbr_productSize.Location = new Point(136, 372);
            nbr_productSize.Name = "nbr_productSize";
            nbr_productSize.Size = new Size(79, 32);
            nbr_productSize.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 330);
            label6.Name = "label6";
            label6.Size = new Size(69, 24);
            label6.TabIndex = 16;
            label6.Text = "Số lượng";
            // 
            // cbx_productColor
            // 
            cbx_productColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_productColor.FormattingEnabled = true;
            cbx_productColor.Items.AddRange(new object[] { "Đỏ", "Xanh", "Trắng", "Vàng", "Hồng", "Cam", "Tím", "Xanh lá", "Thêm màu" });
            cbx_productColor.Location = new Point(85, 274);
            cbx_productColor.Name = "cbx_productColor";
            cbx_productColor.Size = new Size(164, 32);
            cbx_productColor.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 282);
            label5.Name = "label5";
            label5.Size = new Size(64, 24);
            label5.TabIndex = 14;
            label5.Text = "Màu sắc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 41);
            label2.Name = "label2";
            label2.Size = new Size(95, 24);
            label2.TabIndex = 9;
            label2.Text = "Mã mặt hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 119);
            label4.Name = "label4";
            label4.Size = new Size(90, 24);
            label4.TabIndex = 13;
            label4.Text = "Thương hiệu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(286, 41);
            label3.Name = "label3";
            label3.Size = new Size(98, 24);
            label3.TabIndex = 11;
            label3.Text = "Tên mặt hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(48, 48, 48);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1178, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.FromArgb(224, 224, 224);
            btn_Clear.ForeColor = Color.Black;
            btn_Clear.Location = new Point(387, 427);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(133, 32);
            btn_Clear.TabIndex = 40;
            btn_Clear.Text = "Xóa tùy chọn";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // Products_co
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_search);
            Controls.Add(label1);
            Controls.Add(txt_search);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "Products_co";
            Size = new Size(1178, 664);
            Load += Products_co_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_product).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)nbr_productNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)nbr_productSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CButton btn_search;
        private Label label1;
        private TextBox txt_search;
        private GroupBox groupBox1;
        private TextBox txt_importprice;
        private TextBox txt_price;
        private TextBox txt_pbrand;
        private TextBox txt_pname;
        private TextBox txt_pid;
        private DataGridView dgv_product;
        private Button btn_update;
        private Button btn_delete;
        private Label label11;
        private Button btn_add;
        private Button btn_Image;
        private PictureBox pictureBox3;
        private Label label10;
        private DateTimePicker dtm_productImportDate;
        private Label label9;
        private Label label8;
        private NumericUpDown nbr_productNum;
        private Label label7;
        private NumericUpDown nbr_productSize;
        private Label label6;
        private ComboBox cbx_productColor;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btn_Clear;
    }
}
