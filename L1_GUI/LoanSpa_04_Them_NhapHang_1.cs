//using DA_Loan_Spa._0_Class_Frm_Support;
//using DA_Loan_Spa._2_Xuly_Layer;
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
    public partial class frm_LoanSpa_04_Them_NhapHang_1 : Form
    {
        public frm_LoanSpa_04_Them_NhapHang_1()
        {
            InitializeComponent();
        }
        //B-2
        //2.1 "3_DataBase_Layer"
        Part_0_1_PT_For_WF_Base_1 part0 = new Part_0_1_PT_For_WF_Base_1();

        //2.1 "2_Xuly_Layer"
        Manager_tab_NCC_1 mn_NCC_1= new Manager_tab_NCC_1();
        Manager_tab_HangHoa_1 mn_HnagHoa_1 = new Manager_tab_HangHoa_1();



        //2.3 DataTables
        //DataTable dt_1_SV = new DataTable();




        //1.-n Load color btn
        public void LoadColorBtn() { 


            btn_ThemNH_NhapHang_1.BackColor=Color.LightGreen;
        }

        public void Load_Imgs() {
            //Nhap Hang       
            pb_HH_1.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\HangHoa_1.png");
            pb_HH_2.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\HangHoa_2.png");
            pb_HH_3.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\HangHoa_3.png");
            pb_HH_4.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\HangHoa_4.png");
            pb_HH_5.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\HangHoa_5.png");

            pb_HH_6.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\HangHoa_6.png");
            pb_HH_7.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\HangHoa_7.png");
            pb_HH_8.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\HangHoa_8.png");



            //
            pb_ThemNH_AnhHH_1.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\HH_1.png");
            pb_ThemNH_AnhNCC_1.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\NCC_1.png");

        }






















        //1.1 Load  tenNCC
        public void load_Cb_ThemNH_TenNCC_At_D()
        {
            //1 tao bien
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1=mn_NCC_1.Get_TenDT_GetDataTable();

            //2. chen ND 
            //ten
            cb_ThemNH_TenNCC.Items.Clear();
            foreach (DataRow dr in dt_temp_1.Rows) {
                cb_ThemNH_TenNCC.Items.Add(dr["tenNCC"].ToString());
                cb_ThemNH_TenNCC.SelectedIndex = 0;

            }

        }


        //1.1 Load  tenNCC
        public void load_Cb_ThemNH_TinhTrang_At_D()
        {
            cb_ThemNH_TinhTrang_1.Items.Clear();
            cb_ThemNH_TinhTrang_1.Items.Add("Đã thanh toán");
            cb_ThemNH_TinhTrang_1.Items.Add("Chưa thanh toán");
            cb_ThemNH_TinhTrang_1.SelectedIndex = 0;

        }


        //1.2 load sdt
        public void Load_Get_SDT_Theo_TenNCC_At_D() { 
            string tenNCC=cb_ThemNH_TenNCC.Text;
            //get maNCC
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1=mn_NCC_1.Get_MaDT_From_TenDT_GetDataTable(tenNCC);
            int maNCC = Convert.ToInt32(dt_temp_1.Rows[0]["maNCC"].ToString());

            //get SDT
            DataTable dt_temp_2 = new DataTable();
            dt_temp_2 = mn_NCC_1.Get_SDT_From_maNCC_GetDataTable(maNCC);
            string SDT = Convert.ToString(dt_temp_2.Rows[0]["SDT"].ToString());


           // MessageBox.Show(""+tenNCC+" | "+maNCC + " | " +SDT);
           cb_ThemNH_SDT.Items.Clear();
            cb_ThemNH_SDT.Items.Add(SDT);
            cb_ThemNH_SDT.SelectedIndex = 0;


        }


        //1.2 load tenDV, gia DV
        public void Load_TenDV_GiaDV_At_D() {
            //tao bien
           


            //HH 1
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1=mn_HnagHoa_1.Get_DT_GetDataTable();
            string ten_DT_1 = dt_temp_1.Rows[0]["tenHH"] != DBNull.Value
                ? Convert.ToString(dt_temp_1.Rows[0]["tenHH"])
                : "Không có tên";

            string giaMua_DT_1 = dt_temp_1.Rows[0]["giaMua"] != DBNull.Value
                ? Convert.ToDecimal(dt_temp_1.Rows[0]["giaMua"]).ToString("N0")
                : "0";

            //dan value
            lab_DT_1.Text = ten_DT_1;
            txt_GiaMua_HH_1.Text = "$"+ giaMua_DT_1;



            //HH 2
            DataTable dt_temp_2 = new DataTable();
            dt_temp_2 = mn_HnagHoa_1.Get_DT_GetDataTable();
            string ten_DT_2 = dt_temp_2.Rows[1]["tenHH"] != DBNull.Value
                ? Convert.ToString(dt_temp_2.Rows[1]["tenHH"])
                : "Không có tên";

            string giaMua_DT_2 = dt_temp_2.Rows[1]["giaMua"] != DBNull.Value
                ? Convert.ToDecimal(dt_temp_2.Rows[1]["giaMua"]).ToString("N0")
                : "0";

            //dan value
            lab_DT_2.Text = ten_DT_2;
            txt_GiaMua_HH_2.Text = "$" + giaMua_DT_2;




            //HH 3
            DataTable dt_temp_3 = new DataTable();
            dt_temp_3 = mn_HnagHoa_1.Get_DT_GetDataTable();
            string ten_DT_3 = dt_temp_3.Rows[2]["tenHH"] != DBNull.Value
                ? Convert.ToString(dt_temp_3.Rows[2]["tenHH"])
                : "Không có tên";

            string giaMua_DT_3 = dt_temp_3.Rows[2]["giaMua"] != DBNull.Value
                ? Convert.ToDecimal(dt_temp_3.Rows[2]["giaMua"]).ToString("N0")
                : "0";

            //dan value
            lab_DT_3.Text = ten_DT_3;
            txt_GiaMua_HH_3.Text = "$" + giaMua_DT_3;



            //HH 4
            DataTable dt_temp_4 = new DataTable();
            dt_temp_4 = mn_HnagHoa_1.Get_DT_GetDataTable();
            string ten_DT_4 = dt_temp_4.Rows[3]["tenHH"] != DBNull.Value
                ? Convert.ToString(dt_temp_4.Rows[3]["tenHH"])
                : "Không có tên";

            string giaMua_DT_4 = dt_temp_4.Rows[3]["giaMua"] != DBNull.Value
                ? Convert.ToDecimal(dt_temp_4.Rows[3]["giaMua"]).ToString("N0")
                : "0";

            //dan value
            lab_DT_4.Text = ten_DT_4;
            txt_GiaMua_HH_4.Text = "$" + giaMua_DT_4;





            //HH 5
            DataTable dt_temp_5 = new DataTable();
            dt_temp_5 = mn_HnagHoa_1.Get_DT_GetDataTable();
            string ten_DT_5 = dt_temp_5.Rows[4]["tenHH"] != DBNull.Value
                ? Convert.ToString(dt_temp_5.Rows[4]["tenHH"])
                : "Không có tên";

            string giaMua_DT_5 = dt_temp_5.Rows[4]["giaMua"] != DBNull.Value
                ? Convert.ToDecimal(dt_temp_5.Rows[4]["giaMua"]).ToString("N0")
                : "0";

            //dan value
            lab_DT_5.Text = ten_DT_5;
            txt_GiaMua_HH_5.Text = "$" + giaMua_DT_5;





            //HH 6
            DataTable dt_temp_6 = new DataTable();
            dt_temp_6 = mn_HnagHoa_1.Get_DT_GetDataTable();
            string ten_DT_6 = dt_temp_6.Rows[5]["tenHH"] != DBNull.Value
                ? Convert.ToString(dt_temp_6.Rows[5]["tenHH"])
                : "Không có tên";

            string giaMua_DT_6 = dt_temp_6.Rows[5]["giaMua"] != DBNull.Value
                ? Convert.ToDecimal(dt_temp_6.Rows[5]["giaMua"]).ToString("N0")
                : "0";

            //dan value
            lab_DT_6.Text = ten_DT_6;
            txt_GiaMua_HH_6.Text = "$" + giaMua_DT_6;





            //HH 7
            DataTable dt_temp_7 = new DataTable();
            dt_temp_7 = mn_HnagHoa_1.Get_DT_GetDataTable();
            string ten_DT_7 = dt_temp_7.Rows[6]["tenHH"] != DBNull.Value
                ? Convert.ToString(dt_temp_7.Rows[6]["tenHH"])
                : "Không có tên";

            string giaMua_DT_7 = dt_temp_7.Rows[6]["giaMua"] != DBNull.Value
                ? Convert.ToDecimal(dt_temp_7.Rows[6]["giaMua"]).ToString("N0")
                : "0";

            //dan value
            lab_DT_7.Text = ten_DT_7;
            txt_GiaMua_HH_7.Text = "$" + giaMua_DT_7;




            //HH 8
            DataTable dt_temp_8 = new DataTable();
            dt_temp_8 = mn_HnagHoa_1.Get_DT_GetDataTable();
            string ten_DT_8 = dt_temp_8.Rows[7]["tenHH"] != DBNull.Value
                ? Convert.ToString(dt_temp_8.Rows[7]["tenHH"])
                : "Không có tên";

            string giaMua_DT_8 = dt_temp_8.Rows[7]["giaMua"] != DBNull.Value
                ? Convert.ToDecimal(dt_temp_8.Rows[7]["giaMua"]).ToString("N0")
                : "0";

            //dan value
            lab_DT_8.Text = ten_DT_8;
            txt_GiaMua_HH_8.Text = "$" + giaMua_DT_8;

        }























        ///4.2.3 Do somything
        private decimal Get_GiaMua_From_ShowGiaMua_GetDecimal(string sShowGiaMua) {
            decimal giaMua=0;

            string h1;
            h1 = sShowGiaMua.Replace("$", "");
            //MessageBox.Show("" + h1);

            giaMua = Convert.ToDecimal(h1);
           // MessageBox.Show("" + a);

            return giaMua;
        }



        //===================================END======================
        private void frm_No1_Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Part_0_1_PT_For_WF_Base_1 hs = new Part_0_1_PT_For_WF_Base_1();
            hs.NoticeWhenClosing(sender, e);

        }




























        //4.2.n .. Test LK
        public void m1()
        {
            DB_Mau hs = new DB_Mau();
            Manager_DataBase_1 db0 = new Manager_DataBase_1();
            Part_0_2_PT_For_DataBase_1 db1 = new Part_0_2_PT_For_DataBase_1();
            Manager_HoaDon_1 db2 = new Manager_HoaDon_1();

        }

        private void frm_LoanSpa_04_Them_NhapHang_1_Load(object sender, EventArgs e)
        {
            //load mau btn
            LoadColorBtn();





            //Load imgs
            Load_Imgs();

            //Load 
            load_Cb_ThemNH_TenNCC_At_D();
            load_Cb_ThemNH_TinhTrang_At_D();


            //load _TenDV_GiaDV
            Load_TenDV_GiaDV_At_D();









        }

        private void btn_Test1_Click(object sender, EventArgs e)
        {
           decimal h1= Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_4.Text);
            MessageBox.Show("" + h1);
        }

        private void cb_ThemNH_TenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Get_SDT_Theo_TenNCC_At_D();
        }

        private void txt_GiaMua_HH_1_TextChanged(object sender, EventArgs e)
        {
            part0.TextBoxOnlyMoney(sender, e);
        }

        //////////END-Class
    }
}
