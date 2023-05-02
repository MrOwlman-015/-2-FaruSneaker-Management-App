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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_ser = new System.Windows.Forms.Button();
            this.btn_employ = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_pay = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_product = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_customer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_account = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.payment_co2 = new FaruSneaker.Object.Payment_co();
            this.revenue_co2 = new FaruSneaker.Object.Revenue_co();
            this.account_co1 = new FaruSneaker.Object.Account_co();
            this.service_co1 = new FaruSneaker.Object.Service_co();
            this.products_co1 = new FaruSneaker.Object.Products_co();
            this.payment_co1 = new FaruSneaker.Object.Payment_co();
            this.employee_co1 = new FaruSneaker.Object.Employee_co();
            this.customer_co1 = new FaruSneaker.Object.Customer_co();
            this.revenue_co1 = new FaruSneaker.Object.Revenue_co();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(57)))));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.btn_ser);
            this.splitContainer1.Panel1.Controls.Add(this.btn_employ);
            this.splitContainer1.Panel1.Controls.Add(this.panel7);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            this.splitContainer1.Panel1.Controls.Add(this.panel5);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.payment_co2);
            this.splitContainer1.Panel2.Controls.Add(this.revenue_co2);
            this.splitContainer1.Panel2.Controls.Add(this.account_co1);
            this.splitContainer1.Panel2.Controls.Add(this.service_co1);
            this.splitContainer1.Panel2.Controls.Add(this.products_co1);
            this.splitContainer1.Panel2.Controls.Add(this.payment_co1);
            this.splitContainer1.Panel2.Controls.Add(this.employee_co1);
            this.splitContainer1.Panel2.Controls.Add(this.customer_co1);
            this.splitContainer1.Size = new System.Drawing.Size(1376, 704);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_ser
            // 
            this.btn_ser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(57)))));
            this.btn_ser.FlatAppearance.BorderSize = 0;
            this.btn_ser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ser.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ser.Image = global::FaruSneaker.Properties.Resources.service;
            this.btn_ser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ser.Location = new System.Drawing.Point(6, 476);
            this.btn_ser.Name = "btn_ser";
            this.btn_ser.Size = new System.Drawing.Size(186, 58);
            this.btn_ser.TabIndex = 10;
            this.btn_ser.Text = "Dịch vụ";
            this.btn_ser.UseVisualStyleBackColor = false;
            this.btn_ser.Click += new System.EventHandler(this.btn_ser_Click);
            // 
            // btn_employ
            // 
            this.btn_employ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(57)))));
            this.btn_employ.FlatAppearance.BorderSize = 0;
            this.btn_employ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employ.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_employ.Image = global::FaruSneaker.Properties.Resources.employees;
            this.btn_employ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_employ.Location = new System.Drawing.Point(3, 290);
            this.btn_employ.Name = "btn_employ";
            this.btn_employ.Size = new System.Drawing.Size(189, 58);
            this.btn_employ.TabIndex = 2;
            this.btn_employ.Text = "Nhân viên";
            this.btn_employ.UseVisualStyleBackColor = false;
            this.btn_employ.Click += new System.EventHandler(this.btn_employ_Click_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel7.Location = new System.Drawing.Point(6, 476);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(186, 58);
            this.panel7.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::FaruSneaker.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(3, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.btn_pay);
            this.panel6.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel6.Location = new System.Drawing.Point(6, 537);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(186, 58);
            this.panel6.TabIndex = 7;
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(57)))));
            this.btn_pay.FlatAppearance.BorderSize = 0;
            this.btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pay.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pay.Image = global::FaruSneaker.Properties.Resources.pay;
            this.btn_pay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pay.Location = new System.Drawing.Point(-3, 3);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(186, 58);
            this.btn_pay.TabIndex = 11;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.btn_product);
            this.panel5.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel5.Location = new System.Drawing.Point(6, 415);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(186, 58);
            this.panel5.TabIndex = 6;
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(57)))));
            this.btn_product.FlatAppearance.BorderSize = 0;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_product.Image = global::FaruSneaker.Properties.Resources.sneaker;
            this.btn_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_product.Location = new System.Drawing.Point(0, 0);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(183, 58);
            this.btn_product.TabIndex = 9;
            this.btn_product.Text = "Sản phẩm";
            this.btn_product.UseVisualStyleBackColor = false;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btn_customer);
            this.panel4.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(6, 354);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 58);
            this.panel4.TabIndex = 5;
            // 
            // btn_customer
            // 
            this.btn_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(57)))));
            this.btn_customer.FlatAppearance.BorderSize = 0;
            this.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_customer.Image = global::FaruSneaker.Properties.Resources.customer1;
            this.btn_customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customer.Location = new System.Drawing.Point(-6, 0);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(195, 58);
            this.btn_customer.TabIndex = 2;
            this.btn_customer.Text = "Khách hàng";
            this.btn_customer.UseVisualStyleBackColor = false;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_account);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(3, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 58);
            this.panel2.TabIndex = 3;
            // 
            // btn_account
            // 
            this.btn_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(57)))));
            this.btn_account.FlatAppearance.BorderSize = 0;
            this.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_account.Image = global::FaruSneaker.Properties.Resources.acc1;
            this.btn_account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_account.Location = new System.Drawing.Point(-3, 0);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(192, 58);
            this.btn_account.TabIndex = 1;
            this.btn_account.Text = "Tài khoản";
            this.btn_account.UseVisualStyleBackColor = false;
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(3, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 58);
            this.panel1.TabIndex = 2;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(57)))));
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_home.Image = global::FaruSneaker.Properties.Resources.homeicons1;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(-3, 4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(192, 58);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Trang chủ";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click_1);
            // 
            // payment_co2
            // 
            this.payment_co2.Location = new System.Drawing.Point(3, 5);
            this.payment_co2.Name = "payment_co2";
            this.payment_co2.Size = new System.Drawing.Size(1475, 911);
            this.payment_co2.TabIndex = 1;
            // 
            // revenue_co2
            // 
            this.revenue_co2.Location = new System.Drawing.Point(3, 3);
            this.revenue_co2.Name = "revenue_co2";
            this.revenue_co2.Size = new System.Drawing.Size(1472, 830);
            this.revenue_co2.TabIndex = 1;
            // 
            // account_co1
            // 
            this.account_co1.Location = new System.Drawing.Point(2, 3);
            this.account_co1.Name = "account_co1";
            this.account_co1.Size = new System.Drawing.Size(1179, 709);
            this.account_co1.TabIndex = 1;
            // 
            // service_co1
            // 
            this.service_co1.Location = new System.Drawing.Point(-1, 0);
            this.service_co1.Name = "service_co1";
            this.service_co1.Size = new System.Drawing.Size(1181, 701);
            this.service_co1.TabIndex = 1;
            // 
            // products_co1
            // 
            this.products_co1.Location = new System.Drawing.Point(1, 1);
            this.products_co1.Name = "products_co1";
            this.products_co1.Size = new System.Drawing.Size(1176, 830);
            this.products_co1.TabIndex = 1;
            // 
            // payment_co1
            // 
            this.payment_co1.Location = new System.Drawing.Point(-1, 3);
            this.payment_co1.Name = "payment_co1";
            this.payment_co1.Size = new System.Drawing.Size(1177, 738);
            this.payment_co1.TabIndex = 1;
            // 
            // employee_co1
            // 
            this.employee_co1.Location = new System.Drawing.Point(-4, 1);
            this.employee_co1.Name = "employee_co1";
            this.employee_co1.Size = new System.Drawing.Size(1184, 703);
            this.employee_co1.TabIndex = 1;
            // 
            // customer_co1
            // 
            this.customer_co1.Location = new System.Drawing.Point(-1, 0);
            this.customer_co1.Name = "customer_co1";
            this.customer_co1.Size = new System.Drawing.Size(1179, 697);
            this.customer_co1.TabIndex = 1;
            // 
            // revenue_co1
            // 
            this.revenue_co1.Location = new System.Drawing.Point(-4, 1);
            this.revenue_co1.Name = "revenue_co1";
            this.revenue_co1.Size = new System.Drawing.Size(1178, 664);
            this.revenue_co1.TabIndex = 1;
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 704);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Mainpage";
            this.Text = "Faru Sneaker";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Object.Revenue_co revenue_co1;
        private Object.Revenue_co revenue_co2;
        private Object.Payment_co payment_co2;
    }
}