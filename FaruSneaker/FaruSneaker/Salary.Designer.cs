namespace FaruSneaker
{
    partial class Salary
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
            this.tb_eid = new System.Windows.Forms.TextBox();
            this.tb_ename = new System.Windows.Forms.TextBox();
            this.dgv_salary = new System.Windows.Forms.DataGridView();
            this.btn_blank = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_timekp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_eid
            // 
            this.tb_eid.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_eid.Location = new System.Drawing.Point(27, 137);
            this.tb_eid.Name = "tb_eid";
            this.tb_eid.Size = new System.Drawing.Size(246, 35);
            this.tb_eid.TabIndex = 71;
            // 
            // tb_ename
            // 
            this.tb_ename.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ename.Location = new System.Drawing.Point(27, 200);
            this.tb_ename.Name = "tb_ename";
            this.tb_ename.Size = new System.Drawing.Size(246, 35);
            this.tb_ename.TabIndex = 70;
            // 
            // dgv_salary
            // 
            this.dgv_salary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salary.Location = new System.Drawing.Point(297, 108);
            this.dgv_salary.Name = "dgv_salary";
            this.dgv_salary.RowHeadersWidth = 51;
            this.dgv_salary.RowTemplate.Height = 29;
            this.dgv_salary.Size = new System.Drawing.Size(757, 463);
            this.dgv_salary.TabIndex = 69;
            // 
            // btn_blank
            // 
            this.btn_blank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(197)))), ((int)(((byte)(57)))));
            this.btn_blank.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_blank.ForeColor = System.Drawing.Color.Black;
            this.btn_blank.Location = new System.Drawing.Point(27, 345);
            this.btn_blank.Name = "btn_blank";
            this.btn_blank.Size = new System.Drawing.Size(181, 37);
            this.btn_blank.TabIndex = 68;
            this.btn_blank.Text = "Xóa bảng lương";
            this.btn_blank.UseVisualStyleBackColor = false;
            this.btn_blank.Click += new System.EventHandler(this.btn_blank_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(197)))), ((int)(((byte)(57)))));
            this.button1.Location = new System.Drawing.Point(454, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 37);
            this.button1.TabIndex = 67;
            this.button1.Text = "LƯƠNG NHÂN VIÊN";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_timekp
            // 
            this.btn_timekp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(197)))), ((int)(((byte)(57)))));
            this.btn_timekp.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_timekp.ForeColor = System.Drawing.Color.Black;
            this.btn_timekp.Location = new System.Drawing.Point(27, 286);
            this.btn_timekp.Name = "btn_timekp";
            this.btn_timekp.Size = new System.Drawing.Size(181, 37);
            this.btn_timekp.TabIndex = 66;
            this.btn_timekp.Text = "IN BIÊN LAI";
            this.btn_timekp.UseVisualStyleBackColor = false;
            this.btn_timekp.Click += new System.EventHandler(this.btn_timekp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 65;
            this.label3.Text = "Họ tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 64;
            this.label2.Text = "Mã nhân viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1085, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 602);
            this.Controls.Add(this.tb_eid);
            this.Controls.Add(this.tb_ename);
            this.Controls.Add(this.dgv_salary);
            this.Controls.Add(this.btn_blank);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_timekp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Salary";
            this.Text = "Salary";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_eid;
        private TextBox tb_ename;
        private DataGridView dgv_salary;
        private Button btn_blank;
        private Button button1;
        private Button btn_timekp;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}