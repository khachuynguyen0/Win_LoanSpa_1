namespace L1_GUI
{
    partial class frm_No7_Pic_btn
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
            this.pic_TenPicture = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_TenCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TenPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Test3
            // 
            this.btn_Test3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Test3.Location = new System.Drawing.Point(704, 390);
            this.btn_Test3.Name = "btn_Test3";
            this.btn_Test3.Size = new System.Drawing.Size(75, 36);
            this.btn_Test3.TabIndex = 11;
            this.btn_Test3.Text = "Test 3";
            this.btn_Test3.UseVisualStyleBackColor = true;
            // 
            // btn_Test2
            // 
            this.btn_Test2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Test2.Location = new System.Drawing.Point(602, 390);
            this.btn_Test2.Name = "btn_Test2";
            this.btn_Test2.Size = new System.Drawing.Size(75, 36);
            this.btn_Test2.TabIndex = 10;
            this.btn_Test2.Text = "Test 2";
            this.btn_Test2.UseVisualStyleBackColor = true;
            // 
            // btn_Test1
            // 
            this.btn_Test1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Test1.Location = new System.Drawing.Point(505, 390);
            this.btn_Test1.Name = "btn_Test1";
            this.btn_Test1.Size = new System.Drawing.Size(75, 36);
            this.btn_Test1.TabIndex = 9;
            this.btn_Test1.Text = "Test 1";
            this.btn_Test1.UseVisualStyleBackColor = true;
            // 
            // pic_TenPicture
            // 
            this.pic_TenPicture.Location = new System.Drawing.Point(38, 104);
            this.pic_TenPicture.Name = "pic_TenPicture";
            this.pic_TenPicture.Size = new System.Drawing.Size(741, 265);
            this.pic_TenPicture.TabIndex = 43;
            this.pic_TenPicture.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(138, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 16);
            this.label17.TabIndex = 44;
            this.label17.Text = "n. PictureBox: ";
            // 
            // cb_TenCB
            // 
            this.cb_TenCB.FormattingEnabled = true;
            this.cb_TenCB.Location = new System.Drawing.Point(274, 49);
            this.cb_TenCB.Name = "cb_TenCB";
            this.cb_TenCB.Size = new System.Drawing.Size(347, 24);
            this.cb_TenCB.TabIndex = 45;
            // 
            // frm_No7_Pic_btn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_TenCB);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pic_TenPicture);
            this.Controls.Add(this.btn_Test3);
            this.Controls.Add(this.btn_Test2);
            this.Controls.Add(this.btn_Test1);
            this.Name = "frm_No7_Pic_btn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No7_Pic_btn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_No2_Nomal_size_FormClosing);
            this.Load += new System.EventHandler(this.frm_No7_Pic_btn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_TenPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Test3;
        private System.Windows.Forms.Button btn_Test2;
        private System.Windows.Forms.Button btn_Test1;
        private System.Windows.Forms.PictureBox pic_TenPicture;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_TenCB;
    }
}