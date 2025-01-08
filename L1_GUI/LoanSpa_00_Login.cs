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
//
//P-1
using L2_DLL;
using L3_DAL;
using L4_DTO;

namespace L1_GUI
{
    public partial class frm_LoanSpa_00_Login : Form
    {

        Part_0_1_PT_For_WF_Base_1 par0 = new Part_0_1_PT_For_WF_Base_1();
        Manager_TaiKhoan_1 mn_TaiKhoan_1=new Manager_TaiKhoan_1();


        public frm_LoanSpa_00_Login()
        {
            InitializeComponent();
        }









        /// <summary>

        private void No0_Small_size_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Part_0_1_PT_For_WF_Base_1 hs = new Part_0_1_PT_For_WF_Base_1();
            //hs.NoticeWhenClosing(sender, e);

        }

        private void frm_No8_Login_Load(object sender, EventArgs e)
        {
            //1. load anh
            pic_TenPicture.Image = new Bitmap(Application.StartupPath+
                "\\P1_C_Sharp_png\\QLSpa\\account_login_1.png");

            btn_login_DangNhap.BackColor = Color.LightGreen;


        }

        //0. config
        public void Set_MD_Login_At_D() {
            txt_Login_TaiKhoan.Text = "";
            txt_Login_MatKhau.Text = "";
            txt_Login_TaiKhoan.Focus();
        }



        //1. KT]
        public void DangNhap_At_D()
        {
            string taiKhoan = txt_Login_TaiKhoan.Text;
            string matKhau = txt_Login_MatKhau.Text;

            //1.KT
            if (mn_TaiKhoan_1.CoTonTai_TK_MK_Theo_Login(taiKhoan, matKhau) == true)
            {
                MessageBox.Show("Đăng nhập: thành công!!!");

                //Get quyen tu TK_MK
                DataTable dt_temp_1 = new DataTable();
                dt_temp_1=mn_TaiKhoan_1.Get_iQuyenDT_From_TaiKhoan_Va_MatKhau_GetDataTable(taiKhoan, matKhau);
                int iQuyen = Convert.ToInt32(dt_temp_1.Rows[0]["iMaQuyen"]);


                //MessageBox.Show("dana: "+taiKhoan +"\n"+
                //    "dana: " + matKhau + "\n" +
                //    "dana: " + iQuyen //+ "\n" +

                //    );

                //<Goi main CT>
                frm_LoanSpa_Main_01 hs =new frm_LoanSpa_Main_01 (iQuyen, taiKhoan, matKhau);
                hs.ShowDialog();

                //this.Hide();
                this.Close();
                //hs.ShowDialog();



            }
            else {
                MessageBox.Show("Đăng nhập: Thất bại!!!"  +"\n"+
                    ">====================<" + "\n" +
                    "Vui lòng nhập lại"// + "\n" +
                    );

                //  
                Set_MD_Login_At_D();
                return;
            }



        }










        //4.2.n .. Test LK
        public void m1()
        {
            DB_Mau hs = new DB_Mau();
            Manager_DataBase_1 db0 = new Manager_DataBase_1();
            Part_0_2_PT_For_DataBase_1 db1 = new Part_0_2_PT_For_DataBase_1();
            Manager_HoaDon_1 db2 = new Manager_HoaDon_1();

        }

        private void btn_login_DangNhap_Click(object sender, EventArgs e)
        {
            DangNhap_At_D();
        }

        //////////END-Class
    }
}
