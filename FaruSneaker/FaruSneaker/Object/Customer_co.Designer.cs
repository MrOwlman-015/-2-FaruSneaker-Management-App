namespace FaruSneaker.Object
{
    partial class Customer_co
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
            txt_search = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txt_type = new TextBox();
            txt_cphone = new TextBox();
            txt_cname = new TextBox();
            txt_cid = new TextBox();
            btn_delete = new Button();
            btn_update = new Button();
            label5 = new Label();
            label3 = new Label();
            table_C = new DataGridView();
            label11 = new Label();
            btn_add = new Button();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)table_C).BeginInit();
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
            btn_search.Location = new Point(570, 20);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(81, 39);
            btn_search.TabIndex = 50;
            btn_search.TextColor = Color.Transparent;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.FromArgb(232, 232, 232);
            txt_search.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(60, 20);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(591, 40);
            txt_search.TabIndex = 53;
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
            label1.TabIndex = 51;
            label1.Text = "Đăng xuất";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(48, 48, 48);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1178, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txt_type);
            groupBox1.Controls.Add(txt_cphone);
            groupBox1.Controls.Add(txt_cname);
            groupBox1.Controls.Add(txt_cid);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(table_C);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(28, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1133, 610);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // txt_type
            // 
            txt_type.Location = new Point(872, 79);
            txt_type.Name = "txt_type";
            txt_type.Size = new Size(230, 32);
            txt_type.TabIndex = 47;
            // 
            // txt_cphone
            // 
            txt_cphone.Location = new Point(584, 79);
            txt_cphone.Name = "txt_cphone";
            txt_cphone.Size = new Size(230, 32);
            txt_cphone.TabIndex = 46;
            // 
            // txt_cname
            // 
            txt_cname.Location = new Point(309, 79);
            txt_cname.Name = "txt_cname";
            txt_cname.Size = new Size(230, 32);
            txt_cname.TabIndex = 45;
            // 
            // txt_cid
            // 
            txt_cid.Location = new Point(36, 79);
            txt_cid.Name = "txt_cid";
            txt_cid.Size = new Size(230, 32);
            txt_cid.TabIndex = 44;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(233, 197, 57);
            btn_delete.ForeColor = Color.Black;
            btn_delete.Location = new Point(679, 546);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(181, 37);
            btn_delete.TabIndex = 43;
            btn_delete.Text = "Xóa ";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(233, 197, 57);
            btn_update.ForeColor = Color.Black;
            btn_update.Location = new Point(925, 546);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(181, 37);
            btn_update.TabIndex = 42;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(872, 42);
            label5.Name = "label5";
            label5.Size = new Size(72, 24);
            label5.TabIndex = 41;
            label5.Text = "Phân loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(309, 42);
            label3.Name = "label3";
            label3.Size = new Size(131, 24);
            label3.TabIndex = 39;
            label3.Text = "Họ tên khách hàng";
            // 
            // table_C
            // 
            table_C.AllowUserToAddRows = false;
            table_C.AllowUserToDeleteRows = false;
            table_C.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table_C.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_C.Location = new Point(36, 150);
            table_C.MultiSelect = false;
            table_C.Name = "table_C";
            table_C.ReadOnly = true;
            table_C.RowHeadersWidth = 51;
            table_C.RowTemplate.Height = 29;
            table_C.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_C.Size = new Size(1070, 390);
            table_C.TabIndex = 37;
            table_C.CellClick += table_C_CellClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Popup;
            label11.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(498, 120);
            label11.Name = "label11";
            label11.Size = new Size(147, 24);
            label11.TabIndex = 30;
            label11.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(233, 197, 57);
            btn_add.ForeColor = Color.Black;
            btn_add.Location = new Point(410, 546);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(181, 37);
            btn_add.TabIndex = 28;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 42);
            label2.Name = "label2";
            label2.Size = new Size(109, 24);
            label2.TabIndex = 9;
            label2.Text = "Mã khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(584, 42);
            label4.Name = "label4";
            label4.Size = new Size(96, 24);
            label4.TabIndex = 13;
            label4.Text = "Số điện thoại";
            // 
            // Customer_co
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "Customer_co";
            Size = new Size(1178, 689);
            Load += customer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)table_C).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CButton btn_search;
        private TextBox txt_search;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox txt_type;
        private TextBox txt_cphone;
        private TextBox txt_cname;
        private TextBox txt_cid;
        private Button btn_delete;
        private Button btn_update;
        private Label label5;
        private Label label3;
        private DataGridView table_C;
        private Label label11;
        private Button btn_add;
        private Label label2;
        private Label label4;
    }
}
