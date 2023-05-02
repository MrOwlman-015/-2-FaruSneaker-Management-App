namespace FaruSneaker
{
    partial class Timek
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dgv_timek = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_timekp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_tk = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_id.Location = new System.Drawing.Point(29, 113);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(246, 35);
            this.txt_id.TabIndex = 77;
            // 
            // dgv_timek
            // 
            this.dgv_timek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_timek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_timek.Location = new System.Drawing.Point(299, 84);
            this.dgv_timek.Name = "dgv_timek";
            this.dgv_timek.RowHeadersWidth = 51;
            this.dgv_timek.RowTemplate.Height = 29;
            this.dgv_timek.Size = new System.Drawing.Size(757, 463);
            this.dgv_timek.TabIndex = 76;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(197)))), ((int)(((byte)(57)))));
            this.button1.Location = new System.Drawing.Point(456, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 37);
            this.button1.TabIndex = 75;
            this.button1.Text = "CHẤM CÔNG";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_timekp
            // 
            this.btn_timekp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(197)))), ((int)(((byte)(57)))));
            this.btn_timekp.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_timekp.ForeColor = System.Drawing.Color.Black;
            this.btn_timekp.Location = new System.Drawing.Point(29, 246);
            this.btn_timekp.Name = "btn_timekp";
            this.btn_timekp.Size = new System.Drawing.Size(181, 37);
            this.btn_timekp.TabIndex = 74;
            this.btn_timekp.Text = "ĐI LÀM";
            this.btn_timekp.UseVisualStyleBackColor = false;
            this.btn_timekp.Click += new System.EventHandler(this.btn_timekp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 73;
            this.label2.Text = "Mã nhân viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1085, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_tk
            // 
            this.dtp_tk.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_tk.Location = new System.Drawing.Point(29, 178);
            this.dtp_tk.Name = "dtp_tk";
            this.dtp_tk.Size = new System.Drawing.Size(250, 32);
            this.dtp_tk.TabIndex = 78;
            this.dtp_tk.ValueChanged += new System.EventHandler(this.dtp_tk_ValueChanged);
            // 
            // Timek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 575);
            this.Controls.Add(this.dtp_tk);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dgv_timek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_timekp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Timek";
            this.Text = "Timek";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_id;
        private DataGridView dgv_timek;
        private Button button1;
        private Button btn_timekp;
        private Label label2;
        private PictureBox pictureBox1;
        private DateTimePicker dtp_tk;
    }
}