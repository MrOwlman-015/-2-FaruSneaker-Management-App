namespace FaruSneaker.Object
{
    partial class Account_co
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
            components = new System.ComponentModel.Container();
            btn_search = new CButton();
            txt_search = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txt_accrole = new TextBox();
            txt_accpass = new TextBox();
            txt_accname = new TextBox();
            table_ACC = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            label3 = new Label();
            label11 = new Label();
            btn_add = new Button();
            label2 = new Label();
            label4 = new Label();
            error = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)table_ACC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error).BeginInit();
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
            btn_search.TabIndex = 19;
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
            txt_search.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(48, 48, 48);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1178, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txt_accrole);
            groupBox1.Controls.Add(txt_accpass);
            groupBox1.Controls.Add(txt_accname);
            groupBox1.Controls.Add(table_ACC);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(28, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1133, 610);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý tài khoản";
            // 
            // txt_accrole
            // 
            txt_accrole.Location = new Point(822, 69);
            txt_accrole.Name = "txt_accrole";
            txt_accrole.Size = new Size(234, 32);
            txt_accrole.TabIndex = 3;
            // 
            // txt_accpass
            // 
            txt_accpass.Location = new Point(433, 69);
            txt_accpass.Name = "txt_accpass";
            txt_accpass.Size = new Size(234, 32);
            txt_accpass.TabIndex = 2;
            // 
            // txt_accname
            // 
            txt_accname.Location = new Point(36, 69);
            txt_accname.Name = "txt_accname";
            txt_accname.Size = new Size(234, 32);
            txt_accname.TabIndex = 1;
            // 
            // table_ACC
            // 
            table_ACC.AllowUserToAddRows = false;
            table_ACC.AllowUserToDeleteRows = false;
            table_ACC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table_ACC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_ACC.Location = new Point(89, 211);
            table_ACC.MultiSelect = false;
            table_ACC.Name = "table_ACC";
            table_ACC.ReadOnly = true;
            table_ACC.RowHeadersWidth = 51;
            table_ACC.RowTemplate.Height = 29;
            table_ACC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_ACC.Size = new Size(967, 393);
            table_ACC.TabIndex = 54;
            table_ACC.CellClick += table_ACC_CellClick;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(233, 197, 57);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(471, 122);
            button3.Name = "button3";
            button3.Size = new Size(181, 37);
            button3.TabIndex = 11;
            button3.Text = "Xóa ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(233, 197, 57);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(760, 122);
            button1.Name = "button1";
            button1.Size = new Size(181, 37);
            button1.TabIndex = 12;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(433, 42);
            label3.Name = "label3";
            label3.Size = new Size(70, 24);
            label3.TabIndex = 39;
            label3.Text = "Mật khẩu";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Popup;
            label11.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(485, 184);
            label11.Name = "label11";
            label11.Size = new Size(154, 24);
            label11.TabIndex = 30;
            label11.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(233, 197, 57);
            btn_add.ForeColor = Color.Black;
            btn_add.Location = new Point(198, 122);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(181, 37);
            btn_add.TabIndex = 10;
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
            label2.Size = new Size(97, 24);
            label2.TabIndex = 9;
            label2.Text = "Tên tài khoản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(822, 42);
            label4.Name = "label4";
            label4.Size = new Size(63, 24);
            label4.TabIndex = 13;
            label4.Text = "Chức vụ";
            // 
            // error
            // 
            error.ContainerControl = this;
            // 
            // Account_co
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "Account_co";
            Size = new Size(1178, 697);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)table_ACC).EndInit();
            ((System.ComponentModel.ISupportInitialize)error).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CButton btn_search;
        private TextBox txt_search;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox txt_accrole;
        private TextBox txt_accpass;
        private TextBox txt_accname;
        private DataGridView table_ACC;
        private Button button3;
        private Button button1;
        private Label label3;
        private Label label11;
        private Button btn_add;
        private Label label2;
        private Label label4;
        private ErrorProvider error;
    }
}
