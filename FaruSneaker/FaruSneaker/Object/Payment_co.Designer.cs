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
            btn_Service = new Button();
            rtx_TotalCash = new TextBox();
            btn_Add = new Button();
            btn_CancelBill = new Button();
            btn_PayBill = new Button();
            label5 = new Label();
            dgv_Payment = new DataGridView();
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
            btn_Search = new CButton();
            rtx_Search = new CustomControls.RJControls.RJTextBox();
            pictureBox1 = new PictureBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Payment).BeginInit();
            groupBox1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources._while;
            groupBox2.Controls.Add(btn_Service);
            groupBox2.Controls.Add(rtx_TotalCash);
            groupBox2.Controls.Add(btn_Add);
            groupBox2.Controls.Add(btn_CancelBill);
            groupBox2.Controls.Add(btn_PayBill);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dgv_Payment);
            groupBox2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(31, 242);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1133, 446);
            groupBox2.TabIndex = 92;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // btn_Service
            // 
            btn_Service.BackColor = Color.FromArgb(233, 197, 57);
            btn_Service.ForeColor = Color.Black;
            btn_Service.Location = new Point(524, 40);
            btn_Service.Name = "btn_Service";
            btn_Service.Size = new Size(194, 37);
            btn_Service.TabIndex = 109;
            btn_Service.Text = "Dịch vụ";
            btn_Service.UseVisualStyleBackColor = false;
            btn_Service.Click += btn_Service_Click;
            // 
            // rtx_TotalCash
            // 
            rtx_TotalCash.Location = new Point(885, 408);
            rtx_TotalCash.Name = "rtx_TotalCash";
            rtx_TotalCash.Size = new Size(234, 32);
            rtx_TotalCash.TabIndex = 108;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(233, 197, 57);
            btn_Add.ForeColor = Color.Black;
            btn_Add.Location = new Point(185, 40);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(194, 37);
            btn_Add.TabIndex = 99;
            btn_Add.Text = "Giày dép";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_CancelBill
            // 
            btn_CancelBill.BackColor = Color.FromArgb(233, 197, 57);
            btn_CancelBill.ForeColor = Color.Black;
            btn_CancelBill.Location = new Point(185, 403);
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
            btn_PayBill.Location = new Point(524, 403);
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
            dgv_Payment.Location = new Point(19, 101);
            dgv_Payment.Name = "dgv_Payment";
            dgv_Payment.RowHeadersWidth = 51;
            dgv_Payment.RowTemplate.Height = 29;
            dgv_Payment.Size = new Size(1105, 296);
            dgv_Payment.TabIndex = 90;
            dgv_Payment.CellClick += dgv_Payment_CellClick;
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
            panel8.Controls.Add(btn_Search);
            panel8.Controls.Add(rtx_Search);
            panel8.Controls.Add(pictureBox1);
            panel8.Location = new Point(1, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1175, 78);
            panel8.TabIndex = 89;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = Color.FromArgb(232, 232, 232);
            btn_Search.BackgroundColor = Color.FromArgb(232, 232, 232);
            btn_Search.BorderColor = Color.Transparent;
            btn_Search.BorderRadius = 1;
            btn_Search.BorderSize = 0;
            btn_Search.FlatAppearance.BorderSize = 0;
            btn_Search.FlatStyle = FlatStyle.Flat;
            btn_Search.ForeColor = Color.Transparent;
            btn_Search.Image = Properties.Resources.search;
            btn_Search.Location = new Point(567, 20);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(81, 39);
            btn_Search.TabIndex = 1;
            btn_Search.TextColor = Color.Transparent;
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += cButton7_Click;
            // 
            // rtx_Search
            // 
            rtx_Search.BackColor = Color.FromArgb(232, 232, 232);
            rtx_Search.BackgroundImageLayout = ImageLayout.None;
            rtx_Search.BorderColor = Color.Transparent;
            rtx_Search.BorderFocusColor = Color.Transparent;
            rtx_Search.BorderSize = 1;
            rtx_Search.Cursor = Cursors.IBeam;
            rtx_Search.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtx_Search.ForeColor = Color.Black;
            rtx_Search.Location = new Point(21, 20);
            rtx_Search.Margin = new Padding(4);
            rtx_Search.Multiline = true;
            rtx_Search.Name = "rtx_Search";
            rtx_Search.Padding = new Padding(7);
            rtx_Search.PasswordChar = false;
            rtx_Search.Size = new Size(627, 39);
            rtx_Search.TabIndex = 1;
            rtx_Search.Texts = "";
            rtx_Search.UnderlinedStyle = false;
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox rtx_TotalCash;
        private Button btn_Add;
        private Button btn_CancelBill;
        private Button btn_PayBill;
        private Label label5;
        private DataGridView dgv_Payment;
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
        private CButton btn_Search;
        private CustomControls.RJControls.RJTextBox rtx_Search;
        private PictureBox pictureBox1;
        private Button btn_Service;
    }
}
