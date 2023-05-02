namespace FaruSneaker
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            txt_username = new TextBox();
            txt_pass = new TextBox();
            cButton1 = new CButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(514, 284);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 1);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(514, 334);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 1);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(352, 234);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 6;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(252, 196, 25);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(682, 359);
            button1.Name = "button1";
            button1.Size = new Size(132, 43);
            button1.TabIndex = 7;
            button1.Text = "ĐĂNG NHẬP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.FromArgb(35, 35, 35);
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.ForeColor = Color.White;
            txt_username.Location = new Point(564, 243);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Tên đăng nhập";
            txt_username.Size = new Size(250, 33);
            txt_username.TabIndex = 2;
            txt_username.TextChanged += textBox1_TextChanged;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.FromArgb(28, 28, 28);
            txt_pass.BorderStyle = BorderStyle.None;
            txt_pass.Cursor = Cursors.IBeam;
            txt_pass.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.ForeColor = Color.White;
            txt_pass.Location = new Point(564, 298);
            txt_pass.Name = "txt_pass";
            txt_pass.PlaceholderText = "Mật khẩu";
            txt_pass.Size = new Size(250, 33);
            txt_pass.TabIndex = 3;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // cButton1
            // 
            cButton1.BackColor = Color.Transparent;
            cButton1.BackgroundColor = Color.Transparent;
            cButton1.BorderColor = Color.Transparent;
            cButton1.BorderRadius = 0;
            cButton1.BorderSize = 0;
            cButton1.FlatAppearance.BorderSize = 0;
            cButton1.FlatStyle = FlatStyle.Flat;
            cButton1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cButton1.ForeColor = Color.White;
            cButton1.Location = new Point(474, 364);
            cButton1.Name = "cButton1";
            cButton1.Size = new Size(178, 38);
            cButton1.TabIndex = 11;
            cButton1.Text = "Quên mật khẩu";
            cButton1.TextColor = Color.White;
            cButton1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nền;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(920, 510);
            Controls.Add(cButton1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txt_pass);
            Controls.Add(pictureBox2);
            Controls.Add(txt_username);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "ĐĂNG NHẬP";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button1;
        private TextBox txt_username;
        private TextBox txt_pass;
        private CButton cButton1;
    }
}