//using DA_Loan_Spa._0_Class_Frm_Support;
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
    public partial class frm_No3_3Tab_btn : Form
    {
        public frm_No3_3Tab_btn()
        {
            InitializeComponent();
        }

        private void frm_No1_Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Part_0_1_PT_For_WF_Base_1 hs = new Part_0_1_PT_For_WF_Base_1();
            hs.NoticeWhenClosing(sender, e);

        }

        private void btn_Test1_Click(object sender, EventArgs e)
        {
            tab_TenAllTab.SelectedIndex = 0;
        }

        private void btn_Test2_Click(object sender, EventArgs e)
        {
            tab_TenAllTab.SelectedIndex = 1;
        }

        private void btn_Test3_Click(object sender, EventArgs e)
        {
            tab_TenAllTab.SelectedIndex = 2;
        }

        private void frm_No3_3Tab_btn_Load(object sender, EventArgs e)
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
