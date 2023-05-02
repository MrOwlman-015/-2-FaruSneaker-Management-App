namespace FaruSneaker.Object
{
    partial class Service_co
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            txt_Price = new TextBox();
            rtx_Description = new RichTextBox();
            txt_Name = new TextBox();
            txt_ID = new TextBox();
            dgv_service = new DataGridView();
            btn_Update = new Button();
            btn_Remove = new Button();
            label11 = new Label();
            btn_Add = new Button();
            btn_Clear = new Button();
            lbl_ID = new Label();
            lbl_Description = new Label();
            lbl_Name = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btn_search = new CButton();
            txt_search = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_service).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_Price);
            groupBox1.Controls.Add(rtx_Description);
            groupBox1.Controls.Add(txt_Name);
            groupBox1.Controls.Add(txt_ID);
            groupBox1.Controls.Add(dgv_service);
            groupBox1.Controls.Add(btn_Update);
            groupBox1.Controls.Add(btn_Remove);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(btn_Add);
            groupBox1.Controls.Add(btn_Clear);
            groupBox1.Controls.Add(lbl_ID);
            groupBox1.Controls.Add(lbl_Description);
            groupBox1.Controls.Add(lbl_Name);
            groupBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(32, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1133, 622);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN DỊCH VỤ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 119);
            label2.Name = "label2";
            label2.Size = new Size(59, 24);
            label2.TabIndex = 39;
            label2.Text = "Đơn giá";
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(15, 146);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(234, 32);
            txt_Price.TabIndex = 38;
            // 
            // rtx_Description
            // 
            rtx_Description.Location = new Point(15, 222);
            rtx_Description.Name = "rtx_Description";
            rtx_Description.Size = new Size(505, 224);
            rtx_Description.TabIndex = 37;
            rtx_Description.Text = "";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(286, 69);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(234, 32);
            txt_Name.TabIndex = 35;
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(15, 68);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(234, 32);
            txt_ID.TabIndex = 34;
            // 
            // dgv_service
            // 
            dgv_service.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_service.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_service.Location = new Point(546, 69);
            dgv_service.Name = "dgv_service";
            dgv_service.RowHeadersWidth = 51;
            dgv_service.RowTemplate.Height = 29;
            dgv_service.Size = new Size(564, 458);
            dgv_service.TabIndex = 33;
            dgv_service.CellClick += dgv_service_CellClick;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.FromArgb(233, 197, 57);
            btn_Update.ForeColor = Color.Black;
            btn_Update.Location = new Point(286, 495);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(133, 37);
            btn_Update.TabIndex = 32;
            btn_Update.Text = "Cập nhật ";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.BackColor = Color.FromArgb(233, 197, 57);
            btn_Remove.ForeColor = Color.Black;
            btn_Remove.Location = new Point(101, 495);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(133, 37);
            btn_Remove.TabIndex = 31;
            btn_Remove.Text = "Xóa ";
            btn_Remove.UseVisualStyleBackColor = false;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(780, 41);
            label11.Name = "label11";
            label11.Size = new Size(121, 24);
            label11.TabIndex = 30;
            label11.Text = "THEO DÕI DỊCH VỤ";
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(233, 197, 57);
            btn_Add.ForeColor = Color.Black;
            btn_Add.Location = new Point(101, 452);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(133, 37);
            btn_Add.TabIndex = 28;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.FromArgb(224, 224, 224);
            btn_Clear.ForeColor = Color.Black;
            btn_Clear.Location = new Point(286, 452);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(133, 37);
            btn_Clear.TabIndex = 27;
            btn_Clear.Text = "Xóa tùy chọn";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ID.Location = new Point(15, 41);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(81, 24);
            lbl_ID.TabIndex = 9;
            lbl_ID.Text = "Mã dịch vụ";
            // 
            // lbl_Description
            // 
            lbl_Description.AutoSize = true;
            lbl_Description.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Description.Location = new Point(15, 195);
            lbl_Description.Name = "lbl_Description";
            lbl_Description.Size = new Size(46, 24);
            lbl_Description.TabIndex = 13;
            lbl_Description.Text = "Mô tả";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Name.Location = new Point(286, 41);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(84, 24);
            lbl_Name.TabIndex = 11;
            lbl_Name.Text = "Tên dịch vụ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(48, 48, 48);
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1059, 28);
            label1.Name = "label1";
            label1.Size = new Size(101, 24);
            label1.TabIndex = 9;
            label1.Text = "Đăng xuất";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(48, 48, 48);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1178, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
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
            btn_search.Location = new Point(571, 18);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(81, 39);
            btn_search.TabIndex = 54;
            btn_search.TextColor = Color.Transparent;
            btn_search.UseVisualStyleBackColor = false;
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.FromArgb(232, 232, 232);
            txt_search.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(61, 18);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(591, 40);
            txt_search.TabIndex = 55;
            // 
            // Service_co
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Service_co";
            Size = new Size(1182, 711);
            Load += Service_co_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_service).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox txt_Price;
        private RichTextBox rtx_Description;
        private TextBox txt_Name;
        private TextBox txt_ID;
        private DataGridView dgv_service;
        private Button btn_Update;
        private Button btn_Remove;
        private Label label11;
        private Button btn_Add;
        private Button btn_Clear;
        private Label lbl_ID;
        private Label lbl_Description;
        private Label lbl_Name;
        private Label label1;
        private PictureBox pictureBox1;
        private CButton btn_search;
        private TextBox txt_search;
    }
}
