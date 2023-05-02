namespace FaruSneaker
{
    partial class Mainpage
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
            splitContainer1 = new SplitContainer();
            btn_employ = new Button();
            panel7 = new Panel();
            btn_ser = new Button();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            btn_pay = new Button();
            panel5 = new Panel();
            btn_product = new Button();
            panel4 = new Panel();
            btn_customer = new Button();
            panel2 = new Panel();
            btn_account = new Button();
            panel1 = new Panel();
            btn_home = new Button();
            account_co1 = new Object.Account_co();
            service_co1 = new Object.Service_co();
            products_co1 = new Object.Products_co();
            payment_co1 = new Object.Payment_co();
            employee_co1 = new Object.Employee_co();
            customer_co1 = new Object.Customer_co();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(223, 194, 57);
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(btn_employ);
            splitContainer1.Panel1.Controls.Add(panel7);
            splitContainer1.Panel1.Controls.Add(pictureBox2);
            splitContainer1.Panel1.Controls.Add(panel6);
            splitContainer1.Panel1.Controls.Add(panel5);
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(account_co1);
            splitContainer1.Panel2.Controls.Add(service_co1);
            splitContainer1.Panel2.Controls.Add(products_co1);
            splitContainer1.Panel2.Controls.Add(payment_co1);
            splitContainer1.Panel2.Controls.Add(employee_co1);
            splitContainer1.Panel2.Controls.Add(customer_co1);
            splitContainer1.Size = new Size(1376, 704);
            splitContainer1.SplitterDistance = 192;
            splitContainer1.TabIndex = 0;
            // 
            // btn_employ
            // 
            btn_employ.BackColor = Color.FromArgb(223, 194, 57);
            btn_employ.FlatAppearance.BorderSize = 0;
            btn_employ.FlatStyle = FlatStyle.Flat;
            btn_employ.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_employ.ImageAlign = ContentAlignment.MiddleLeft;
            btn_employ.Location = new Point(3, 290);
            btn_employ.Name = "btn_employ";
            btn_employ.Size = new Size(189, 58);
            btn_employ.TabIndex = 2;
            btn_employ.Text = "Nhân viên";
            btn_employ.UseVisualStyleBackColor = false;
            btn_employ.Click += btn_employ_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.Controls.Add(btn_ser);
            panel7.Font = new Font("Tahoma", 7.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel7.Location = new Point(6, 476);
            panel7.Name = "panel7";
            panel7.Size = new Size(186, 58);
            panel7.TabIndex = 8;
            // 
            // btn_ser
            // 
            btn_ser.BackColor = Color.FromArgb(223, 194, 57);
            btn_ser.FlatAppearance.BorderSize = 0;
            btn_ser.FlatStyle = FlatStyle.Flat;
            btn_ser.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ser.Location = new Point(6, 0);
            btn_ser.Name = "btn_ser";
            btn_ser.Size = new Size(155, 58);
            btn_ser.TabIndex = 10;
            btn_ser.Text = "Dịch vụ";
            btn_ser.UseVisualStyleBackColor = false;
            btn_ser.Click += btn_ser_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(3, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(189, 164);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(btn_pay);
            panel6.Font = new Font("Tahoma", 7.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel6.Location = new Point(6, 537);
            panel6.Name = "panel6";
            panel6.Size = new Size(186, 58);
            panel6.TabIndex = 7;
            // 
            // btn_pay
            // 
            btn_pay.BackColor = Color.FromArgb(223, 194, 57);
            btn_pay.FlatAppearance.BorderSize = 0;
            btn_pay.FlatStyle = FlatStyle.Flat;
            btn_pay.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_pay.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pay.Location = new Point(-6, -3);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(195, 58);
            btn_pay.TabIndex = 11;
            btn_pay.Text = "Thanh toán";
            btn_pay.UseVisualStyleBackColor = false;
            btn_pay.Click += btn_pay_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(btn_product);
            panel5.Font = new Font("Tahoma", 7.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(6, 415);
            panel5.Name = "panel5";
            panel5.Size = new Size(186, 58);
            panel5.TabIndex = 6;
            // 
            // btn_product
            // 
            btn_product.BackColor = Color.FromArgb(223, 194, 57);
            btn_product.FlatAppearance.BorderSize = 0;
            btn_product.FlatStyle = FlatStyle.Flat;
            btn_product.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_product.ImageAlign = ContentAlignment.MiddleLeft;
            btn_product.Location = new Point(0, 0);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(183, 58);
            btn_product.TabIndex = 9;
            btn_product.Text = "Sản phẩm";
            btn_product.UseVisualStyleBackColor = false;
            btn_product.Click += btn_product_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(btn_customer);
            panel4.Font = new Font("Tahoma", 7.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(6, 354);
            panel4.Name = "panel4";
            panel4.Size = new Size(186, 58);
            panel4.TabIndex = 5;
            // 
            // btn_customer
            // 
            btn_customer.BackColor = Color.FromArgb(223, 194, 57);
            btn_customer.FlatAppearance.BorderSize = 0;
            btn_customer.FlatStyle = FlatStyle.Flat;
            btn_customer.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_customer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_customer.Location = new Point(-6, 0);
            btn_customer.Name = "btn_customer";
            btn_customer.Size = new Size(208, 58);
            btn_customer.TabIndex = 2;
            btn_customer.Text = "Khách hàng";
            btn_customer.UseVisualStyleBackColor = false;
            btn_customer.Click += btn_customer_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btn_account);
            panel2.Font = new Font("Tahoma", 7.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(3, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 58);
            panel2.TabIndex = 3;
            // 
            // btn_account
            // 
            btn_account.BackColor = Color.FromArgb(223, 194, 57);
            btn_account.FlatAppearance.BorderSize = 0;
            btn_account.FlatStyle = FlatStyle.Flat;
            btn_account.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_account.ImageAlign = ContentAlignment.MiddleLeft;
            btn_account.Location = new Point(-3, 0);
            btn_account.Name = "btn_account";
            btn_account.Size = new Size(192, 58);
            btn_account.TabIndex = 1;
            btn_account.Text = "Tài khoản";
            btn_account.UseVisualStyleBackColor = false;
            btn_account.Click += btn_account_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btn_home);
            panel1.Font = new Font("Tahoma", 7.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(3, 171);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 58);
            panel1.TabIndex = 2;
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.FromArgb(223, 194, 57);
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_home.Image = Properties.Resources.homeicons1;
            btn_home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home.Location = new Point(-3, 4);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(192, 58);
            btn_home.TabIndex = 0;
            btn_home.Text = "Trang chủ";
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
            // 
            // account_co1
            // 
            account_co1.Location = new Point(2, 3);
            account_co1.Name = "account_co1";
            account_co1.Size = new Size(1179, 709);
            account_co1.TabIndex = 1;
            // 
            // service_co1
            // 
            service_co1.Location = new Point(-1, 0);
            service_co1.Name = "service_co1";
            service_co1.Size = new Size(1181, 701);
            service_co1.TabIndex = 1;
            // 
            // products_co1
            // 
            products_co1.Location = new Point(1, 1);
            products_co1.Name = "products_co1";
            products_co1.Size = new Size(1176, 830);
            products_co1.TabIndex = 1;
            // 
            // payment_co1
            // 
            payment_co1.Location = new Point(-1, 3);
            payment_co1.Name = "payment_co1";
            payment_co1.Size = new Size(1177, 738);
            payment_co1.TabIndex = 1;
            payment_co1.Load += payment_co1_Load;
            // 
            // employee_co1
            // 
            employee_co1.Location = new Point(-4, 1);
            employee_co1.Name = "employee_co1";
            employee_co1.Size = new Size(1184, 703);
            employee_co1.TabIndex = 1;
            // 
            // customer_co1
            // 
            customer_co1.Location = new Point(-1, 0);
            customer_co1.Name = "customer_co1";
            customer_co1.Size = new Size(1179, 697);
            customer_co1.TabIndex = 1;
            // 
            // Mainpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 704);
            Controls.Add(splitContainer1);
            Name = "Mainpage";
            Text = "TRANG CHỦ";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private Panel panel7;
        private Button btn_account;
        private Button btn_home;
        private Button btn_employ;
        private Button btn_product;
        private Button btn_customer;
        private Button btn_ser;
        private Button btn_pay;
        private Object.Employee_co employee_co1;
        private Object.Customer_co customer_co1;
        private Object.Payment_co payment_co1;
        private Object.Service_co service_co1;
        private Object.Products_co products_co1;
        private Object.Account_co account_co1;
    }
}