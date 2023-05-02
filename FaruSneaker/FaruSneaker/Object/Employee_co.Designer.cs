namespace FaruSneaker.Object
{
    partial class Employee_co
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
            groupBox1 = new GroupBox();
            txt_ci = new TextBox();
            txt_add = new TextBox();
            txt_ephone = new TextBox();
            txt_ename = new TextBox();
            txt_eid = new TextBox();
            txt_salary = new TextBox();
            button4 = new Button();
            button5 = new Button();
            table_E = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            dob = new DateTimePicker();
            label6 = new Label();
            btn_remove = new Button();
            btn_update = new Button();
            label5 = new Label();
            label3 = new Label();
            label11 = new Label();
            btn_add = new Button();
            label2 = new Label();
            label4 = new Label();
            btn_search = new CButton();
            txt_search = new TextBox();
            pictureBox1 = new PictureBox();
            error = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)table_E).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txt_ci);
            groupBox1.Controls.Add(txt_add);
            groupBox1.Controls.Add(txt_ephone);
            groupBox1.Controls.Add(txt_ename);
            groupBox1.Controls.Add(txt_eid);
            groupBox1.Controls.Add(txt_salary);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(table_E);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dob);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btn_remove);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(31, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1133, 610);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // txt_ci
            // 
            txt_ci.Location = new Point(309, 138);
            txt_ci.Name = "txt_ci";
            txt_ci.Size = new Size(234, 32);
            txt_ci.TabIndex = 6;
            // 
            // txt_add
            // 
            txt_add.Location = new Point(872, 75);
            txt_add.Name = "txt_add";
            txt_add.Size = new Size(234, 32);
            txt_add.TabIndex = 4;
            // 
            // txt_ephone
            // 
            txt_ephone.Location = new Point(584, 75);
            txt_ephone.Name = "txt_ephone";
            txt_ephone.Size = new Size(234, 32);
            txt_ephone.TabIndex = 3;
            // 
            // txt_ename
            // 
            txt_ename.Location = new Point(309, 70);
            txt_ename.Name = "txt_ename";
            txt_ename.Size = new Size(234, 32);
            txt_ename.TabIndex = 2;
            // 
            // txt_eid
            // 
            txt_eid.Location = new Point(36, 69);
            txt_eid.Name = "txt_eid";
            txt_eid.Size = new Size(234, 32);
            txt_eid.TabIndex = 1;
            // 
            // txt_salary
            // 
            txt_salary.Location = new Point(584, 138);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(234, 32);
            txt_salary.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(233, 197, 57);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(288, 555);
            button4.Name = "button4";
            button4.Size = new Size(181, 37);
            button4.TabIndex = 9;
            button4.Text = "Thanh toán lương";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(233, 197, 57);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(89, 555);
            button5.Name = "button5";
            button5.Size = new Size(181, 37);
            button5.TabIndex = 8;
            button5.Text = "Chấm công";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // table_E
            // 
            table_E.AllowUserToAddRows = false;
            table_E.AllowUserToDeleteRows = false;
            table_E.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table_E.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_E.Location = new Point(89, 211);
            table_E.MultiSelect = false;
            table_E.Name = "table_E";
            table_E.ReadOnly = true;
            table_E.RowHeadersWidth = 51;
            table_E.RowTemplate.Height = 29;
            table_E.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table_E.Size = new Size(967, 329);
            table_E.TabIndex = 54;
            table_E.CellClick += table_E_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(584, 110);
            label8.Name = "label8";
            label8.Size = new Size(80, 24);
            label8.TabIndex = 50;
            label8.Text = "Mức lương";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(309, 111);
            label7.Name = "label7";
            label7.Size = new Size(43, 24);
            label7.TabIndex = 48;
            label7.Text = "CCCD";
            // 
            // dob
            // 
            dob.Location = new Point(36, 138);
            dob.Name = "dob";
            dob.Size = new Size(234, 32);
            dob.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 110);
            label6.Name = "label6";
            label6.Size = new Size(74, 24);
            label6.TabIndex = 45;
            label6.Text = "Ngày sinh";
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.FromArgb(233, 197, 57);
            btn_remove.ForeColor = Color.Black;
            btn_remove.Location = new Point(690, 555);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(181, 37);
            btn_remove.TabIndex = 11;
            btn_remove.Text = "Xóa ";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += button3_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(233, 197, 57);
            btn_update.ForeColor = Color.Black;
            btn_update.Location = new Point(899, 555);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(181, 37);
            btn_update.TabIndex = 12;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(872, 42);
            label5.Name = "label5";
            label5.Size = new Size(55, 24);
            label5.TabIndex = 41;
            label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(309, 42);
            label3.Name = "label3";
            label3.Size = new Size(119, 24);
            label3.TabIndex = 39;
            label3.Text = "Họ tên nhân viên";
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
            label11.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(233, 197, 57);
            btn_add.ForeColor = Color.Black;
            btn_add.Location = new Point(486, 555);
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
            label2.Text = "Mã nhân viên";
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
            btn_search.Location = new Point(573, 23);
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
            txt_search.Location = new Point(63, 23);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(591, 40);
            txt_search.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(48, 48, 48);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1178, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // error
            // 
            error.ContainerControl = this;
            // 
            // Employee_co
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(pictureBox1);
            Name = "Employee_co";
            Size = new Size(1183, 690);
            Load += Employee_co_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)table_E).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)error).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_ci;
        private TextBox txt_add;
        private TextBox txt_ephone;
        private TextBox txt_ename;
        private TextBox txt_eid;
        private TextBox txt_salary;
        private Button button4;
        private Button button5;
        private DataGridView table_E;
        private Label label8;
        private Label label7;
        private DateTimePicker dob;
        private Label label6;
        private Button btn_remove;
        private Button btn_update;
        private Label label5;
        private Label label3;
        private Label label11;
        private Button btn_add;
        private Label label2;
        private Label label4;
        private CButton btn_search;
        private TextBox txt_search;
        private PictureBox pictureBox1;
        private ErrorProvider error;
    }
}
