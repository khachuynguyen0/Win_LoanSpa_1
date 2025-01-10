namespace L1_GUI
{
    partial class frm_LoanSpa_00_Login
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
            this.pic_TenPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_TenGB = new System.Windows.Forms.GroupBox();
            this.btn_login_DangKy = new System.Windows.Forms.Button();
            this.btn_login_DangNhap = new System.Windows.Forms.Button();
            this.txt_Login_MatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Login_TaiKhoan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TenPicture)).BeginInit();
            this.gb_TenGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_TenPicture
            // 
            this.pic_TenPicture.Location = new System.Drawing.Point(22, 65);
            this.pic_TenPicture.Name = "pic_TenPicture";
            this.pic_TenPicture.Size = new System.Drawing.Size(166, 166);
            this.pic_TenPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_TenPicture.TabIndex = 43;
            this.pic_TenPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 38);
            this.label1.TabIndex = 44;
            this.label1.Text = "Đăng Nhập";
            // 
            // gb_TenGB
            // 
            this.gb_TenGB.Controls.Add(this.btn_login_DangKy);
            this.gb_TenGB.Controls.Add(this.btn_login_DangNhap);
            this.gb_TenGB.Controls.Add(this.txt_Login_MatKhau);
            this.gb_TenGB.Controls.Add(this.label3);
            this.gb_TenGB.Controls.Add(this.label2);
            this.gb_TenGB.Controls.Add(this.txt_Login_TaiKhoan);
            this.gb_TenGB.Location = new System.Drawing.Point(208, 65);
            this.gb_TenGB.Name = "gb_TenGB";
            this.gb_TenGB.Size = new System.Drawing.Size(240, 166);
            this.gb_TenGB.TabIndex = 45;
            this.gb_TenGB.TabStop = false;
            this.gb_TenGB.Text = "Nhập thông tin";
            // 
            // btn_login_DangKy
            // 
            this.btn_login_DangKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login_DangKy.Location = new System.Drawing.Point(147, 115);
            this.btn_login_DangKy.Name = "btn_login_DangKy";
            this.btn_login_DangKy.Size = new System.Drawing.Size(87, 36);
            this.btn_login_DangKy.TabIndex = 47;
            this.btn_login_DangKy.Text = "Đăng Ký";
            this.btn_login_DangKy.UseVisualStyleBackColor = true;
            // 
            // btn_login_DangNhap
            // 
            this.btn_login_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login_DangNhap.Location = new System.Drawing.Point(38, 115);
            this.btn_login_DangNhap.Name = "btn_login_DangNhap";
            this.btn_login_DangNhap.Size = new System.Drawing.Size(100, 36);
            this.btn_login_DangNhap.TabIndex = 46;
            this.btn_login_DangNhap.Text = "Đăng Nhập";
            this.btn_login_DangNhap.UseVisualStyleBackColor = true;
            this.btn_login_DangNhap.Click += new System.EventHandler(this.btn_login_DangNhap_Click);
            // 
            // txt_Login_MatKhau
            // 
            this.txt_Login_MatKhau.Location = new System.Drawing.Point(111, 74);
            this.txt_Login_MatKhau.Name = "txt_Login_MatKhau";
            this.txt_Login_MatKhau.PasswordChar = '*';
            this.txt_Login_MatKhau.Size = new System.Drawing.Size(123, 22);
            this.txt_Login_MatKhau.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mật khẩu: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tài khoản: ";
            // 
            // txt_Login_TaiKhoan
            // 
            this.txt_Login_TaiKhoan.Location = new System.Drawing.Point(111, 36);
            this.txt_Login_TaiKhoan.Name = "txt_Login_TaiKhoan";
            this.txt_Login_TaiKhoan.Size = new System.Drawing.Size(123, 22);
            this.txt_Login_TaiKhoan.TabIndex = 15;
            // 
            // frm_LoanSpa_00_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 270);
            this.Controls.Add(this.gb_TenGB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_TenPicture);
            this.Name = "frm_LoanSpa_00_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoanSpa_00_Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.No0_Small_size_FormClosing);
            this.Load += new System.EventHandler(this.frm_No8_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_TenPicture)).EndInit();
            this.gb_TenGB.ResumeLayout(false);
            this.gb_TenGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_TenPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_TenGB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Login_TaiKhoan;
        private System.Windows.Forms.TextBox txt_Login_MatKhau;
        private System.Windows.Forms.Button btn_login_DangNhap;
        private System.Windows.Forms.Button btn_login_DangKy;
    }
}