namespace FaruSneaker.Object
{
    partial class Payment_co
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
            groupBox2 = new GroupBox();
            rtx_TotalCash = new TextBox();
            rtx_IntoCash = new TextBox();
            rtx_Discount = new TextBox();
            rtx_Price = new TextBox();
            rtx_PName = new TextBox();
            rtx_PID = new TextBox();
            btn_Add = new Button();
            btn_CancelBill = new Button();
            btn_PayBill = new Button();
            label5 = new Label();
            dgv_Payment = new DataGridView();
            nbr_Num = new NumericUpDown();
            btn_AddBill = new Button();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            groupBox1 = new GroupBox();
            rtx_StaffName = new TextBox();
            rtx_CusName = new TextBox();
            rtx_BillID = new TextBox();
            cbx_StaffID = new ComboBox();
            cbx_CusID = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            dtp_Date = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label9 = new Label();
            panel8 = new Panel();
            label1 = new Label();
            cButton7 = new CButton();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            pictureBox1 = new PictureBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Payment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nbr_Num).BeginInit();
            groupBox1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources._while;
            groupBox2.Controls.Add(rtx_TotalCash);
            groupBox2.Controls.Add(rtx_IntoCash);
            groupBox2.Controls.Add(rtx_Discount);
            groupBox2.Controls.Add(rtx_Price);
            groupBox2.Controls.Add(rtx_PName);
            groupBox2.Controls.Add(rtx_PID);
            groupBox2.Controls.Add(btn_Add);
            groupBox2.Controls.Add(btn_CancelBill);
            groupBox2.Controls.Add(btn_PayBill);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dgv_Payment);
            groupBox2.Controls.Add(nbr_Num);
            groupBox2.Controls.Add(btn_AddBill);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label18);
            groupBox2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(31, 242);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1133, 446);
            groupBox2.TabIndex = 92;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // rtx_TotalCash
            // 
            rtx_TotalCash.Location = new Point(885, 408);
            rtx_TotalCash.Name = "rtx_TotalCash";
            rtx_TotalCash.Size = new Size(234, 32);
            rtx_TotalCash.TabIndex = 108;
            // 
            // rtx_IntoCash
            // 
            rtx_IntoCash.Location = new Point(885, 76);
            rtx_IntoCash.Name = "rtx_IntoCash";
            rtx_IntoCash.Size = new Size(234, 32);
            rtx_IntoCash.TabIndex = 107;
            // 
            // rtx_Discount
            // 
            rtx_Discount.Location = new Point(885, 42);
            rtx_Discount.Name = "rtx_Discount";
            rtx_Discount.Size = new Size(234, 32);
            rtx_Discount.TabIndex = 106;
            // 
            // rtx_Price
            // 
            rtx_Price.Location = new Point(524, 39);
            rtx_Price.Name = "rtx_Price";
            rtx_Price.Size = new Size(234, 32);
            rtx_Price.TabIndex = 105;
            // 
            // rtx_PName
            // 
            rtx_PName.Location = new Point(145, 75);
            rtx_PName.Name = "rtx_PName";
            rtx_PName.Size = new Size(234, 32);
            rtx_PName.TabIndex = 104;
            // 
            // rtx_PID
            // 
            rtx_PID.Location = new Point(145, 39);
            rtx_PID.Name = "rtx_PID";
            rtx_PID.Size = new Size(234, 32);
            rtx_PID.TabIndex = 103;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(233, 197, 57);
            btn_Add.ForeColor = Color.Black;
            btn_Add.Location = new Point(185, 116);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(194, 37);
            btn_Add.TabIndex = 99;
            btn_Add.Text = "Thêm hóa đơn";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_CancelBill
            // 
            btn_CancelBill.BackColor = Color.FromArgb(233, 197, 57);
            btn_CancelBill.ForeColor = Color.Black;
            btn_CancelBill.Location = new Point(288, 403);
            btn_CancelBill.Name = "btn_CancelBill";
            btn_CancelBill.Size = new Size(194, 37);
            btn_CancelBill.TabIndex = 97;
            btn_CancelBill.Text = "Hủy hóa đơn";
            btn_CancelBill.UseVisualStyleBackColor = false;
            btn_CancelBill.Click += btn_CancelBill_Click;
            // 
            // btn_PayBill
            // 
            btn_PayBill.BackColor = Color.FromArgb(233, 197, 57);
            btn_PayBill.ForeColor = Color.Black;
            btn_PayBill.Location = new Point(564, 403);
            btn_PayBill.Name = "btn_PayBill";
            btn_PayBill.Size = new Size(194, 37);
            btn_PayBill.TabIndex = 96;
            btn_PayBill.Text = "Thanh toán";
            btn_PayBill.UseVisualStyleBackColor = false;
            btn_PayBill.Click += btn_PayBill_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(810, 416);
            label5.Name = "label5";
            label5.Size = new Size(69, 24);
            label5.TabIndex = 94;
            label5.Text = "Tổng tiền";
            // 
            // dgv_Payment
            // 
            dgv_Payment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Payment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Payment.Location = new Point(19, 159);
            dgv_Payment.Name = "dgv_Payment";
            dgv_Payment.RowHeadersWidth = 51;
            dgv_Payment.RowTemplate.Height = 29;
            dgv_Payment.Size = new Size(1105, 238);
            dgv_Payment.TabIndex = 90;
            dgv_Payment.CellClick += dgv_Payment_CellClick;
            // 
            // nbr_Num
            // 
            nbr_Num.Location = new Point(525, 76);
            nbr_Num.Name = "nbr_Num";
            nbr_Num.Size = new Size(233, 32);
            nbr_Num.TabIndex = 88;
            // 
            // btn_AddBill
            // 
            btn_AddBill.BackColor = Color.FromArgb(233, 197, 57);
            btn_AddBill.ForeColor = Color.Black;
            btn_AddBill.Location = new Point(14, 403);
            btn_AddBill.Name = "btn_AddBill";
            btn_AddBill.Size = new Size(194, 37);
            btn_AddBill.TabIndex = 82;
            btn_AddBill.Text = "Thêm hóa đơn";
            btn_AddBill.UseVisualStyleBackColor = false;
            btn_AddBill.Click += btn_AddBill_Click;
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
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources._while;
            groupBox1.Controls.Add(rtx_StaffName);
            groupBox1.Controls.Add(rtx_CusName);
            groupBox1.Controls.Add(rtx_BillID);
            groupBox1.Controls.Add(cbx_StaffID);
            groupBox1.Controls.Add(cbx_CusID);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(dtp_Date);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(31, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1133, 121);
            groupBox1.TabIndex = 91;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thanh toán";
            // 
            // rtx_StaffName
            // 
            rtx_StaffName.Location = new Point(885, 76);
            rtx_StaffName.Name = "rtx_StaffName";
            rtx_StaffName.Size = new Size(234, 32);
            rtx_StaffName.TabIndex = 102;
            // 
            // rtx_CusName
            // 
            rtx_CusName.Location = new Point(524, 77);
            rtx_CusName.Name = "rtx_CusName";
            rtx_CusName.Size = new Size(234, 32);
            rtx_CusName.TabIndex = 101;
            // 
            // rtx_BillID
            // 
            rtx_BillID.Location = new Point(145, 36);
            rtx_BillID.Name = "rtx_BillID";
            rtx_BillID.Size = new Size(234, 32);
            rtx_BillID.TabIndex = 89;
            // 
            // cbx_StaffID
            // 
            cbx_StaffID.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_StaffID.FormattingEnabled = true;
            cbx_StaffID.Location = new Point(885, 38);
            cbx_StaffID.Name = "cbx_StaffID";
            cbx_StaffID.Size = new Size(234, 30);
            cbx_StaffID.TabIndex = 100;
            cbx_StaffID.SelectedIndexChanged += cbx_StaffID_SelectedIndexChanged;
            // 
            // cbx_CusID
            // 
            cbx_CusID.Font = new Font("Bahnschrift Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_CusID.FormattingEnabled = true;
            cbx_CusID.Location = new Point(524, 38);
            cbx_CusID.Name = "cbx_CusID";
            cbx_CusID.Size = new Size(234, 30);
            cbx_CusID.TabIndex = 99;
            cbx_CusID.SelectedIndexChanged += cbx_CusID_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(782, 47);
            label10.Name = "label10";
            label10.Size = new Size(97, 24);
            label10.TabIndex = 84;
            label10.Text = "Mã nhân viên";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(782, 84);
            label11.Name = "label11";
            label11.Size = new Size(100, 24);
            label11.TabIndex = 85;
            label11.Text = "Tên nhân viên";
            // 
            // dtp_Date
            // 
            dtp_Date.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_Date.Location = new Point(145, 76);
            dtp_Date.Name = "dtp_Date";
            dtp_Date.Size = new Size(234, 32);
            dtp_Date.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 50);
            label2.Name = "label2";
            label2.Size = new Size(85, 24);
            label2.TabIndex = 69;
            label2.Text = "Mã hóa đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(395, 47);
            label3.Name = "label3";
            label3.Size = new Size(109, 24);
            label3.TabIndex = 71;
            label3.Text = "Mã khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(395, 84);
            label4.Name = "label4";
            label4.Size = new Size(112, 24);
            label4.TabIndex = 74;
            label4.Text = "Tên khách hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(14, 84);
            label7.Name = "label7";
            label7.Size = new Size(124, 24);
            label7.TabIndex = 78;
            label7.Text = "Ngày lập hóa đơn";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(504, 81);
            label9.Name = "label9";
            label9.Size = new Size(157, 28);
            label9.TabIndex = 90;
            label9.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // panel8
            // 
            panel8.Controls.Add(label1);
            panel8.Controls.Add(cButton7);
            panel8.Controls.Add(rjTextBox1);
            panel8.Controls.Add(pictureBox1);
            panel8.Location = new Point(1, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1175, 78);
            panel8.TabIndex = 89;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(48, 48, 48);
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1053, 25);
            label1.Name = "label1";
            label1.Size = new Size(101, 24);
            label1.TabIndex = 1;
            label1.Text = "Đăng xuất";
            // 
            // cButton7
            // 
            cButton7.BackColor = Color.FromArgb(232, 232, 232);
            cButton7.BackgroundColor = Color.FromArgb(232, 232, 232);
            cButton7.BorderColor = Color.Transparent;
            cButton7.BorderRadius = 1;
            cButton7.BorderSize = 0;
            cButton7.FlatAppearance.BorderSize = 0;
            cButton7.FlatStyle = FlatStyle.Flat;
            cButton7.ForeColor = Color.Transparent;
            cButton7.Image = Properties.Resources.search;
            cButton7.Location = new Point(567, 20);
            cButton7.Name = "cButton7";
            cButton7.Size = new Size(81, 39);
            cButton7.TabIndex = 1;
            cButton7.TextColor = Color.Transparent;
            cButton7.UseVisualStyleBackColor = false;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = Color.FromArgb(232, 232, 232);
            rjTextBox1.BackgroundImageLayout = ImageLayout.None;
            rjTextBox1.BorderColor = Color.Transparent;
            rjTextBox1.BorderFocusColor = Color.Transparent;
            rjTextBox1.BorderSize = 1;
            rjTextBox1.Cursor = Cursors.IBeam;
            rjTextBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox1.ForeColor = Color.Black;
            rjTextBox1.Location = new Point(21, 20);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = true;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.Size = new Size(627, 39);
            rjTextBox1.TabIndex = 1;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(48, 48, 48);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1178, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Payment_co
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            Controls.Add(panel8);
            Name = "Payment_co";
            Size = new Size(1180, 729);
            Load += Payment_co_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Payment).EndInit();
            ((System.ComponentModel.ISupportInitialize)nbr_Num).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox rtx_TotalCash;
        private TextBox rtx_IntoCash;
        private TextBox rtx_Discount;
        private TextBox rtx_Price;
        private TextBox rtx_PName;
        private TextBox rtx_PID;
        private Button btn_Add;
        private Button btn_CancelBill;
        private Button btn_PayBill;
        private Label label5;
        private DataGridView dgv_Payment;
        private NumericUpDown nbr_Num;
        private Button btn_AddBill;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private GroupBox groupBox1;
        private TextBox rtx_StaffName;
        private TextBox rtx_CusName;
        private TextBox rtx_BillID;
        private ComboBox cbx_StaffID;
        private ComboBox cbx_CusID;
        private Label label10;
        private Label label11;
        private DateTimePicker dtp_Date;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label9;
        private Panel panel8;
        private Label label1;
        private CButton cButton7;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private PictureBox pictureBox1;
    }
}
