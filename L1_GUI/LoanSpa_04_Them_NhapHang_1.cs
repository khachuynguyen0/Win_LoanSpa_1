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
        Manager_tab_ThemNH_1 mn_ThemNH_1 = new Manager_tab_ThemNH_1();
        Manager_tab_NH_1 mn_NhapHang_1=new Manager_tab_NH_1();
        Manager_CT_NHAPHANG_HANGHOA_1 mn_CT_NH_HH_1=new Manager_CT_NHAPHANG_HANGHOA_1();

        //2.3 DataTables
        //DataTable dt_1_SV = new DataTable();



        //0. Configs
        public void Set_ALL_Check_MD() { 
            ck_ThemNH_HH_1.Checked = false;
            ck_ThemNH_HH_2.Checked = false;
            ck_ThemNH_HH_3.Checked = false;
            ck_ThemNH_HH_4.Checked = false;
            ck_ThemNH_HH_5.Checked = false;
            ck_ThemNH_HH_6.Checked = false;
            ck_ThemNH_HH_7.Checked = false;
            ck_ThemNH_HH_8.Checked = false;
        }




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









        //LOAD 
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
            txt_GiaMua_HH_1.Text =giaMua_DT_1;



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
            txt_GiaMua_HH_2.Text = giaMua_DT_2;




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
            txt_GiaMua_HH_3.Text = giaMua_DT_3;



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
            txt_GiaMua_HH_4.Text = giaMua_DT_4;





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
            txt_GiaMua_HH_5.Text = giaMua_DT_5;





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
            txt_GiaMua_HH_6.Text = giaMua_DT_6;





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
            txt_GiaMua_HH_7.Text = giaMua_DT_7;




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
            txt_GiaMua_HH_8.Text = giaMua_DT_8;

        }

        //1.3 Load ck_ MK


        ///===================ENDLOAD
        //1. Tong
        //Trong hop cac cai tren
        public void Load_ALL_ThemNH_At_D() {
            load_Cb_ThemNH_TenNCC_At_D();
            load_Cb_ThemNH_TinhTrang_At_D();
            Load_TenDV_GiaDV_At_D();
            //
            Set_ALL_Check_MD();
        }







        //2. KT
        //1 taoi bien
        //bool Co_TxtBox_Is_Empty = false;
        //    return Co_TxtBox_Is_Empty;
        public bool Co_TxtBox_Is_Empty_ThemNH_At_D() {
            //1 taoi bien
            bool Co_TxtBox_Is_Empty=false;

            //T.Tin Doitac
            if (cb_ThemNH_TenNCC.Text == "" || cb_ThemNH_SDT.Text=="" ||
                cb_ThemNH_TinhTrang_1.Text=="") 
            {
                Co_TxtBox_Is_Empty=true;
            }


            //
            return Co_TxtBox_Is_Empty;
        }

        //2.1 Co chon SP chua
        public bool Da_Chon_San_Pham_At_D() {
            bool Da_Chon = false;
            //
            if (ck_ThemNH_HH_1.Checked == true || ck_ThemNH_HH_2.Checked == true ||
                ck_ThemNH_HH_3.Checked == true || ck_ThemNH_HH_4.Checked == true ||
                ck_ThemNH_HH_5.Checked == true || ck_ThemNH_HH_6.Checked == true ||
                ck_ThemNH_HH_7.Checked == true || ck_ThemNH_HH_8.Checked == true
                ) { 
                Da_Chon=true;
                return Da_Chon;
            }

            return Da_Chon;
        }










        //3. Do
        //1.2 load sdt Theo Ten NCC
        public void Load_Get_SDT_Theo_TenNCC_At_D()
        {
            string tenNCC = cb_ThemNH_TenNCC.Text;
            //get maNCC
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = mn_NCC_1.Get_MaDT_From_TenDT_GetDataTable(tenNCC);
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


        //1.1 Get
        //get Trang Thai
        //1 or 0
        public int Get_TrangThai_At_D_GetInt() {
            //tao B
            int trangThai=1;
            //DataTable dt_temp_1 = new DataTable();

            //cv
            if (cb_ThemNH_TinhTrang_1.Text == "Đã thanh toán")
            {
                trangThai = 1;

            }
            else if (cb_ThemNH_TinhTrang_1.Text == "Chưa thanh toán") {
                trangThai = 0;

            }
            //
            return trangThai;
        }


        public int Get_MaNCC_From_TenNCC_At_D_GetInt()
        {
            //tao B
            int maNCC;
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = mn_NCC_1.Get_MaDT_From_TenDT_GetDataTable(cb_ThemNH_TenNCC.Text);

            //cv
            maNCC = Convert.ToInt32(dt_temp_1.Rows[0]["maNCC"]);

            //
            return maNCC;
        }





        //1. get Tong tien
        /// tongTien H1->H8 BT
        //1
        private decimal Get_GiaMua_From_ShowGiaMua_GetDecimal(string sShowGiaMua)
        {
            decimal giaMua = 0;

            giaMua = Convert.ToDecimal(sShowGiaMua);
            // MessageBox.Show("" + a);

            return giaMua;
        }

        //HH1
        public decimal Get_TongTien_Of_HH1_At_D_GetDecimal() {

            decimal tongTien = 0;

            //1. xet cac muc
            if (ck_ThemNH_HH_1.Checked == true) {
                if (nb_SL_HH_1.Value > 0) {
                    //giaMua
                    decimal giaMua = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_1.Text);
                    decimal soLuong=nb_SL_HH_1.Value;
                    tongTien += (decimal)(giaMua * soLuong);
                }
            
            }

            return tongTien;
        }

        //HH2
        public decimal Get_TongTien_Of_HH2_At_D_GetDecimal()
        {

            decimal tongTien = 0;

            //1. xet cac muc
            if (ck_ThemNH_HH_2.Checked == true)
            {
                if (nb_SL_HH_2.Value > 0)
                {
                    //giaMua
                    decimal giaMua = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_2.Text);
                    decimal soLuong = nb_SL_HH_2.Value;
                    tongTien += (decimal)(giaMua * soLuong);
                }

            }

            return tongTien;
        }

        //HH3
        public decimal Get_TongTien_Of_HH3_At_D_GetDecimal()
        {
            decimal tongTien = 0;

            //1. xet cac muc cho HH3
            if (ck_ThemNH_HH_3.Checked == true)
            {
                if (nb_SL_HH_3.Value > 0)
                {
                    //giaMua
                    decimal giaMua = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_3.Text);
                    decimal soLuong = nb_SL_HH_3.Value;
                    tongTien += (decimal)(giaMua * soLuong);
                }
            }

            return tongTien;
        }


        //HH4
        public decimal Get_TongTien_Of_HH4_At_D_GetDecimal()
        {
            decimal tongTien = 0;

            //1. xet cac muc cho HH4
            if (ck_ThemNH_HH_4.Checked == true)
            {
                if (nb_SL_HH_4.Value > 0)
                {
                    //giaMua
                    decimal giaMua = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_4.Text);
                    decimal soLuong = nb_SL_HH_4.Value;
                    tongTien += (decimal)(giaMua * soLuong);
                }
            }

            return tongTien;
        }

        //HH5
        public decimal Get_TongTien_Of_HH5_At_D_GetDecimal()
        {
            decimal tongTien = 0;

            //1. xet cac muc cho HH5
            if (ck_ThemNH_HH_5.Checked == true)
            {
                if (nb_SL_HH_5.Value > 0)
                {
                    //giaMua
                    decimal giaMua = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_5.Text);
                    decimal soLuong = nb_SL_HH_5.Value;
                    tongTien += (decimal)(giaMua * soLuong);
                }
            }

            return tongTien;
        }

        //HH6
        public decimal Get_TongTien_Of_HH6_At_D_GetDecimal()
        {
            decimal tongTien = 0;

            //1. xet cac muc cho HH6
            if (ck_ThemNH_HH_6.Checked == true)
            {
                if (nb_SL_HH_6.Value > 0)
                {
                    //giaMua
                    decimal giaMua = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_6.Text);
                    decimal soLuong = nb_SL_HH_6.Value;
                    tongTien += (decimal)(giaMua * soLuong);
                }
            }

            return tongTien;
        }

        //HH7
        public decimal Get_TongTien_Of_HH7_At_D_GetDecimal()
        {
            decimal tongTien = 0;

            //1. xet cac muc cho HH7
            if (ck_ThemNH_HH_7.Checked == true)
            {
                if (nb_SL_HH_7.Value > 0)
                {
                    //giaMua
                    decimal giaMua = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_7.Text);
                    decimal soLuong = nb_SL_HH_7.Value;
                    tongTien += (decimal)(giaMua * soLuong);
                }
            }

            return tongTien;
        }

        //HH8
        public decimal Get_TongTien_Of_HH8_At_D_GetDecimal()
        {
            decimal tongTien = 0;

            //1. xet cac muc cho HH8
            if (ck_ThemNH_HH_8.Checked == true)
            {
                if (nb_SL_HH_8.Value > 0)
                {
                    //giaMua
                    decimal giaMua = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_8.Text);
                    decimal soLuong = nb_SL_HH_8.Value;
                    tongTien += (decimal)(giaMua * soLuong);
                }
            }

            return tongTien;
        }



        /// tongTien H1->H8 END
        //HH ALL HH
        public decimal Get_TongTien_Of_ALL_HH_At_D_GetDecimal()
        {

            decimal tongTien = 0;

            //1. xet cac muc
            //HH1
            if (ck_ThemNH_HH_1.Checked == true)
            {
                if (nb_SL_HH_1.Value > 0)
                {
                    //giaMua
                    decimal T_Tien = Get_TongTien_Of_HH1_At_D_GetDecimal();
                    tongTien += T_Tien;
                }
            }

            //HH2
            if (ck_ThemNH_HH_2.Checked == true)
            {
                if (nb_SL_HH_2.Value > 0)
                {
                    //giaMua
                    decimal T_Tien = Get_TongTien_Of_HH2_At_D_GetDecimal();
                    tongTien += T_Tien;
                }
            }

            //HH3
            if (ck_ThemNH_HH_3.Checked == true)
            {
                if (nb_SL_HH_3.Value > 0)
                {
                    //giaMua
                    decimal T_Tien = Get_TongTien_Of_HH3_At_D_GetDecimal();
                    tongTien += T_Tien;
                }
            }

            //HH4
            if (ck_ThemNH_HH_4.Checked == true)
            {
                if (nb_SL_HH_4.Value > 0)
                {
                    //giaMua
                    decimal T_Tien = Get_TongTien_Of_HH4_At_D_GetDecimal();
                    tongTien += T_Tien;
                }
            }

            //HH5
            if (ck_ThemNH_HH_5.Checked == true)
            {
                if (nb_SL_HH_5.Value > 0)
                {
                    //giaMua
                    decimal T_Tien = Get_TongTien_Of_HH5_At_D_GetDecimal();
                    tongTien += T_Tien;
                }
            }

            //HH6
            if (ck_ThemNH_HH_6.Checked == true)
            {
                if (nb_SL_HH_6.Value > 0)
                {
                    //giaMua
                    decimal T_Tien = Get_TongTien_Of_HH6_At_D_GetDecimal();
                    tongTien += T_Tien;
                }
            }

            //HH7
            if (ck_ThemNH_HH_7.Checked == true)
            {
                if (nb_SL_HH_7.Value > 0)
                {
                    //giaMua
                    decimal T_Tien = Get_TongTien_Of_HH7_At_D_GetDecimal();
                    tongTien += T_Tien;
                }
            }

            //HH8
            if (ck_ThemNH_HH_8.Checked == true)
            {
                if (nb_SL_HH_8.Value > 0)
                {
                    //giaMua
                    decimal T_Tien = Get_TongTien_Of_HH8_At_D_GetDecimal();
                    tongTien += T_Tien;
                }
            }

            





            return tongTien;
        }







        /// 1.2 sInsert data CT_NH_HH H1->H8 BD  
        //get ND insert
        
        public int Get_MaHH_From_ShowTenHH_GetInt(string tenHH) {
            DataTable dt_temp_1 = new DataTable();
            int maHH=1;

            dt_temp_1 = mn_HnagHoa_1.Get_maDT_From_TenDT_GetDataTable(tenHH);
            //
            maHH = Convert.ToInt32(dt_temp_1.Rows[0]["maHH"]);


            return maHH;
            
        }

        //insert
        //HH 1
        public bool SUCCESS_Insert_CT_NH_HH_For_HH_1_GetBool(int maNH) {

            if (ck_ThemNH_HH_1.Checked == true) {
                //get ND
                int maHH = Get_MaHH_From_ShowTenHH_GetInt(lab_DT_1.Text);
                decimal soLuong=nb_SL_HH_1.Value;
                decimal DonGia = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_1.Text);

                //run + KT
                if (mn_CT_NH_HH_1.Them1_DT(maNH, maHH, soLuong, DonGia) == false) { 
                    return false;
                }
            }
            return true;
        }


        //HH 2
        public bool SUCCESS_Insert_CT_NH_HH_For_HH_2_GetBool(int maNH)
        {

            if (ck_ThemNH_HH_2.Checked == true)
            {
                //get ND
                int maHH = Get_MaHH_From_ShowTenHH_GetInt(lab_DT_2.Text);
                decimal soLuong = nb_SL_HH_2.Value;
                decimal DonGia = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_2.Text);

                //run + KT
                if (mn_CT_NH_HH_1.Them1_DT(maNH, maHH, soLuong, DonGia) == false)
                {
                    return false;
                }
            }
            return true;
        }

        //HH 3
        public bool SUCCESS_Insert_CT_NH_HH_For_HH_3_GetBool(int maNH)
        {

            if (ck_ThemNH_HH_3.Checked == true)
            {
                //get ND
                int maHH = Get_MaHH_From_ShowTenHH_GetInt(lab_DT_3.Text);
                decimal soLuong = nb_SL_HH_3.Value;
                decimal DonGia = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_3.Text);

                //run + KT
                if (mn_CT_NH_HH_1.Them1_DT(maNH, maHH, soLuong, DonGia) == false)
                {
                    return false;
                }
            }
            return true;
        }

        //HH 4
        public bool SUCCESS_Insert_CT_NH_HH_For_HH_4_GetBool(int maNH)
        {

            if (ck_ThemNH_HH_4.Checked == true)
            {
                //get ND
                int maHH = Get_MaHH_From_ShowTenHH_GetInt(lab_DT_4.Text);
                decimal soLuong = nb_SL_HH_4.Value;
                decimal DonGia = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_4.Text);

                //run + KT
                if (mn_CT_NH_HH_1.Them1_DT(maNH, maHH, soLuong, DonGia) == false)
                {
                    return false;
                }
            }
            return true;
        }

        //HH 5
        public bool SUCCESS_Insert_CT_NH_HH_For_HH_5_GetBool(int maNH)
        {

            if (ck_ThemNH_HH_5.Checked == true)
            {
                //get ND
                int maHH = Get_MaHH_From_ShowTenHH_GetInt(lab_DT_5.Text);
                decimal soLuong = nb_SL_HH_5.Value;
                decimal DonGia = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_5.Text);

                //run + KT
                if (mn_CT_NH_HH_1.Them1_DT(maNH, maHH, soLuong, DonGia) == false)
                {
                    return false;
                }
            }
            return true;
        }

        //HH 6
        public bool SUCCESS_Insert_CT_NH_HH_For_HH_6_GetBool(int maNH)
        {

            if (ck_ThemNH_HH_6.Checked == true)
            {
                //get ND
                int maHH = Get_MaHH_From_ShowTenHH_GetInt(lab_DT_6.Text);
                decimal soLuong = nb_SL_HH_6.Value;
                decimal DonGia = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_6.Text);

                //run + KT
                if (mn_CT_NH_HH_1.Them1_DT(maNH, maHH, soLuong, DonGia) == false)
                {
                    return false;
                }
            }
            return true;
        }

        //HH 7
        public bool SUCCESS_Insert_CT_NH_HH_For_HH_7_GetBool(int maNH)
        {

            if (ck_ThemNH_HH_7.Checked == true)
            {
                //get ND
                int maHH = Get_MaHH_From_ShowTenHH_GetInt(lab_DT_7.Text);
                decimal soLuong = nb_SL_HH_7.Value;
                decimal DonGia = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_7.Text);

                //run + KT
                if (mn_CT_NH_HH_1.Them1_DT(maNH, maHH, soLuong, DonGia) == false)
                {
                    return false;
                }
            }
            return true;
        }

        //HH 8
        public bool SUCCESS_Insert_CT_NH_HH_For_HH_8_GetBool(int maNH)
        {

            if (ck_ThemNH_HH_8.Checked == true)
            {
                //get ND
                int maHH = Get_MaHH_From_ShowTenHH_GetInt(lab_DT_8.Text);
                decimal soLuong = nb_SL_HH_8.Value;
                decimal DonGia = Get_GiaMua_From_ShowGiaMua_GetDecimal(txt_GiaMua_HH_8.Text);

                //run + KT
                if (mn_CT_NH_HH_1.Them1_DT(maNH, maHH, soLuong, DonGia) == false)
                {
                    return false;
                }
            }
            return true;
        }


        //
        public bool SUCCESS_Insert_CT_NH_HH_For_ALL_HH(int maNH) {

            //duyet 
            //HH 1  
            if (SUCCESS_Insert_CT_NH_HH_For_HH_1_GetBool(maNH) == false) { 
                return false;
            }

            //HH 2
            if (SUCCESS_Insert_CT_NH_HH_For_HH_2_GetBool(maNH) == false)
            {
                return false;
            }

            //HH 3
            if (SUCCESS_Insert_CT_NH_HH_For_HH_3_GetBool(maNH) == false)
            {
                return false;
            }

            //HH 4
            if (SUCCESS_Insert_CT_NH_HH_For_HH_4_GetBool(maNH) == false)
            {
                return false;
            }

            //HH 5
            if (SUCCESS_Insert_CT_NH_HH_For_HH_5_GetBool(maNH) == false)
            {
                return false;
            }

            //HH 6
            if (SUCCESS_Insert_CT_NH_HH_For_HH_6_GetBool(maNH) == false)
            {
                return false;
            }

            //HH 7
            if (SUCCESS_Insert_CT_NH_HH_For_HH_7_GetBool(maNH) == false)
            {
                return false;
            }

            //HH 8
            if (SUCCESS_Insert_CT_NH_HH_For_HH_8_GetBool(maNH) == false)
            {
                return false;
            }


            return true;
        }


        //1.2 sInsert data CT_NH_HH H1->H8 end



        //1.1 Insert
        //1 insert a row for NHAPHANG
        public bool SUCCESS_Insert_A_Row_For_NHAPHANG_GetBool() {
            //2.2 (1) Nhap NH
            //1 get maNCC
            int maNCC = Get_MaNCC_From_TenNCC_At_D_GetInt();
            int trangThai = Get_TrangThai_At_D_GetInt();
            decimal tongTien = Get_TongTien_Of_ALL_HH_At_D_GetDecimal();

            //goi T.Thi + layQK
            if (mn_NhapHang_1.Them1_DT(tongTien, trangThai, maNCC) == false) { 
                //sai thi fung luon
                return false;
            }

            return true;
        }

















        //3.3 Chuc nag
        public void ThemNH_At_D() {
            //-->BD
            
            //1. KT
            //-> chua dien TT doi tac?
            if (Co_TxtBox_Is_Empty_ThemNH_At_D() == true) {
                MessageBox.Show("Vui Điền thông tin: NCC/SDT/Tình trạng đơn hàng!!!");
                Load_ALL_ThemNH_At_D();
                return;
            }

            //-> Da chon SP?
            if (Da_Chon_San_Pham_At_D() == false)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để nhập!!!");
                Load_ALL_ThemNH_At_D();
                return;
            }


            //2 Do
            //2.1 Cap Nhat for NCC (Da co trigger)

            //2.2 (1) Nhap NH
            //1 Get ND Them
            int maNCC=Get_MaNCC_From_TenNCC_At_D_GetInt();
            int trangThai = Get_TrangThai_At_D_GetInt();
            decimal tongTien= Get_TongTien_Of_ALL_HH_At_D_GetDecimal();

            //Test
            //MessageBox.Show("dan: "+maNCC  +"\n"+
            //    "dan: " + trangThai + "\n" +
            //    "dan: " + tongTien// + "\n" +

            // );


            //2. chen
            //2.1 NH
            if (SUCCESS_Insert_A_Row_For_NHAPHANG_GetBool() == false) {
                MessageBox.Show("Nhập Hàng: Thất Bại!!!");
                return;
            }




            //2.1 CT_NH_HH
            //1 Get ND Them
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = mn_NhapHang_1.Get_MaNH_MoiNhat_GetDataTable();
            int maNH = Convert.ToInt32(dt_temp_1.Rows[0]["maNH"]);


            if (SUCCESS_Insert_CT_NH_HH_For_ALL_HH(maNH) == false) { 
                MessageBox.Show("ADD CT: Thất bại!!!");
                return;
            }





            MessageBox.Show("Nhập Hàng: Thành Công!!!");
            //CN
            Load_ALL_ThemNH_At_D();
            //<--END

        }















        ///4.2.3 Do somything




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
           ck_ThemNH_HH_1.Checked = false;
        }

        private void cb_ThemNH_TenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Get_SDT_Theo_TenNCC_At_D();
        }



        private void ck_ThemNH_HH_1_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_ThemNH_HH_1.Checked == true)
            {
                // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_1.Enabled = true;
                txt_GiaMua_HH_1.Enabled = true;
                nb_SL_HH_1.Value = 1;
            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_1.Enabled = false;
                txt_GiaMua_HH_1.Enabled=false;
                nb_SL_HH_1.Value = 0;
            }
        }

        private void txt_GiaMua_HH_1_TextChanged(object sender, EventArgs e)
        {
            part0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_GiaMua_HH_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            part0.TextBoxOnlySoThuc(sender, e);


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt_GiaMua_HH_2_TextChanged(object sender, EventArgs e)
        {
            part0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_GiaMua_HH_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            part0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void txt_GiaMua_HH_3_TextChanged(object sender, EventArgs e)
        {
            part0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_GiaMua_HH_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            part0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void txt_GiaMua_HH_4_TextChanged(object sender, EventArgs e)
        {
            part0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_GiaMua_HH_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            part0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void txt_GiaMua_HH_5_TextChanged(object sender, EventArgs e)
        {
            part0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_GiaMua_HH_5_KeyPress(object sender, KeyPressEventArgs e)
        {
            part0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void txt_GiaMua_HH_6_TextChanged(object sender, EventArgs e)
        {
            part0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_GiaMua_HH_6_KeyPress(object sender, KeyPressEventArgs e)
        {
            part0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void txt_GiaMua_HH_7_TextChanged(object sender, EventArgs e)
        {
            part0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_GiaMua_HH_7_KeyPress(object sender, KeyPressEventArgs e)
        {
            part0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void txt_GiaMua_HH_8_TextChanged(object sender, EventArgs e)
        {
            part0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_GiaMua_HH_8_KeyPress(object sender, KeyPressEventArgs e)
        {
            part0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void ck_ThemNH_HH_2_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_ThemNH_HH_2.Checked == true)
            {
                // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_2.Enabled = true;
                txt_GiaMua_HH_2.Enabled = true;
                nb_SL_HH_2.Value = 1;
            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_2.Enabled = false;
                txt_GiaMua_HH_2.Enabled = false;
                nb_SL_HH_2.Value = 0;
            }
        }

        private void ck_ThemNH_HH_3_CheckedChanged(object sender, EventArgs e)
        {
            // Với X = 3
            if (ck_ThemNH_HH_3.Checked == true)
            {
                // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_3.Enabled = true;
                txt_GiaMua_HH_3.Enabled = true;
                nb_SL_HH_3.Value = 1;
            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_3.Enabled = false;
                txt_GiaMua_HH_3.Enabled = false;
                nb_SL_HH_3.Value = 0;
            }
        }

        private void ck_ThemNH_HH_4_CheckedChanged(object sender, EventArgs e)
        {
            // Với X = 4
            if (ck_ThemNH_HH_4.Checked == true)
            {
                // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_4.Enabled = true;
                txt_GiaMua_HH_4.Enabled = true;
                nb_SL_HH_4.Value = 1;
            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_4.Enabled = false;
                txt_GiaMua_HH_4.Enabled = false;
                nb_SL_HH_4.Value = 0;
            }
        }

        private void ck_ThemNH_HH_5_CheckedChanged(object sender, EventArgs e)
        {
            // Với X = 5
            if (ck_ThemNH_HH_5.Checked == true)
            {
                // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_5.Enabled = true;
                txt_GiaMua_HH_5.Enabled = true;
                nb_SL_HH_5.Value = 1;
            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_5.Enabled = false;
                txt_GiaMua_HH_5.Enabled = false;
                nb_SL_HH_5.Value = 0;
            }
        }

        private void ck_ThemNH_HH_6_CheckedChanged(object sender, EventArgs e)
        {
            // Với X = 6
            if (ck_ThemNH_HH_6.Checked == true)
            {
                // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_6.Enabled = true;
                txt_GiaMua_HH_6.Enabled = true;
                nb_SL_HH_6.Value = 1;
            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_6.Enabled = false;
                txt_GiaMua_HH_6.Enabled = false;
                nb_SL_HH_6.Value = 0;
            }
        }

        private void ck_ThemNH_HH_7_CheckedChanged(object sender, EventArgs e)
        {
            // Với X = 7
            if (ck_ThemNH_HH_7.Checked == true)
            {
                // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_7.Enabled = true;
                txt_GiaMua_HH_7.Enabled = true;
                nb_SL_HH_7.Value = 1;
            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_7.Enabled = false;
                txt_GiaMua_HH_7.Enabled = false;
                nb_SL_HH_7.Value = 0;
            }
        }

        private void ck_ThemNH_HH_8_CheckedChanged(object sender, EventArgs e)
        {
            // Với X = 8
            if (ck_ThemNH_HH_8.Checked == true)
            {
                // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_8.Enabled = true;
                txt_GiaMua_HH_8.Enabled = true;
                nb_SL_HH_8.Value = 1;
            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_SL_HH_8.Enabled = false;
                txt_GiaMua_HH_8.Enabled = false;
                nb_SL_HH_8.Value = 0;
            }
        }

        private void btn_ThemNH_NhapHang_1_Click(object sender, EventArgs e)
        {
            ThemNH_At_D();
        }

        private void btn_Test2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dan: "+ Get_MaHH_From_ShowTenHH_GetInt(lab_DT_8.Text));
        }

        private void nb_SL_HH_1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //////////END-Class
    }
}
//MessageBox.Show("Dan: ");