namespace L1_GUI
{
    partial class frm_DangKyCNganh
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
            this.btn_DangKyCNganh = new System.Windows.Forms.Button();
            this.gb_TenGB = new System.Windows.Forms.GroupBox();
            this.cb_TenCNganh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_TenKhoa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_SV_chuaDK = new System.Windows.Forms.DataGridView();
            this.lab_Button = new System.Windows.Forms.Label();
            this.pl_TenPL.SuspendLayout();
            this.gb_TenGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV_chuaDK)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Test3
            // 
            this.btn_Test3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Test3.Location = new System.Drawing.Point(871, 513);
            this.btn_Test3.Name = "btn_Test3";
            this.btn_Test3.Size = new System.Drawing.Size(75, 36);
            this.btn_Test3.TabIndex = 8;
            this.btn_Test3.Text = "Test 3";
            this.btn_Test3.UseVisualStyleBackColor = true;
            // 
            // btn_Test2
            // 
            this.btn_Test2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Test2.Location = new System.Drawing.Point(769, 513);
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
            this.btn_Test1.Location = new System.Drawing.Point(672, 513);
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
            this.pl_TenPL.Controls.Add(this.btn_DangKyCNganh);
            this.pl_TenPL.Controls.Add(this.gb_TenGB);
            this.pl_TenPL.Controls.Add(this.groupBox2);
            this.pl_TenPL.Location = new System.Drawing.Point(26, 75);
            this.pl_TenPL.Name = "pl_TenPL";
            this.pl_TenPL.Size = new System.Drawing.Size(930, 432);
            this.pl_TenPL.TabIndex = 26;
            // 
            // btn_DangKyCNganh
            // 
            this.btn_DangKyCNganh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DangKyCNganh.Location = new System.Drawing.Point(420, 174);
            this.btn_DangKyCNganh.Name = "btn_DangKyCNganh";
            this.btn_DangKyCNganh.Size = new System.Drawing.Size(92, 41);
            this.btn_DangKyCNganh.TabIndex = 34;
            this.btn_DangKyCNganh.Text = "Đăng ký";
            this.btn_DangKyCNganh.UseVisualStyleBackColor = true;
            this.btn_DangKyCNganh.Click += new System.EventHandler(this.btn_DangKyCNganh_Click);
            // 
            // gb_TenGB
            // 
            this.gb_TenGB.Controls.Add(this.cb_TenCNganh);
            this.gb_TenGB.Controls.Add(this.label1);
            this.gb_TenGB.Controls.Add(this.cb_TenKhoa);
            this.gb_TenGB.Controls.Add(this.label5);
            this.gb_TenGB.Location = new System.Drawing.Point(22, 18);
            this.gb_TenGB.Name = "gb_TenGB";
            this.gb_TenGB.Size = new System.Drawing.Size(894, 150);
            this.gb_TenGB.TabIndex = 30;
            this.gb_TenGB.TabStop = false;
            this.gb_TenGB.Text = "Chi tiết ...";
            // 
            // cb_TenCNganh
            // 
            this.cb_TenCNganh.FormattingEnabled = true;
            this.cb_TenCNganh.Location = new System.Drawing.Point(369, 82);
            this.cb_TenCNganh.Name = "cb_TenCNganh";
            this.cb_TenCNganh.Size = new System.Drawing.Size(242, 24);
            this.cb_TenCNganh.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Chuyên ngành: ";
            // 
            // cb_TenKhoa
            // 
            this.cb_TenKhoa.FormattingEnabled = true;
            this.cb_TenKhoa.Location = new System.Drawing.Point(369, 21);
            this.cb_TenKhoa.Name = "cb_TenKhoa";
            this.cb_TenKhoa.Size = new System.Drawing.Size(242, 24);
            this.cb_TenKhoa.TabIndex = 43;
            this.cb_TenKhoa.SelectedIndexChanged += new System.EventHandler(this.cb_TenKhoa_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Khoa: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_SV_chuaDK);
            this.groupBox2.Location = new System.Drawing.Point(16, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 188);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách SV chua D.Ky CNganh";
            // 
            // dgv_SV_chuaDK
            // 
            this.dgv_SV_chuaDK.AllowUserToAddRows = false;
            this.dgv_SV_chuaDK.AllowUserToDeleteRows = false;
            this.dgv_SV_chuaDK.AllowUserToResizeColumns = false;
            this.dgv_SV_chuaDK.AllowUserToResizeRows = false;
            this.dgv_SV_chuaDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SV_chuaDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SV_chuaDK.Location = new System.Drawing.Point(3, 18);
            this.dgv_SV_chuaDK.Name = "dgv_SV_chuaDK";
            this.dgv_SV_chuaDK.ReadOnly = true;
            this.dgv_SV_chuaDK.RowHeadersWidth = 51;
            this.dgv_SV_chuaDK.RowTemplate.Height = 24;
            this.dgv_SV_chuaDK.Size = new System.Drawing.Size(894, 167);
            this.dgv_SV_chuaDK.TabIndex = 18;
            // 
            // lab_Button
            // 
            this.lab_Button.AutoSize = true;
            this.lab_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Button.ForeColor = System.Drawing.Color.Blue;
            this.lab_Button.Location = new System.Drawing.Point(287, 19);
            this.lab_Button.Name = "lab_Button";
            this.lab_Button.Size = new System.Drawing.Size(372, 38);
            this.lab_Button.TabIndex = 27;
            this.lab_Button.Text = "Đăng ký chuyên ngành";
            // 
            // frm_DangKyCNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 578);
            this.Controls.Add(this.lab_Button);
            this.Controls.Add(this.pl_TenPL);
            this.Controls.Add(this.btn_Test3);
            this.Controls.Add(this.btn_Test2);
            this.Controls.Add(this.btn_Test1);
            this.Name = "frm_DangKyCNganh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKyCNganh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_No1_Test_FormClosing);
            this.Load += new System.EventHandler(this.frm_No4_dgv_txt_btn_Load);
            this.pl_TenPL.ResumeLayout(false);
            this.gb_TenGB.ResumeLayout(false);
            this.gb_TenGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV_chuaDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Test3;
        private System.Windows.Forms.Button btn_Test2;
        private System.Windows.Forms.Button btn_Test1;
        private System.Windows.Forms.Panel pl_TenPL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_SV_chuaDK;
        private System.Windows.Forms.Label lab_Button;
        private System.Windows.Forms.GroupBox gb_TenGB;
        private System.Windows.Forms.Button btn_DangKyCNganh;
        private System.Windows.Forms.ComboBox cb_TenCNganh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_TenKhoa;
        private System.Windows.Forms.Label label5;
    }
}