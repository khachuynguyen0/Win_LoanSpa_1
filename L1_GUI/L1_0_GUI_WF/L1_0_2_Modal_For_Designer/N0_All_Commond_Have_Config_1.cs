using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//P-1
using L2_DLL;
using L3_DAL;
using L4_DTO;

namespace L1_GUI
{
    public partial class frm_N0_All_Commond_Have_Config_1 : Form
    {
        public frm_N0_All_Commond_Have_Config_1()
        {
            InitializeComponent();
        }



        private void txt_OnlyDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //BD

            //1. Chi Cho Nhap So
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Vui lòng Nhập: Số");
            }

            //End
        }

        private void txt_OnlyText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //BD

            //2. Chi Cho Nhap Chu (VD: Họ tên)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Vui lòng Nhập: Chữ");
            }

            //End
        }

        private void frm_No2_All_Commond_Have_Config_1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_OnlySoThuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //BD

            //txt_DiemTB.MaxLength = 3;//vd 8.5
            //3. Chi Cho Nhap So: So Thuc(VD: Diem TB)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                //MessageBox.Show("Vui lòng Nhập: Số");
            }

            //END
        }

        private void frm_N0_All_Commond_Have_Config_1_Load(object sender, EventArgs e)
        {

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
