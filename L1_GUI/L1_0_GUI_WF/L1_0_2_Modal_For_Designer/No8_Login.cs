﻿//using DA_Loan_Spa._0_Class_Frm_Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
//P-1
using L2_DLL;
using L3_DAL;
using L4_DTO;

namespace L1_GUI
{
    public partial class frm_No8_Login : Form
    {
        public frm_No8_Login()
        {
            InitializeComponent();
        }

        private void No0_Small_size_FormClosing(object sender, FormClosingEventArgs e)
        {
            Part_0_1_PT_For_WF_Base_1 hs = new Part_0_1_PT_For_WF_Base_1();
            hs.NoticeWhenClosing(sender, e);

        }

        private void frm_No8_Login_Load(object sender, EventArgs e)
        {
            //1. load anh
            pic_TenPicture.Image = new Bitmap(Application.StartupPath+
                "\\P1_C_Sharp_png\\QLSinhVien\\account-login_1.png");
        }














        //4.2.n .. Test LK
        public void m1()
        {
            DB_Mau hs = new DB_Mau();
            Manager_DataBase_1 db0 = new Manager_DataBase_1();
            Part_0_2_PT_For_DataBase_1 db1 = new Part_0_2_PT_For_DataBase_1();
            Manager_HoaDon_1 db2 = new Manager_HoaDon_1();

        }

        //////////END-Class
    }
}
