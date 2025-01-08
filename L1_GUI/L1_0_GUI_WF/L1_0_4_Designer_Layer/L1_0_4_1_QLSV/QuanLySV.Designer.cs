namespace L1_GUI
{
    partial class frm_QuanLySV
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
            this.btn_Test3 = new System.Windows.Forms.Button();
            this.btn_Test2 = new System.Windows.Forms.Button();
            this.btn_Test1 = new System.Windows.Forms.Button();
            this.pl_TenPL = new System.Windows.Forms.Panel();
            this.btn_ChiTiet_SV = new System.Windows.Forms.Button();
            this.btn_Them_SV = new System.Windows.Forms.Button();
            this.btn_Sua_SV = new System.Windows.Forms.Button();
            this.btn_Xoa_SV = new System.Windows.Forms.Button();
            this.gb_TenGB = new System.Windows.Forms.GroupBox();
            this.cb_TenCB = new System.Windows.Forms.ComboBox();
            this.txt_MaSo = new System.Windows.Forms.TextBox();
            this.txt_DiemTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_SinhVien = new System.Windows.Forms.DataGridView();
            this.lab_Button = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_AnhSV = new System.Windows.Forms.PictureBox();
            this.chk_DK_CNganh = new System.Windows.Forms.CheckBox();
            this.pl_TenPL.SuspendLayout();
            this.gb_TenGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Test3
            // 
            this.btn_Test3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Test3.Location = new System.Drawing.Point(874, 657);
            this.btn_Test3.Name = "btn_Test3";
            this.btn_Test3.Size = new System.Drawing.Size(75, 36);
            this.btn_Test3.TabIndex = 8;
            this.btn_Test3.Text = "Test 3";
            this.btn_Test3.UseVisualStyleBackColor = true;
            // 
            // btn_Test2
            // 
            this.btn_Test2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Test2.Location = new System.Drawing.Point(772, 657);
            this.btn_Test2.Name = "btn_Test2";
            this.btn_Test2.Size = new System.Drawing.Size(75, 36);
            this.btn_Test2.TabIndex = 7;
            this.btn_Test2.Text = "Test 2";
            this.btn_Test2.UseVisualStyleBackColor = true;
            this.btn_Test2.Click += new System.EventHandler(this.btn_Test2_Click);
            // 
            // btn_Test1
            // 
            this.btn_Test1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Test1.Location = new System.Drawing.Point(675, 657);
            this.btn_Test1.Name = "btn_Test1";
            this.btn_Test1.Size = new System.Drawing.Size(75, 36);
            this.btn_Test1.TabIndex = 6;
            this.btn_Test1.Text = "Test 1";
            this.btn_Test1.UseVisualStyleBackColor = true;
            this.btn_Test1.Click += new System.EventHandler(this.btn_Test1_Click);
            // 
            // pl_TenPL
            // 
            this.pl_TenPL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pl_TenPL.Controls.Add(this.btn_ChiTiet_SV);
            this.pl_TenPL.Controls.Add(this.btn_Them_SV);
            this.pl_TenPL.Controls.Add(this.btn_Sua_SV);
            this.pl_TenPL.Controls.Add(this.btn_Xoa_SV);
            this.pl_TenPL.Controls.Add(this.gb_TenGB);
            this.pl_TenPL.Controls.Add(this.groupBox2);
            this.pl_TenPL.Location = new System.Drawing.Point(26, 75);
            this.pl_TenPL.Name = "pl_TenPL";
            this.pl_TenPL.Size = new System.Drawing.Size(930, 576);
            this.pl_TenPL.TabIndex = 26;
            // 
            // btn_ChiTiet_SV
            // 
            this.btn_ChiTiet_SV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ChiTiet_SV.Location = new System.Drawing.Point(533, 311);
            this.btn_ChiTiet_SV.Name = "btn_ChiTiet_SV";
            this.btn_ChiTiet_SV.Size = new System.Drawing.Size(92, 41);
            this.btn_ChiTiet_SV.TabIndex = 34;
            this.btn_ChiTiet_SV.Text = "Chi Tiết";
            this.btn_ChiTiet_SV.UseVisualStyleBackColor = true;
            // 
            // btn_Them_SV
            // 
            this.btn_Them_SV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Them_SV.Location = new System.Drawing.Point(631, 311);
            this.btn_Them_SV.Name = "btn_Them_SV";
            this.btn_Them_SV.Size = new System.Drawing.Size(92, 41);
            this.btn_Them_SV.TabIndex = 33;
            this.btn_Them_SV.Text = "Thêm";
            this.btn_Them_SV.UseVisualStyleBackColor = true;
            this.btn_Them_SV.Click += new System.EventHandler(this.btn_Them_SV_Click);
            // 
            // btn_Sua_SV
            // 
            this.btn_Sua_SV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sua_SV.Location = new System.Drawing.Point(729, 311);
            this.btn_Sua_SV.Name = "btn_Sua_SV";
            this.btn_Sua_SV.Size = new System.Drawing.Size(92, 41);
            this.btn_Sua_SV.TabIndex = 32;
            this.btn_Sua_SV.Text = "Sửa";
            this.btn_Sua_SV.UseVisualStyleBackColor = true;
            this.btn_Sua_SV.Click += new System.EventHandler(this.btn_Sua_SV_Click);
            // 
            // btn_Xoa_SV
            // 
            this.btn_Xoa_SV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Xoa_SV.Location = new System.Drawing.Point(827, 311);
            this.btn_Xoa_SV.Name = "btn_Xoa_SV";
            this.btn_Xoa_SV.Size = new System.Drawing.Size(92, 41);
            this.btn_Xoa_SV.TabIndex = 31;
            this.btn_Xoa_SV.Text = "Xóa";
            this.btn_Xoa_SV.UseVisualStyleBackColor = true;
            this.btn_Xoa_SV.Click += new System.EventHandler(this.btn_Xoa_SV_Click);
            // 
            // gb_TenGB
            // 
            this.gb_TenGB.Controls.Add(this.pic_AnhSV);
            this.gb_TenGB.Controls.Add(this.label1);
            this.gb_TenGB.Controls.Add(this.cb_TenCB);
            this.gb_TenGB.Controls.Add(this.txt_MaSo);
            this.gb_TenGB.Controls.Add(this.txt_DiemTB);
            this.gb_TenGB.Controls.Add(this.label6);
            this.gb_TenGB.Controls.Add(this.label5);
            this.gb_TenGB.Controls.Add(this.txt_HoTen);
            this.gb_TenGB.Controls.Add(this.label4);
            this.gb_TenGB.Controls.Add(this.label3);
            this.gb_TenGB.Location = new System.Drawing.Point(22, 18);
            this.gb_TenGB.Name = "gb_TenGB";
            this.gb_TenGB.Size = new System.Drawing.Size(894, 265);
            this.gb_TenGB.TabIndex = 30;
            this.gb_TenGB.TabStop = false;
            this.gb_TenGB.Text = "Chi tiết ...";
            // 
            // cb_TenCB
            // 
            this.cb_TenCB.FormattingEnabled = true;
            this.cb_TenCB.Location = new System.Drawing.Point(554, 18);
            this.cb_TenCB.Name = "cb_TenCB";
            this.cb_TenCB.Size = new System.Drawing.Size(242, 24);
            this.cb_TenCB.TabIndex = 41;
            // 
            // txt_MaSo
            // 
            this.txt_MaSo.Location = new System.Drawing.Point(134, 18);
            this.txt_MaSo.Name = "txt_MaSo";
            this.txt_MaSo.Size = new System.Drawing.Size(245, 22);
            this.txt_MaSo.TabIndex = 32;
            this.txt_MaSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaSo_KeyPress);
            // 
            // txt_DiemTB
            // 
            this.txt_DiemTB.Location = new System.Drawing.Point(554, 63);
            this.txt_DiemTB.Name = "txt_DiemTB";
            this.txt_DiemTB.Size = new System.Drawing.Size(245, 22);
            this.txt_DiemTB.TabIndex = 30;
            this.txt_DiemTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DiemTB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Điểm TB: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Khoa: ";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(134, 65);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(245, 22);
            this.txt_HoTen.TabIndex = 25;
            this.txt_HoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_HoTen_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Họ Tên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã Số: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_SinhVien);
            this.groupBox2.Location = new System.Drawing.Point(22, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 188);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách ...";
            // 
            // dgv_SinhVien
            // 
            this.dgv_SinhVien.AllowUserToAddRows = false;
            this.dgv_SinhVien.AllowUserToDeleteRows = false;
            this.dgv_SinhVien.AllowUserToResizeColumns = false;
            this.dgv_SinhVien.AllowUserToResizeRows = false;
            this.dgv_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SinhVien.Location = new System.Drawing.Point(3, 18);
            this.dgv_SinhVien.Name = "dgv_SinhVien";
            this.dgv_SinhVien.ReadOnly = true;
            this.dgv_SinhVien.RowHeadersWidth = 51;
            this.dgv_SinhVien.RowTemplate.Height = 24;
            this.dgv_SinhVien.Size = new System.Drawing.Size(894, 167);
            this.dgv_SinhVien.TabIndex = 18;
            this.dgv_SinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SinhVien_CellClick);
            // 
            // lab_Button
            // 
            this.lab_Button.AutoSize = true;
            this.lab_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Button.ForeColor = System.Drawing.Color.Blue;
            this.lab_Button.Location = new System.Drawing.Point(342, 24);
            this.lab_Button.Name = "lab_Button";
            this.lab_Button.Size = new System.Drawing.Size(306, 38);
            this.lab_Button.TabIndex = 27;
            this.lab_Button.Text = "Quản Lý Sinh Viên";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Ảnh đại diện: ";
            // 
            // pic_AnhSV
            // 
            // this.pic_AnhSV.Image = global::NguyenKhacHuy_Week5_2280601183.Properties.Resources.girl_2;
            this.pic_AnhSV.Location = new System.Drawing.Point(134, 104);
            this.pic_AnhSV.Name = "pic_AnhSV";
            this.pic_AnhSV.Size = new System.Drawing.Size(145, 155);
            this.pic_AnhSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_AnhSV.TabIndex = 43;
            this.pic_AnhSV.TabStop = false;
            // 
            // chk_DK_CNganh
            // 
            this.chk_DK_CNganh.AutoSize = true;
            this.chk_DK_CNganh.Location = new System.Drawing.Point(785, 42);
            this.chk_DK_CNganh.Name = "chk_DK_CNganh";
            this.chk_DK_CNganh.Size = new System.Drawing.Size(171, 20);
            this.chk_DK_CNganh.TabIndex = 29;
            this.chk_DK_CNganh.Text = "Chưa ĐK Chuyên Ngành";
            this.chk_DK_CNganh.UseVisualStyleBackColor = true;
            this.chk_DK_CNganh.CheckedChanged += new System.EventHandler(this.chk_DK_CNganh_CheckedChanged);
            // 
            // frm_QuanLySV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 723);
            this.Controls.Add(this.chk_DK_CNganh);
            this.Controls.Add(this.lab_Button);
            this.Controls.Add(this.pl_TenPL);
            this.Controls.Add(this.btn_Test3);
            this.Controls.Add(this.btn_Test2);
            this.Controls.Add(this.btn_Test1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_QuanLySV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLySV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_No1_Test_FormClosing);
            this.Load += new System.EventHandler(this.frm_QuanLySV_Load);
            this.pl_TenPL.ResumeLayout(false);
            this.gb_TenGB.ResumeLayout(false);
            this.gb_TenGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Test3;
        private System.Windows.Forms.Button btn_Test2;
        private System.Windows.Forms.Button btn_Test1;
        private System.Windows.Forms.Panel pl_TenPL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_SinhVien;
        private System.Windows.Forms.Label lab_Button;
        private System.Windows.Forms.GroupBox gb_TenGB;
        private System.Windows.Forms.TextBox txt_DiemTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ChiTiet_SV;
        private System.Windows.Forms.Button btn_Them_SV;
        private System.Windows.Forms.Button btn_Sua_SV;
        private System.Windows.Forms.Button btn_Xoa_SV;
        private System.Windows.Forms.TextBox txt_MaSo;
        private System.Windows.Forms.ComboBox cb_TenCB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_AnhSV;
        private System.Windows.Forms.CheckBox chk_DK_CNganh;
    }
}