//using DA_Loan_Spa._0_Class_Frm_Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
//using DA_Loan_Spa._3_DataBase_Layer;
//using DA_Loan_Spa._2_Xuly_Layer;
//P-1
using L2_DLL;
using L3_DAL;
using L4_DTO;

namespace L1_GUI
{
    public partial class frm_LoanSpa_Main_01 : Form
    {


        public frm_LoanSpa_Main_01(int iQuyen, string taiKhoan, string matKhau)
        {
            this.iQuyen = iQuyen;
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            InitializeComponent();
        }


        public frm_LoanSpa_Main_01()
        {
            InitializeComponent();
        }
        //B-2
        //B2-
        int iQuyen = 0;
        string taiKhoan;
        string matKhau;



        //mn_
        Manager_HoaDon_1 mn_hoaDon_1 = new Manager_HoaDon_1();

        Manager_Tab_THANHTOAN_1 mn_Tab_THANHTOAN_1 = new Manager_Tab_THANHTOAN_1();

        Manager_tab_KH_1 mn_tab_KhachHang_1 = new Manager_tab_KH_1();

        Manager_tab_NCC_1 mn_tab_NCC_1 = new Manager_tab_NCC_1();

        Manager_tab_NH_1 mn_tab_NH_1 = new Manager_tab_NH_1();

        Manager_tab_HangHoa_1 mn_tab_HangHoa_1 = new Manager_tab_HangHoa_1();

        Manager_tab_DV_1 mn_tab_DV_1 = new Manager_tab_DV_1();

        Manager_CTHD_HOADON_DICHVU_1 mn_tab_CT_HD_DV = new Manager_CTHD_HOADON_DICHVU_1();

        Manager_TongQuan_1 mn_TQ_1 = new Manager_TongQuan_1();

        Manager_Tab_BaoCao_1 mn_BC_1=new Manager_Tab_BaoCao_1();


        //support
        Part_0_1_PT_For_WF_Base_1 part_0 = new Part_0_1_PT_For_WF_Base_1();


        //dt_
        //
        DataTable dt_HoaDon = new DataTable();

        //
        DataTable dt_KhachHang_1 = new DataTable();

        //NCC
        DataTable dt_NCC_1 = new DataTable();


        //NH
        DataTable dt_NH_1 = new DataTable();

        //HH
        DataTable dt_HangHoa_1 = new DataTable();

        //DV
        DataTable dt_DV_1 = new DataTable();


















        //CTC
        //0. config MD
        //NCC
        public void Set_TextBox_MD_NCC() {
            txt_NCC_TenNCC.Text = "";
            txt_NCC_SDT.Text = "";
            txt_NCC_TongNo.Text = "";
            txt_NCC_TongTien.Text = "";
            ///
            txt_NCC_TenNCC.Focus();
        }

        //HangHoa
        public void Set_TextBox_MD_HangHoa() {
            txt_HH_TenHH.Text = "";
            txt_HH_GiaMua.Text = "";
            txt_HH_SLTon.Text = "";
            //
            txt_HH_TenHH.Focus();
        }

        //DichVu
        public void Set_TextBox_MD_DichVu() {
            txt_DV_tenDV.Text = "";
            txt_DV_GiaDV.Text = "";
            //
            txt_DV_tenDV.Focus();
        }

        //TAB THANH TOAN
        //0. Configs
        public void Tab_TT_Set_MD_KhachHang() {
            txt_TT_TenKhachHang.Text = "";
            txt_TT_SDT.Text = "";
            txt_TT_TenKhachHang.Focus();
        }
        //TT
        public void Set_Tab_TT_MD_ALL_TXT_Check_TenDV_GiaDVMD()
        {
            //txt_box
            Tab_TT_Set_MD_KhachHang();

            //TT
            txt_TT_TongTien.Text = "0";
            txt_TT_GiamGia.Text = "0";
            txt_TT_TongSauGiam.Text = "0";
            txt_TT_SoTienDaThanhToan.Text = "0";


            //ck_
            ck_TT_DV_1.Checked = false;
            ck_TT_DV_2.Checked = false;
            ck_TT_DV_3.Checked = false;
            ck_TT_DV_4.Checked = false;



            //
            Load_Tab_TT_TenDV_GiaDV_At_D();
        }







        //Xoa tab
        public void XoaTabDoiVoi_NhanVien() {
            tab_LoanSpa.TabPages.Remove(tab_Page_BaoCao);
            tab_LoanSpa.TabPages.Remove(tab_Page_KhachHang);
            tab_LoanSpa.TabPages.Remove(tab_Page_NCC);
        }









        //1. Load
        //1.0 Load img
        public void Load_Imgs() {
            //0. Tong quan
            pb_BienHieu.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\BienHieu_1.png");

            pb_SoKhach.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\Human_1.png");
            pb_Thu.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\money-bag_1.png");
            pb_Chi.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\pay_1.png");

            //1. Thanh Toan
            //KH
            pb_N_KhachHang.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\Client_1.png");
            pb_TT_AnhCN.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\money-bag_1.png");
            pb_TT_AnhTT.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\Service_n_1.png");


            //DV
            pb_Da.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\TT_Massage_Da_1.png");
            pb_Mat.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\TT_Massage_Mat_1.png");
            pb_ToanThan.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\TT_Massage_ToanThan_1.png");
            pb_GoiDau.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\TT_GoiDau_1.png");

            //KhachHang
            pb_KH_1.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\Client_n_1.png");

            //NCC
            pb_NCC_AnhNCC.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\NCC_1.png");

            //NhapHang
            pb_NH_AnhNH.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\NhapHang_1.png");

            //HangHoa
            pb_HH_AnhHH.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\HH_1.png");

            //DichVu        
            pb_DV_AnhDV.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\Service_n_1.png");


            //Bao Cao
            pb_BC_AnhThongKe.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\BaoCao_1.png");

            pb_BC_SoKhach.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\Human_1.png");
            pb_BC_Thu.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\money-bag_1.png");
            pb_BC_Chi.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\pay_1.png");

            //Menu
            mn_TongQuan.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\BienHieu_1.png");
            mn_ThanhToan.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\money-bag_1.png");
            mn_HoaDon.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\bill_1.png");
            mn_BaoCao.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\BaoCao_1.png");
            mn_KhachHang.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\Client_n_1.png");

            mn_NCC.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\NCC_1.png");
            mn_NhapHang.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\NhapHang_1.png");
            mn_HangHoa.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\HH_1.png");
            mn_DichVu.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\Service_n_1.png");

            mn_DoiTac.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\DoiTac_1.png");
            mn_SanPham.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\CT_NhapHang_1.png");
            mn_Thoat.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\Exit_1.png");




        }









        //1.0.1 load color btn_
        public void LoadColor_Btn() {
            //1.2 Button Hoa Don
            btn_Xoa_HDon.BackColor = Color.OrangeRed;
            btn_Them_HDon.BackColor = Color.LightGreen;

            //2. tab_KhachHang
            //btn_tab_KH_Them.BackColor = Color.LightGreen;
            // btn_tab_KH_Sua.BackColor = Color.LightGreen;
            btn_tab_KH_Xoa.BackColor = Color.OrangeRed;


            //1.2 tab_ NCC
            btn_Xoa_NCC.BackColor = Color.OrangeRed;
            btn_Them_NCC.BackColor = Color.LightGreen;

            //1.2 tab_ NH
            btn_Xoa_NH.BackColor = Color.OrangeRed;
            btn_Them_NH.BackColor = Color.LightGreen;

            //1.2 tab_ HH
            btn_Xoa_HH.BackColor = Color.OrangeRed;
            btn_Them_HH.BackColor = Color.LightGreen;

            //1.2 tab_ DV
            //btn_Xoa_DV.BackColor = Color.OrangeRed;
            btn_Them_DV.BackColor = Color.LightGreen;


            //1.3 tab_ BC
            btn_BC_ThongKe.BackColor = Color.LightGreen;

            //1.4 Thanh Toan
            btn_TT_ThanhToan.BackColor = Color.LightGreen;

        }











        //1.0.1 load 














        //1.1 LoadHD at D
        public void LoadHoaDon_At_D() {
            dt_HoaDon = mn_hoaDon_1.Get_DT_GetDataTable();
            dgv_HoaDon.DataSource = dt_HoaDon;
            ChooseFirstValue_And_SendDataRowToCommand_HD();
        }

        //1.2 Load KhachHang
        public void LoadKhachHang_At_D() {
            dt_KhachHang_1 = mn_tab_KhachHang_1.Get_DT_GetDataTable();
            dgv_KhachHang_1.DataSource = dt_KhachHang_1;
            ChooseFirstValue_And_SendDataRowToCommand_KhachHang();

        }

        //1.3 Load NCC
        public void LoadNCC_At_D()
        {
            dt_NCC_1 = mn_tab_NCC_1.Get_DT_GetDataTable();
            dgv_NCC_1.DataSource = dt_NCC_1;
            ChooseFirstValue_And_SendDataRowToCommand_NCC();

        }

        //1.4 Load NH
        public void LoadNH_At_D()
        {

            dt_NH_1 = mn_tab_NH_1.Get_DT_GetDataTable();
            dgv_NhapHang_1.DataSource = dt_NH_1;
            //ChooseFirstValue_And_SendDataRowToCommand_NCC();


            //Load ND cb_
            //clean
            cb_NH_TrangThai.Items.Clear();
            //add
            cb_NH_TrangThai.Items.Add("Đã thanh toán");
            cb_NH_TrangThai.Items.Add("Chưa thanh toán");
            cb_NH_TrangThai.SelectedIndex = 0;

            ///
            ChooseFirstValue_And_SendDataRowToCommand_NH();

        }

        //1.5 Load HangHoa
        public void LoadHH_At_D()
        {
            dt_HangHoa_1 = mn_tab_HangHoa_1.Get_DT_GetDataTable();
            dgv_HangHoa.DataSource = dt_HangHoa_1;
            ChooseFirstValue_And_SendDataRowToCommand_HangHoa();

        }


        //1.6 Load DV
        public void LoadDV_At_D()
        {
            dt_DV_1 = mn_tab_DV_1.Get_DT_GetDataTable();
            dgv_DichVu.DataSource = dt_DV_1;
            ChooseFirstValue_And_SendDataRowToCommand_DichVu();

        }


        //1.6 Load TenDV_GiaDV
        public void Load_Tab_TT_TenDV_GiaDV_At_D()
        {
            //tao bien



            //HH 1
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = mn_tab_DV_1.Get_DT_GetDataTable();
            string ten_DT_1 = dt_temp_1.Rows[0]["tenDV"] != DBNull.Value
                ? Convert.ToString(dt_temp_1.Rows[0]["tenDV"])
                : "Không có tên";

            string gia_DT_1 = dt_temp_1.Rows[0]["giaDV"] != DBNull.Value
                ? Convert.ToDecimal(dt_temp_1.Rows[0]["giaDV"]).ToString("N0")
                : "0";

            //dan value
            lab_TT_DV1.Text = ten_DT_1;
            txt_TT_GiaDV_DV_1.Text = gia_DT_1;


            //HH 2
            DataTable dt_temp_2 = new DataTable();
            dt_temp_2 = mn_tab_DV_1.Get_DT_GetDataTable();
            string ten_DT_2 = dt_temp_2.Rows[2]["tenDV"] != DBNull.Value
                ? Convert.ToString(dt_temp_2.Rows[2]["tenDV"])
                : "Không có tên";

            string gia_DT_2 = dt_temp_2.Rows[2]["giaDV"] != DBNull.Value
                ? Convert.ToDecimal(dt_temp_2.Rows[2]["giaDV"]).ToString("N0")
                : "0";

            //dan value
            lab_TT_DV2.Text = ten_DT_2;
            txt_TT_GiaDV_DV_2.Text = gia_DT_2;

            //HH 3
            DataTable dt_temp_3 = new DataTable();
            dt_temp_3 = mn_tab_DV_1.Get_DT_GetDataTable();
            string ten_DT_3 = dt_temp_3.Rows[1]["tenDV"] != DBNull.Value
                ? Convert.ToString(dt_temp_3.Rows[1]["tenDV"])
                : "Không có tên";

            string gia_DT_3 = dt_temp_3.Rows[1]["giaDV"] != DBNull.Value
                ? Convert.ToDecimal(dt_temp_3.Rows[1]["giaDV"]).ToString("N0")
                : "0";

            //dan value
            lab_TT_DV3.Text = ten_DT_3;
            txt_TT_GiaDV_DV_3.Text = gia_DT_3;

            //HH 4
            DataTable dt_temp_4 = new DataTable();
            dt_temp_4 = mn_tab_DV_1.Get_DT_GetDataTable();
            string ten_DT_4 = dt_temp_4.Rows[3]["tenDV"] != DBNull.Value
                ? Convert.ToString(dt_temp_4.Rows[3]["tenDV"])
                : "Không có tên";

            string gia_DT_4 = dt_temp_4.Rows[3]["giaDV"] != DBNull.Value
                ? Convert.ToDecimal(dt_temp_4.Rows[3]["giaDV"]).ToString("N0")
                : "0";

            //dan value
            lab_TT_DV4.Text = ten_DT_4;
            txt_TT_GiaDV_DV_4.Text = gia_DT_4;




        }
















        //2. Find
        //2.1 Hoa Don
        public void SendDataRowToCommand_HoaDon() {
            //Dk do
            if (dt_HoaDon.Rows.Count > 0) {
                //DK do
                //0. get VT
                int rowIndex = dgv_HoaDon.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon
                //1. NgaySinh
                DateTime dateTime = Convert.ToDateTime(dgv_HoaDon.Rows[rowIndex].Cells[1].Value);
                dtp_NgayLap.Value = dateTime;

                //2. TongTien
                decimal tongTien = Convert.ToDecimal(dgv_HoaDon.Rows[rowIndex].Cells[2].Value);
                txt_TongTien.Text = tongTien.ToString();

                //3. GiamGia
                byte giamGia = Convert.ToByte(dgv_HoaDon.Rows[rowIndex].Cells[3].Value);
                txt_GiamGia.Text = giamGia.ToString();

                //4. Tong sau giam
                decimal tongSauGiam = Convert.ToDecimal(dgv_HoaDon.Rows[rowIndex].Cells[4].Value);
                txt_TongSauGiam.Text = tongSauGiam.ToString();

                //5. soTienDaThanhToan
                decimal soTienDaThanhToan = Convert.ToDecimal(dgv_HoaDon.Rows[rowIndex].Cells[5].Value);
                txt_SoTienDaThanhToan.Text = soTienDaThanhToan.ToString();

                //6. tenKH
                string tenKH = Convert.ToString(dgv_HoaDon.Rows[rowIndex].Cells[6].Value);
                txt_TenKH.Text = tenKH;
            }
        }

        public void SendDataRowToCommand_HoaDon(int rowIndex)
        {
            //Dk do
            if (dt_HoaDon.Rows.Count > 0)
            {
                //DK do
                //0. get VT
                //int rowIndex = dgv_HoaDon.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon
                //1. NgaySinh
                DateTime dateTime = Convert.ToDateTime(dgv_HoaDon.Rows[rowIndex].Cells[1].Value);
                dtp_NgayLap.Value = dateTime;

                //2. TongTien
                decimal tongTien = Convert.ToDecimal(dgv_HoaDon.Rows[rowIndex].Cells[2].Value);
                txt_TongTien.Text = tongTien.ToString();

                //3. GiamGia
                byte giamGia = Convert.ToByte(dgv_HoaDon.Rows[rowIndex].Cells[3].Value);
                txt_GiamGia.Text = giamGia.ToString();

                //4. Tong sau giam
                decimal tongSauGiam = Convert.ToDecimal(dgv_HoaDon.Rows[rowIndex].Cells[4].Value);
                txt_TongSauGiam.Text = tongSauGiam.ToString();

                //5. soTienDaThanhToan
                decimal soTienDaThanhToan = Convert.ToDecimal(dgv_HoaDon.Rows[rowIndex].Cells[5].Value);
                txt_SoTienDaThanhToan.Text = soTienDaThanhToan.ToString();

                //6. tenKH
                string tenKH = Convert.ToString(dgv_HoaDon.Rows[rowIndex].Cells[6].Value);
                txt_TenKH.Text = tenKH;
            }
        }

        //2.2  Khach hang
        public void SendDataRowToCommand_KhachHang()
        {
            //Dk do
            if (dt_KhachHang_1.Rows.Count > 0)
            {
                //DK do
                //0. get VT
                int rowIndex = dgv_KhachHang_1.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon
                //0. tenKH
                string tenKH = Convert.ToString(dgv_KhachHang_1.Rows[rowIndex].Cells["tenKH"].Value);
                txt_KH_TenKH.Text = tenKH;

                //0. sdt
                string sSDT = Convert.ToString(dgv_KhachHang_1.Rows[rowIndex].Cells["SDT"].Value);
                txt_KH_SDT.Text = sSDT.Trim();
                //txt_KH_SDT_2.Text = sSDT;

                //1. NgaySinh
                DateTime dateTime = Convert.ToDateTime(dgv_KhachHang_1.Rows[rowIndex].Cells["ngayLap"].Value);
                dtp_KH_NgayLap.Value = dateTime;

                //2. TongTien
                decimal tongTien = Convert.ToDecimal(dgv_KhachHang_1.Rows[rowIndex].Cells["tongTien"].Value);
                txt_KH_TongTien.Text = tongTien.ToString();


            }
        }

        public void SendDataRowToCommand_KhachHang(int rowIndex)
        {
            //Dk do
            if (dt_KhachHang_1.Rows.Count > 0)
            {
                //DK do
                //0. get VT
                //int rowIndex = dgv_KhachHang_1.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon
                //0. tenKH
                string tenKH = Convert.ToString(dgv_KhachHang_1.Rows[rowIndex].Cells["tenKH"].Value);
                txt_KH_TenKH.Text = tenKH;

                //0. sdt
                string sSDT = Convert.ToString(dgv_KhachHang_1.Rows[rowIndex].Cells["SDT"].Value);
                txt_KH_SDT.Text = sSDT.Trim();
                //txt_KH_SDT_2.Text = sSDT;

                //1. NgaySinh
                DateTime dateTime = Convert.ToDateTime(dgv_KhachHang_1.Rows[rowIndex].Cells["ngayLap"].Value);
                dtp_KH_NgayLap.Value = dateTime;

                //2. TongTien
                decimal tongTien = Convert.ToDecimal(dgv_KhachHang_1.Rows[rowIndex].Cells["tongTien"].Value);
                txt_KH_TongTien.Text = tongTien.ToString();


            }
        }

        //2.3  NCC
        public void SendDataRowToCommand_NCC()
        {
            //Dk do
            if (dt_NCC_1.Rows.Count > 0)
            {
                //DK do
                //0. get VT
                int rowIndex = dgv_NCC_1.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon
                //0. tenKH
                string tenKH = Convert.ToString(dgv_NCC_1.Rows[rowIndex].Cells["tenNCC"].Value);
                txt_NCC_TenNCC.Text = tenKH;

                //0. sdt
                string sSDT = Convert.ToString(dgv_NCC_1.Rows[rowIndex].Cells["SDT"].Value);
                txt_NCC_SDT.Text = sSDT.Trim();
                //txt_KH_SDT_2.Text = sSDT;


                //2. TongNo
                decimal tongNo = Convert.ToDecimal(dgv_NCC_1.Rows[rowIndex].Cells["tongNo"].Value);
                txt_NCC_TongNo.Text = tongNo.ToString();

                //2. TongTien
                decimal tongTien = Convert.ToDecimal(dgv_NCC_1.Rows[rowIndex].Cells["tongTien"].Value);
                txt_NCC_TongTien.Text = tongTien.ToString();

            }
        }

        public void SendDataRowToCommand_NCC(int rowIndex)
        {
            //Dk do
            if (dt_NCC_1.Rows.Count > 0)
            {
                //DK do
                //0. get VT
                // int rowIndex = dgv_NCC_1.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon
                //0. tenKH
                string tenKH = Convert.ToString(dgv_NCC_1.Rows[rowIndex].Cells["tenNCC"].Value);
                txt_NCC_TenNCC.Text = tenKH;

                //0. sdt
                string sSDT = Convert.ToString(dgv_NCC_1.Rows[rowIndex].Cells["SDT"].Value);
                txt_NCC_SDT.Text = sSDT.Trim();
                //txt_KH_SDT_2.Text = sSDT;


                //2. TongNo
                decimal tongNo = Convert.ToDecimal(dgv_NCC_1.Rows[rowIndex].Cells["tongNo"].Value);
                txt_NCC_TongNo.Text = tongNo.ToString();

                //2. TongTien
                decimal tongTien = Convert.ToDecimal(dgv_NCC_1.Rows[rowIndex].Cells["tongTien"].Value);
                txt_NCC_TongTien.Text = tongTien.ToString();

            }
        }

        //2.4  NH
        public void SendDataRowToCommand_NH()
        {
            //Dk do
            if (dt_NH_1.Rows.Count > 0)
            {
                //DK do
                //0. get VT
                int rowIndex = dgv_NhapHang_1.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon
                //0. tenDT
                string tenDT = Convert.ToString(dgv_NhapHang_1.Rows[rowIndex].Cells["tenNCC"].Value);
                txt_NH_TenNCC.Text = tenDT;

                //Convert Ko quan tam KDL of Nguon
                //1. NgaySinh
                DateTime dateTime = Convert.ToDateTime(dgv_NhapHang_1.Rows[rowIndex].Cells["ngayLap"].Value);
                dtp_NH_NgayLap.Value = dateTime;

                //2. TongTien
                decimal tongTien = Convert.ToDecimal(dgv_NhapHang_1.Rows[rowIndex].Cells["tongTien"].Value);
                txt_NH_TongTien.Text = tongTien.ToString();

                //2. TongNo
                int trangThai = Convert.ToInt32(dgv_NhapHang_1.Rows[rowIndex].Cells["trangThai"].Value);
                if (trangThai == 0)//chua TT
                {
                    cb_NH_TrangThai.SelectedIndex = 1;
                }
                else
                {//da TT
                    cb_NH_TrangThai.SelectedIndex = 0;
                }



            }
        }

        public void SendDataRowToCommand_NH(int rowIndex)
        {
            //Dk do
            if (dt_NH_1.Rows.Count > 0)
            {
                //DK do
                //0. get VT
                //int rowIndex = dgv_NhapHang_1.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon
                //0. tenDT
                string tenDT = Convert.ToString(dgv_NhapHang_1.Rows[rowIndex].Cells["tenNCC"].Value);
                txt_NH_TenNCC.Text = tenDT;

                //Convert Ko quan tam KDL of Nguon
                //1. NgaySinh
                DateTime dateTime = Convert.ToDateTime(dgv_NhapHang_1.Rows[rowIndex].Cells["ngayLap"].Value);
                dtp_NH_NgayLap.Value = dateTime;

                //2. TongTien
                decimal tongTien = Convert.ToDecimal(dgv_NhapHang_1.Rows[rowIndex].Cells["tongTien"].Value);
                txt_NH_TongTien.Text = tongTien.ToString();

                //2. TongNo
                int trangThai = Convert.ToInt32(dgv_NhapHang_1.Rows[rowIndex].Cells["trangThai"].Value);
                if (trangThai == 0)//chua TT
                {
                    cb_NH_TrangThai.SelectedIndex = 1;
                }
                else
                {//da TT
                    cb_NH_TrangThai.SelectedIndex = 0;
                }



            }
        }


        //2.4  HangHoa
        public void SendDataRowToCommand_HangHoa()
        {
            //Dk do
            if (dt_HangHoa_1.Rows.Count > 0)
            {
                //DK do
                //0. get VT
                int rowIndex = dgv_HangHoa.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon
                //0. tenKH
                string tenDT = Convert.ToString(dgv_HangHoa.Rows[rowIndex].Cells["tenHH"].Value);
                txt_HH_TenHH.Text = tenDT;

                //2. TongTien
                decimal giaMua = Convert.ToDecimal(dgv_HangHoa.Rows[rowIndex].Cells["giaMua"].Value);
                txt_HH_GiaMua.Text = giaMua.ToString();

                //2. TongNo
                decimal SLTon = Convert.ToDecimal(dgv_HangHoa.Rows[rowIndex].Cells["SLTon"].Value);
                txt_HH_SLTon.Text = SLTon.ToString();


            }
        }

        public void SendDataRowToCommand_HangHoa(int rowIndex)
        {
            //Dk do
            if (dt_HangHoa_1.Rows.Count > 0)
            {
                //DK do
                //0. get VT
                // int rowIndex = dgv_HangHoa.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon
                //0. tenKH
                string tenDT = Convert.ToString(dgv_HangHoa.Rows[rowIndex].Cells["tenHH"].Value);
                txt_HH_TenHH.Text = tenDT;

                //2. TongTien
                decimal giaMua = Convert.ToDecimal(dgv_HangHoa.Rows[rowIndex].Cells["giaMua"].Value);
                txt_HH_GiaMua.Text = giaMua.ToString();

                //2. TongNo
                decimal SLTon = Convert.ToDecimal(dgv_HangHoa.Rows[rowIndex].Cells["SLTon"].Value);
                txt_HH_SLTon.Text = SLTon.ToString();


            }
        }


        //2.3  DV
        public void SendDataRowToCommand_DV()
        {
            //Dk do
            if (dt_DV_1.Rows.Count > 0)
            {
                //DK do
                //0. get VT
                int rowIndex = dgv_DichVu.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon
                //0. tenKH
                string tenDT = Convert.ToString(dgv_DichVu.Rows[rowIndex].Cells["tenDV"].Value);
                txt_DV_tenDV.Text = tenDT;

                //2. TongTien
                decimal giaDV = Convert.ToDecimal(dgv_DichVu.Rows[rowIndex].Cells["giaDV"].Value);
                txt_DV_GiaDV.Text = giaDV.ToString();

            }
        }

        public void SendDataRowToCommand_DV(int rowIndex)
        {
            //Dk do
            if (dt_DV_1.Rows.Count > 0)
            {
                //DK do
                //0. get VT
                //int rowIndex = dgv_DichVu.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon
                //0. tenKH
                string tenDT = Convert.ToString(dgv_DichVu.Rows[rowIndex].Cells["tenDV"].Value);
                txt_DV_tenDV.Text = tenDT;

                //2. TongTien
                decimal giaDV = Convert.ToDecimal(dgv_DichVu.Rows[rowIndex].Cells["giaDV"].Value);
                txt_DV_GiaDV.Text = giaDV.ToString();

            }
        }















        //2.1 ChooseFirstValue_And_SendDataRowToCommand_CTHD_HD_DV
        //Hoa Don
        public void ChooseFirstValue_And_SendDataRowToCommand_HD()
        {
            if (dgv_HoaDon.Rows.Count > 0) {
                dgv_HoaDon.Rows[0].Selected = true;
                SendDataRowToCommand_HoaDon(0);
            }

        }

        //KhachHang
        public void ChooseFirstValue_And_SendDataRowToCommand_KhachHang()
        {
            if (dgv_KhachHang_1.Rows.Count > 0)
            {
                dgv_KhachHang_1.Rows[0].Selected = true;
                SendDataRowToCommand_KhachHang(0);
            }

        }

        //NCC
        public void ChooseFirstValue_And_SendDataRowToCommand_NCC() {
            if (dgv_NCC_1.Rows.Count > 0)
            {
                dgv_NCC_1.Rows[0].Selected = true;
                SendDataRowToCommand_NCC(0);
            }

        }

        //NH
        public void ChooseFirstValue_And_SendDataRowToCommand_NH()
        {
            if (dgv_NhapHang_1.Rows.Count > 0)
            {
                dgv_NhapHang_1.Rows[0].Selected = true;
                SendDataRowToCommand_NH(0);
            }

        }


        //HangHoa
        public void ChooseFirstValue_And_SendDataRowToCommand_HangHoa()
        {
            if (dgv_HangHoa.Rows.Count > 0)
            {
                dgv_HangHoa.Rows[0].Selected = true;
                SendDataRowToCommand_HangHoa(0);
            }

        }


        //DichVu
        public void ChooseFirstValue_And_SendDataRowToCommand_DichVu()
        {
            if (dgv_DichVu.Rows.Count > 0)
            {
                dgv_DichVu.Rows[0].Selected = true;
                SendDataRowToCommand_DV(0);
            }

        }



















        //2.2 btn_Chitiet
        //CTHD_HD_DV
        public void Watch_CTHD_HD_DV() {
            //DK do
            if (dgv_HoaDon.Rows.Count > 0)
            {
                //1. get ma
                int nowIndex = dgv_HoaDon.CurrentCell.RowIndex;
                int maHD = Convert.ToInt32(dgv_HoaDon.Rows[nowIndex].Cells["maHD"].Value);

                if (mn_hoaDon_1.CoTonTai_CTHD_HOADON_DICHVU(maHD) == false)
                {
                    MessageBox.Show("Không tồn tại: Chi tiết hóa đơn!!! ");
                    //BT
                    return;
                    //end
                }

                //2. day value cho new_WF
                frm_CTHD_HOADON_DICHVU frm_01 = new frm_CTHD_HOADON_DICHVU(maHD);

                frm_01.FormClosed += (s, args) => Load_Tab_tongQuan();
                frm_01.FormClosed += (s, args) => LoadHH_At_D();


                //3.Show Dialog
                frm_01.ShowDialog();

            }
        }


        //CT_NH_HH
        public void Watch_CT_NH_HH()
        {
            //DK do
            if (dgv_NhapHang_1.Rows.Count > 0)
            {
                //1. get ma
                int nowIndex = dgv_NhapHang_1.CurrentCell.RowIndex;
                int maDT = Convert.ToInt32(dgv_NhapHang_1.Rows[nowIndex].Cells["maNH"].Value);
                //!!==>
                if (mn_tab_NH_1.CoTonTai_DT_in_CT_NH_HH(maDT) == false)
                {
                    MessageBox.Show("Không tồn tại: Chi tiết Nhập Hàng!!! ");
                    //BT
                    if (MessageBox.Show("Bạn có muốn bổ sung không?", "Thông Báo", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    //end
                }

                //2. day value cho new_WF
                frm_LoanSpa_02_tab_NH_CT_NHAPHANG_HANGHOA frm_01 = new frm_LoanSpa_02_tab_NH_CT_NHAPHANG_HANGHOA(maDT);
                frm_01.FormClosed += (s, args) => Load_Tab_tongQuan();

                //3.Show Dialog
                frm_01.ShowDialog();

            }
        }


        //CT_DV_HH
        public void Watch_CT_DV_HH() {
            //DK do
            if (dgv_DichVu.Rows.Count > 0)
            {
                //1. get ma
                int nowIndex = dgv_DichVu.CurrentCell.RowIndex;
                int maDT = Convert.ToInt32(dgv_DichVu.Rows[nowIndex].Cells["maDV"].Value);
                //!!==>
                if (mn_tab_DV_1.CoTonTai_DT_in_CT_DV_HH(maDT) == false)
                {
                    //BT
                    MessageBox.Show("Không tồn tại: Chi tiết Dịch Vụ!!! ");
                    if (MessageBox.Show("Bạn có muốn bổ sung không?", "Thông Báo", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    //end


                }

                //2. day value cho new_WF
                frm_LoanSpa_03_tab_DV_CTSD_DICHVU_HANGHOA hs = new frm_LoanSpa_03_tab_DV_CTSD_DICHVU_HANGHOA(maDT);


                //3.Show Dialog
                hs.ShowDialog();

            }

        }


        //CT_ThemDV // You are at main
        public void Watch_Them_NhapHang() {
            frm_LoanSpa_04_Them_NhapHang_1 hs = new frm_LoanSpa_04_Them_NhapHang_1();

            // Load lai dgv_NH hoi khi dong NH
            hs.FormClosed += (s, args) => LoadNH_At_D();
            hs.FormClosed += (s, args) => LoadNCC_At_D();
            hs.FormClosed += (s, args) => LoadHH_At_D();
            hs.FormClosed += (s, args) => Load_Tab_tongQuan();

            hs.ShowDialog();

        }



















        //4. KT
        public bool Have_TxtBox_Is_Empty_NCC_At_Design()
        {

            //neu co 1 cai rong thi tra ve KQ
            if (txt_NCC_TenNCC.Text == "" || txt_NCC_SDT.Text == "" ||
                txt_NCC_TongNo.Text == "" || txt_NCC_TongTien.Text == "")
            {
                return true;
            }

            return false;
        }

        //4.1 Thanh Toan
        public bool Tab_TT_Have_ND_Txt() {
            if (txt_TT_TenKhachHang.Text == "" ||
                txt_TT_SDT.Text == "") {
                return false;
            }
            return true;
        }

        //2.1 Co chon DV chua
        public bool Tab_TT_Da_Chon_DV_At_D()
        {
            bool Da_Chon = false;
            //
            if (ck_TT_DV_1.Checked == true || ck_TT_DV_2.Checked == true ||
                ck_TT_DV_3.Checked == true || ck_TT_DV_4.Checked == true

                )
            {
                Da_Chon = true;
                return Da_Chon;
            }

            return Da_Chon;
        }





















        //3. Do
        //3.1 Sua
        ///=> Hoa Don
        //3.1 Sua
        public void Sua1_DT_At_Design()
        {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_HoaDon.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_HoaDon.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                int maHD = Convert.ToInt32(dgv_HoaDon.Rows[nowIndex].Cells["maHD"].Value);

                DateTime ngayLap = Convert.ToDateTime(dtp_NgayLap.Value);
                decimal tongTien = Convert.ToDecimal(txt_TongTien.Text);
                decimal giamGia = Convert.ToDecimal(txt_GiamGia.Text);
                decimal soTienDaThanhToan = Convert.ToDecimal(txt_SoTienDaThanhToan.Text);


                //KT
                //MessageBox.Show(" | " + maHD + "\n" +
                //    " | " + ngayLap.ToString() + "\n" +
                //    " | " + ngayLap.Day + "\n" +
                //    " | " + ngayLap.Month + "\n" +
                //    " | " + ngayLap.Year + "\n" +
                //    " | " +tongTien + "\n" +
                //    " | " + giamGia + "\n" +
                //    " | " + soTienDaThanhToan //+ "\n" +
                //    );
                //3.GoiHam
                if (mn_hoaDon_1.Sua1_DT(maHD, ngayLap, tongTien, giamGia, soTienDaThanhToan) == false)
                {
                    MessageBox.Show("Sửa: Thất Bại!!!: ");
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa: Thành công!!!");
                    LoadHoaDon_At_D();
                    Load_Tab_tongQuan();
                    ChooseFirstValue_And_SendDataRowToCommand_HD();
                    return;
                }

                //C.Nhat
            }
            else
            {
                MessageBox.Show("Vui Long Chon Doi Tuong!!!" + "\n" +
                    "====================" + "\n" +
                    "Click vào đầu dòng!!!" //+ "\n" +
                    );
            }

            //end
        }

        //3.2 Xoa
        public void Xoa1_DT_At_Design() {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_HoaDon.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_HoaDon.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                int maHD = Convert.ToInt32(dgv_HoaDon.Rows[nowIndex].Cells["maHD"].Value);

                //DateTime ngayLap = Convert.ToDateTime(dtp_NgayLap.Value);
                //decimal tongTien = Convert.ToDecimal(txt_TongTien.Text);
                //decimal giamGia = Convert.ToDecimal(txt_GiamGia.Text);
                //decimal soTienDaThanhToan = Convert.ToDecimal(txt_SoTienDaThanhToan.Text);

                //2. KT
                if (mn_hoaDon_1.CoTonTai_CTHD_HOADON_DICHVU(maHD) == true)
                {
                    MessageBox.Show("Vui lòng xóa hết CTHD!!!");
                    Watch_CTHD_HD_DV();
                    return;
                }


                //KT
                //MessageBox.Show(" | " + maHD + "\n" +
                //    " | " + ngayLap.ToString() + "\n" +
                //    " | " + ngayLap.Day + "\n" +
                //    " | " + ngayLap.Month + "\n" +
                //    " | " + ngayLap.Year + "\n" +
                //    " | " +tongTien + "\n" +
                //    " | " + giamGia + "\n" +
                //    " | " + soTienDaThanhToan //+ "\n" +
                //    );

                //3.GoiHam
                if (mn_hoaDon_1.Xoa1_DT(maHD) == false)
                {
                    MessageBox.Show("Xóa: Thất Bại!!!: ");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa: Thành công!!!");
                    LoadHoaDon_At_D();
                    Load_Tab_tongQuan();
                    ChooseFirstValue_And_SendDataRowToCommand_HD();
                    return;
                }

                //C.Nhat
            }
            else
            {
                MessageBox.Show("Vui Long Chon Doi Tuong!!!" + "\n" +
                    "====================" + "\n" +
                    "Click vào đầu dòng!!!" //+ "\n" +
                    );
            }

            //end

        }


        //=> tab KhachHang
        //sua
        public void Sua1_DT_KH_At_Design() {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_KhachHang_1.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_KhachHang_1.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                int maDT = Convert.ToInt32(dgv_KhachHang_1.Rows[nowIndex].Cells["maKH"].Value);

                string tenKH = Convert.ToString(txt_KH_TenKH.Text);
                string SDT = Convert.ToString(txt_KH_SDT.Text);

                DateTime ngayLap = Convert.ToDateTime(dtp_KH_NgayLap.Value);
                decimal tongTien = Convert.ToDecimal(txt_KH_TongTien.Text);



                //KT
                //MessageBox.Show(" | " + maHD + "\n" +
                //    " | " + ngayLap.ToString() + "\n" +
                //    " | " + ngayLap.Day + "\n" +
                //    " | " + ngayLap.Month + "\n" +
                //    " | " + ngayLap.Year + "\n" +
                //    " | " +tongTien + "\n" +
                //    " | " + giamGia + "\n" +
                //    " | " + soTienDaThanhToan //+ "\n" +
                //    );
                //3.GoiHam
                if (mn_tab_KhachHang_1.Sua1_DT(maDT, tenKH, SDT, ngayLap, tongTien) == false)
                {
                    MessageBox.Show("Sửa: Thất Bại!!!: ");
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa: Thành công!!!");
                    LoadKhachHang_At_D();
                    ChooseFirstValue_And_SendDataRowToCommand_KhachHang();
                    //SendDataRowToCommand_KhachHang();
                    return;
                }

                //C.Nhat
            }
            else
            {
                MessageBox.Show("Vui Long Chon Doi Tuong!!!" + "\n" +
                    "====================" + "\n" +
                    "Click vào đầu dòng!!!" //+ "\n" +
                    );
            }

            //end
        }

        //3.2 Xoa
        public void Xoa1_DT_KH_At_Design()
        {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_KhachHang_1.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_KhachHang_1.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                int maDT = Convert.ToInt32(dgv_KhachHang_1.Rows[nowIndex].Cells["maKH"].Value);
                string tenKH = Convert.ToString(dgv_KhachHang_1.Rows[nowIndex].Cells["tenKH"].Value);

                //DateTime ngayLap = Convert.ToDateTime(dtp_NgayLap.Value);
                //decimal tongTien = Convert.ToDecimal(txt_TongTien.Text);
                //decimal giamGia = Convert.ToDecimal(txt_GiamGia.Text);
                //decimal soTienDaThanhToan = Convert.ToDecimal(txt_SoTienDaThanhToan.Text);

                //2. KT
                if (mn_tab_KhachHang_1.CoTonTai_DT_in_HD(maDT) == true)
                {
                    MessageBox.Show("Vui lòng xóa hết Hóa đơn của Khách hàng (" + tenKH + ") trước!!!");
                    if (MessageBox.Show("Bạn có muốn chuyển đến Hóa đơn không?", "Thông Báo", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        tab_LoanSpa.SelectedTab = tab_Page_HoaDon;
                    }

                    //Watch_CTHD_HD_DV();
                    return;
                }


                //KT
                //MessageBox.Show(" | " + maHD + "\n" +
                //    " | " + ngayLap.ToString() + "\n" +
                //    " | " + ngayLap.Day + "\n" +
                //    " | " + ngayLap.Month + "\n" +
                //    " | " + ngayLap.Year + "\n" +
                //    " | " +tongTien + "\n" +
                //    " | " + giamGia + "\n" +
                //    " | " + soTienDaThanhToan //+ "\n" +
                //    );

                //3.GoiHam
                if (mn_tab_KhachHang_1.Xoa1_DT(maDT) == false)
                {
                    MessageBox.Show("Xóa: Thất Bại!!!: ");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa: Thành công!!!");
                    LoadKhachHang_At_D();
                    ChooseFirstValue_And_SendDataRowToCommand_KhachHang();
                    //SendDataRowToCommand_KhachHang(0);
                    return;
                }

                //C.Nhat
            }
            else
            {
                MessageBox.Show("Vui Long Chon Doi Tuong!!!" + "\n" +
                    "====================" + "\n" +
                    "Click vào đầu dòng!!!" //+ "\n" +
                    );
            }

            //end

        }



        //=> tab NCC
        //Them
        public void Them1_DT_NCC_At_Design() {
            //dk do
            //co nd
            if (txt_NCC_SDT.Text != "")
            {
                if (mn_tab_NCC_1.CoTonTai_DT_Theo_SDT(txt_NCC_SDT.Text) == true)
                {
                    //MessageBox.Show("co TT!");
                    MessageBox.Show("Vui lòng nhập thông tin cho đối tượng!!!");
                    Set_TextBox_MD_NCC();

                    return;
                }
                else
                {

                    // MessageBox.Show("ko TT!");
                    //chen ND/ goi ham
                    //getND 
                    string tenDT = Convert.ToString(txt_NCC_TenNCC.Text);
                    string SDT = Convert.ToString(txt_NCC_SDT.Text);

                    decimal tongNo = Convert.ToDecimal(txt_NCC_TongNo.Text);
                    decimal tongTien = Convert.ToDecimal(txt_NCC_TongTien.Text);

                    if (mn_tab_NCC_1.Them1_DT(tenDT, SDT, tongNo, tongTien) == false)
                    {
                        MessageBox.Show("Thêm: Thất Bại!!!: ");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm: Thành công!!!");
                        LoadNCC_At_D();
                        ChooseFirstValue_And_SendDataRowToCommand_NCC();
                        //SendDataRowToCommand_KhachHang();
                        return;
                    }

                }


            }
            else {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho đối tượng!!!");
            }



            //else {
            //    MessageBox.Show("Nhap...!!!");
            //    MessageBox.Show("Nhap...!!!");
            //}

            //MessageBox.Show("Vui lòng nhập thông tin cho đối tượng!!!");
            //Set_TextBox_MD_NCC();
            //txt_NCC_TenNCC.Focus();
        }

        //sua
        public void Sua1_DT_NCC_At_Design()
        {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_NCC_1.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_NCC_1.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                int maDT = Convert.ToInt32(dgv_NCC_1.Rows[nowIndex].Cells["maNCC"].Value);

                string tenDT = Convert.ToString(txt_NCC_TenNCC.Text);
                string SDT = Convert.ToString(txt_NCC_SDT.Text);

                decimal tongNo = Convert.ToDecimal(txt_NCC_TongNo.Text);
                decimal tongTien = Convert.ToDecimal(txt_NCC_TongTien.Text);



                //KT
                //MessageBox.Show(" | " + maHD + "\n" +
                //    " | " + ngayLap.ToString() + "\n" +
                //    " | " + ngayLap.Day + "\n" +
                //    " | " + ngayLap.Month + "\n" +
                //    " | " + ngayLap.Year + "\n" +
                //    " | " +tongTien + "\n" +
                //    " | " + giamGia + "\n" +
                //    " | " + soTienDaThanhToan //+ "\n" +
                //    );
                //3.GoiHam
                if (mn_tab_NCC_1.Sua1_DT(maDT, tenDT, SDT, tongNo, tongTien) == false)
                {
                    MessageBox.Show("Sửa: Thất Bại!!!: ");
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa: Thành công!!!");
                    LoadNCC_At_D();
                    ChooseFirstValue_And_SendDataRowToCommand_NCC();
                    //SendDataRowToCommand_KhachHang();
                    return;
                }

                //C.Nhat
            }
            else
            {
                MessageBox.Show("Vui Long Chon Doi Tuong!!!" + "\n" +
                    "====================" + "\n" +
                    "Click vào đầu dòng!!!" //+ "\n" +
                    );
            }

            //end
        }

        //Xoa
        public void Xoa1_DT_NCC_At_Design()
        {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_NCC_1.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_NCC_1.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                int maDT = Convert.ToInt32(dgv_NCC_1.Rows[nowIndex].Cells["maNCC"].Value);
                string tenDT = Convert.ToString(dgv_NCC_1.Rows[nowIndex].Cells["tenNCC"].Value);
                //string tenKH = Convert.ToString(dgv_KhachHang_1.Rows[nowIndex].Cells["tenKH"].Value);

                //DateTime ngayLap = Convert.ToDateTime(dtp_NgayLap.Value);
                //decimal tongTien = Convert.ToDecimal(txt_TongTien.Text);
                //decimal giamGia = Convert.ToDecimal(txt_GiamGia.Text);
                //decimal soTienDaThanhToan = Convert.ToDecimal(txt_SoTienDaThanhToan.Text);


                //!!!
                //2.KT
                if (mn_tab_NCC_1.CoTonTai_DT_in_NH(maDT) == true)
                {
                    MessageBox.Show("Vui lòng xóa hết 'Đơn Nhập Hàng' của Khách hàng (" + tenDT + ") trước!!!");
                    if (MessageBox.Show("Bạn có muốn chuyển đến 'Đơn Nhập Hàng' không?", "Thông Báo", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        tab_LoanSpa.SelectedTab = tab_Page_NhapHang;
                    }

                    //Watch_CTHD_HD_DV();
                    return;
                }


                //KT
                //MessageBox.Show(" | " + maHD + "\n" +
                //    " | " + ngayLap.ToString() + "\n" +
                //    " | " + ngayLap.Day + "\n" +
                //    " | " + ngayLap.Month + "\n" +
                //    " | " + ngayLap.Year + "\n" +
                //    " | " +tongTien + "\n" +
                //    " | " + giamGia + "\n" +
                //    " | " + soTienDaThanhToan //+ "\n" +
                //    );

                //3.GoiHam
                if (mn_tab_NCC_1.Xoa1_DT_Theo_MaDT(maDT) == false)
                {
                    MessageBox.Show("Xóa: Thất Bại!!!: ");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa: Thành công!!!");
                    LoadNCC_At_D();
                    ChooseFirstValue_And_SendDataRowToCommand_NCC();
                    //SendDataRowToCommand_KhachHang(0);
                    return;
                }

                //C.Nhat
            }
            else
            {
                MessageBox.Show("Vui Long Chon Doi Tuong!!!" + "\n" +
                    "====================" + "\n" +
                    "Click vào đầu dòng!!!" //+ "\n" +
                    );
            }

            //end

        }


        //=> tab NH
        //sua
        public void Sua1_DT_NH_At_Design()
        {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_NhapHang_1.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_NhapHang_1.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                int maDT = Convert.ToInt32(dgv_NhapHang_1.Rows[nowIndex].Cells["maNH"].Value);

                DateTime ngayLap = Convert.ToDateTime(dtp_NH_NgayLap.Value);

                decimal tongTien = Convert.ToDecimal(txt_NH_TongTien.Text);


                string sTrangThai = Convert.ToString(cb_NH_TrangThai.Text);
                int trangThai;//chua value
                if (sTrangThai.CompareTo("Đã thanh toán") == 0)
                {
                    trangThai = 1;
                }
                else {
                    trangThai = 0;
                }



                //KT
                //MessageBox.Show(" | " + maHD + "\n" +
                //    " | " + ngayLap.ToString() + "\n" +
                //    " | " + ngayLap.Day + "\n" +
                //    " | " + ngayLap.Month + "\n" +
                //    " | " + ngayLap.Year + "\n" +
                //    " | " +tongTien + "\n" +
                //    " | " + giamGia + "\n" +
                //    " | " + soTienDaThanhToan //+ "\n" +
                //    );
                //3.GoiHam
                if (mn_tab_NH_1.Sua1_DT(maDT, ngayLap, tongTien, trangThai) == false)
                {
                    MessageBox.Show("Sửa: Thất Bại!!!: ");
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa: Thành công!!!");
                    LoadNH_At_D();
                    Load_Tab_tongQuan();
                    ChooseFirstValue_And_SendDataRowToCommand_NH();
                    //SendDataRowToCommand_KhachHang();
                    return;
                }

                //C.Nhat
            }
            else
            {
                MessageBox.Show("Vui Long Chon Doi Tuong!!!" + "\n" +
                    "====================" + "\n" +
                    "Click vào đầu dòng!!!" //+ "\n" +
                    );
            }

            //end
        }

        //3.2 Xoa
        public void Xoa1_DT_NH_At_Design()
        {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_NhapHang_1.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_NhapHang_1.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                int maNH = Convert.ToInt32(dgv_NhapHang_1.Rows[nowIndex].Cells["maNH"].Value);

                //DateTime ngayLap = Convert.ToDateTime(dtp_NgayLap.Value);
                //decimal tongTien = Convert.ToDecimal(txt_TongTien.Text);
                //decimal giamGia = Convert.ToDecimal(txt_GiamGia.Text);
                //decimal soTienDaThanhToan = Convert.ToDecimal(txt_SoTienDaThanhToan.Text);

                //2. KT
                if (mn_tab_NH_1.CoTonTai_DT_in_CT_NH_HH(maNH) == true)
                {
                    MessageBox.Show("Vui lòng xóa hết 'Chi tiết nhập hàng'!!!");
                    Watch_CT_NH_HH();
                    return;
                }


                //KT
                //MessageBox.Show(" | " + maHD + "\n" +
                //    " | " + ngayLap.ToString() + "\n" +
                //    " | " + ngayLap.Day + "\n" +
                //    " | " + ngayLap.Month + "\n" +
                //    " | " + ngayLap.Year + "\n" +
                //    " | " +tongTien + "\n" +
                //    " | " + giamGia + "\n" +
                //    " | " + soTienDaThanhToan //+ "\n" +
                //    );

                //3.GoiHam
                if (mn_tab_NH_1.Xoa1_DT(maNH) == false)
                {
                    MessageBox.Show("Xóa: Thất Bại!!!: ");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa: Thành công!!!");
                    LoadNH_At_D();
                    Load_Tab_tongQuan();
                    ChooseFirstValue_And_SendDataRowToCommand_NH();
                    return;
                }

                //C.Nhat
            }
            else
            {
                MessageBox.Show("Vui Long Chon Doi Tuong!!!" + "\n" +
                    "====================" + "\n" +
                    "Click vào đầu dòng!!!" //+ "\n" +
                    );
            }

            //end

        }



        //=> tab HangHoa
        //sua
        public void Sua1_DT_HangHoa_At_Design()
        {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_HangHoa.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_HangHoa.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                int maDT = Convert.ToInt32(dgv_HangHoa.Rows[nowIndex].Cells["maHH"].Value);

                string tenDT = Convert.ToString(txt_HH_TenHH.Text);

                decimal giaMua = Convert.ToDecimal(txt_HH_GiaMua.Text);
                decimal SLTon = Convert.ToDecimal(txt_HH_SLTon.Text);



                //KT
                //MessageBox.Show(" | " + maHD + "\n" +
                //    " | " + ngayLap.ToString() + "\n" +
                //    " | " + ngayLap.Day + "\n" +
                //    " | " + ngayLap.Month + "\n" +
                //    " | " + ngayLap.Year + "\n" +
                //    " | " +tongTien + "\n" +
                //    " | " + giamGia + "\n" +
                //    " | " + soTienDaThanhToan //+ "\n" +
                //    );
                //3.GoiHam
                if (mn_tab_HangHoa_1.Sua1_DT(maDT, tenDT, giaMua, SLTon) == false)
                {
                    MessageBox.Show("Sửa: Thất Bại!!!: ");
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa: Thành công!!!");
                    LoadHH_At_D();
                    LoadHoaDon_At_D();
                    ChooseFirstValue_And_SendDataRowToCommand_HangHoa();
                    //SendDataRowToCommand_KhachHang();
                    return;
                }

                //C.Nhat
            }
            else
            {
                MessageBox.Show("Vui Long Chon Doi Tuong!!!" + "\n" +
                    "====================" + "\n" +
                    "Click vào đầu dòng!!!" //+ "\n" +
                    );
            }

            //end
        }

        //Xoa
        public void Xoa1_DT_HangHoa_At_Design()
        {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_HangHoa.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_HangHoa.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                int maDT = Convert.ToInt32(dgv_HangHoa.Rows[nowIndex].Cells["maHH"].Value);
                string tenDT = Convert.ToString(dgv_HangHoa.Rows[nowIndex].Cells["tenHH"].Value);
                //string tenKH = Convert.ToString(dgv_KhachHang_1.Rows[nowIndex].Cells["tenKH"].Value);

                //DateTime ngayLap = Convert.ToDateTime(dtp_NgayLap.Value);
                //decimal tongTien = Convert.ToDecimal(txt_TongTien.Text);
                //decimal giamGia = Convert.ToDecimal(txt_GiamGia.Text);
                //decimal soTienDaThanhToan = Convert.ToDecimal(txt_SoTienDaThanhToan.Text);


                //!!!
                //2.KT
                //CT_NH_HH
                if (mn_tab_HangHoa_1.CoTonTai_DT_in_CH_NH_HH(maDT) == true)
                {
                    MessageBox.Show("Vui lòng xóa hết 'Đơn Nhập Hàng' có chứa (" + tenDT + ") trước!!!");
                    if (MessageBox.Show("Bạn có muốn chuyển đến 'Đơn Nhập Hàng' không?", "Thông Báo", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        tab_LoanSpa.SelectedTab = tab_Page_NhapHang;
                    }

                    //Watch_CTHD_HD_DV();
                    return;
                }

                //CT_DV_HH
                if (mn_tab_HangHoa_1.CoTonTai_DT_in_CH_DV_HH(maDT) == true)
                {
                    MessageBox.Show("Vui lòng xóa hết 'Dịch vụ' có chứa (" + tenDT + ") trước!!!");
                    if (MessageBox.Show("Bạn có muốn chuyển đến 'Dịch vụ' không?", "Thông Báo", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        tab_LoanSpa.SelectedTab = tab_Page_DichVu;
                    }

                    //Watch_CTHD_HD_DV();
                    return;
                }



                //KT
                //MessageBox.Show(" | " + maHD + "\n" +
                //    " | " + ngayLap.ToString() + "\n" +
                //    " | " + ngayLap.Day + "\n" +
                //    " | " + ngayLap.Month + "\n" +
                //    " | " + ngayLap.Year + "\n" +
                //    " | " +tongTien + "\n" +
                //    " | " + giamGia + "\n" +
                //    " | " + soTienDaThanhToan //+ "\n" +
                //    );

                //3.GoiHam
                if (mn_tab_HangHoa_1.Xoa1_DT_Theo_MaDT(maDT) == false)
                {
                    MessageBox.Show("Xóa: Thất Bại!!!: ");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa: Thành công!!!");
                    LoadHH_At_D();
                    ChooseFirstValue_And_SendDataRowToCommand_HangHoa();
                    //SendDataRowToCommand_KhachHang(0);
                    return;
                }

                //C.Nhat
            }
            else
            {
                MessageBox.Show("Vui Long Chon Doi Tuong!!!" + "\n" +
                    "====================" + "\n" +
                    "Click vào đầu dòng!!!" //+ "\n" +
                    );
            }

            //end

        }

        //Them
        public void Them1_DT_HangHoa_At_Design()
        {
            //dk do
            //co nd
            if (txt_HH_TenHH.Text != "")
            {
                if (mn_tab_HangHoa_1.CoTonTai_DT_Theo_TenHH(txt_HH_TenHH.Text) == true)
                {
                    //MessageBox.Show("co TT!");
                    MessageBox.Show("Vui lòng nhập thông tin cho đối tượng!!!");
                    Set_TextBox_MD_HangHoa();

                    return;
                }
                else
                {

                    // MessageBox.Show("ko TT!");
                    //chen ND/ goi ham
                    //getND 
                    string tenDT = Convert.ToString(txt_HH_TenHH.Text);


                    decimal giaMua = Convert.ToDecimal(txt_HH_GiaMua.Text);
                    decimal SLTon = Convert.ToDecimal(txt_HH_SLTon.Text);

                    if (mn_tab_HangHoa_1.Them1_DT(tenDT, giaMua, SLTon) == false)
                    {
                        MessageBox.Show("Thêm: Thất Bại!!!: ");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm: Thành công!!!");
                        LoadHH_At_D();
                        ChooseFirstValue_And_SendDataRowToCommand_HangHoa();
                        //SendDataRowToCommand_KhachHang();
                        return;
                    }

                }


            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho đối tượng!!!");
            }



            //else {
            //    MessageBox.Show("Nhap...!!!");
            //    MessageBox.Show("Nhap...!!!");
            //}

            //MessageBox.Show("Vui lòng nhập thông tin cho đối tượng!!!");
            //Set_TextBox_MD_NCC();
            //txt_NCC_TenNCC.Focus();
        }






        //=> tab DichVu
        //Them
        public void Them1_DT_DichVu_At_Design()
        {
            //dk do
            //co nd
            if (txt_DV_tenDV.Text != "")
            {
                if (mn_tab_DV_1.CoTonTai_DT_Theo_TenDV(txt_DV_tenDV.Text) == true)
                {
                    //MessageBox.Show("co TT!");
                    MessageBox.Show("Vui lòng nhập thông tin cho đối tượng!!!");
                    Set_TextBox_MD_DichVu();

                    return;
                }
                else
                {

                    // MessageBox.Show("ko TT!");
                    //chen ND/ goi ham
                    //getND 
                    string tenDT = Convert.ToString(txt_DV_tenDV.Text);


                    decimal giaDV = Convert.ToDecimal(txt_DV_GiaDV.Text);


                    if (mn_tab_DV_1.Them1_DT(tenDT, giaDV) == false)
                    {
                        MessageBox.Show("Thêm: Thất Bại!!!: ");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm: Thành công!!!");
                        LoadDV_At_D();
                        Load_Tab_TT_TenDV_GiaDV_At_D();   
                        ChooseFirstValue_And_SendDataRowToCommand_DichVu();
                        //SendDataRowToCommand_KhachHang();
                        return;
                    }

                }


            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho đối tượng!!!");
            }

        }

        //sua
        public void Sua1_DT_DichVu_At_Design()
        {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_DichVu.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_DichVu.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                int maDT = Convert.ToInt32(dgv_DichVu.Rows[nowIndex].Cells["maDV"].Value);

                string tenDT = Convert.ToString(txt_DV_tenDV.Text);

                decimal giaDT = Convert.ToDecimal(txt_DV_GiaDV.Text);




                //KT
                //MessageBox.Show(" | " + maHD + "\n" +
                //    " | " + ngayLap.ToString() + "\n" +
                //    " | " + ngayLap.Day + "\n" +
                //    " | " + ngayLap.Month + "\n" +
                //    " | " + ngayLap.Year + "\n" +
                //    " | " +tongTien + "\n" +
                //    " | " + giamGia + "\n" +
                //    " | " + soTienDaThanhToan //+ "\n" +
                //    );
                //3.GoiHam
                if (mn_tab_DV_1.Sua1_DT(maDT, tenDT, giaDT) == false)
                {
                    MessageBox.Show("Sửa: Thất Bại!!!: ");
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa: Thành công!!!");
                    LoadDV_At_D();
                    ChooseFirstValue_And_SendDataRowToCommand_DichVu();
                    //SendDataRowToCommand_KhachHang();
                    return;
                }

                //C.Nhat
            }
            else
            {
                MessageBox.Show("Vui Long Chon Doi Tuong!!!" + "\n" +
                    "====================" + "\n" +
                    "Click vào đầu dòng!!!" //+ "\n" +
                    );
            }

            //end
        }

        //3.2 Xoa



        //4. Chuc nang------------------------------------------THANH TOAN BD


        //0. config
        public void Tab_TT_Update_TongTien_To_ChucNang() {
            txt_TT_TongTien.Text = "0";
            txt_TT_TongSauGiam.Text = "0";
            txt_TT_SoTienDaThanhToan.Text = "0";
            decimal tongTien = Get_TongTien_Of_ALL_DV_At_D_GetDecimal();
            txt_TT_TongTien.Text = tongTien.ToString();


            ///
            if (txt_TT_GiamGia.Text.CompareTo("0") == 0)
            {
                txt_TT_TongSauGiam.Text = tongTien.ToString();
                txt_TT_SoTienDaThanhToan.Text = tongTien.ToString();
            }
            else {
                int giamGia = Convert.ToInt32(txt_TT_GiamGia.Text);
                decimal s = (decimal)(tongTien * giamGia) / 100;
                decimal s1 = tongTien - s;
                txt_TT_TongSauGiam.Text = s1.ToString();
                txt_TT_SoTienDaThanhToan.Text = s1.ToString();

            }

        }




        //LOAD TT
        public void Load_ALL_For_ThanhToan() {
            Set_Tab_TT_MD_ALL_TXT_Check_TenDV_GiaDVMD();
            //
            LoadHoaDon_At_D();
            LoadKhachHang_At_D();
            Load_Tab_tongQuan();
        }





        //get
        public bool Tab_TT_Have_SDT_In_DT() {
            if (txt_TT_SDT.Text != "") {
                return mn_tab_KhachHang_1.CoTonTai_SDT_In_DT(txt_TT_SDT.Text);
            }
            return true;

        }

        public int Get_MaKH_From_SDT_At_D(string SDT) {
            int maKH = -1;
            DataTable dt_Temp_1 = new DataTable();
            dt_Temp_1 = mn_tab_KhachHang_1.Get_MaKH_From_SDT_GetDataTable(SDT);
            maKH = Convert.ToInt32(dt_Temp_1.Rows[0]["maKH"]);
            return maKH;
        }
        public int Get_MaKH_MoiNhat_At_D() {
            int maKH = -1;
            DataTable dt_Temp_1 = new DataTable();
            dt_Temp_1 = mn_tab_KhachHang_1.Get_MaKH_MoiNhat_GetDataTable();
            maKH = Convert.ToInt32(dt_Temp_1.Rows[0]["maKH"]);
            return maKH;
        }

        public int InsertUpdate_And_Get_maKH_From_KH_GetInt() {
            int maKH = -1;
            ///
            string tenKH = txt_TT_TenKhachHang.Text;
            string SDT = txt_TT_SDT.Text;
            decimal tongTien = Convert.ToDecimal(txt_TT_SoTienDaThanhToan.Text);
            if (Tab_TT_Have_SDT_In_DT() == false)
            {
                //MessageBox.Show("chua ton tai sdt!!!");
                //->Chen 1 KH, get new maKH 
                //get nd chen

                if (mn_tab_KhachHang_1.Them1_DT(tenKH, SDT, tongTien) == false)
                {
                    //ko chen dc-> out
                    maKH = -1;
                    return maKH;
                }
                else { //TH: SUCCESS
                    //-> get MSSV thoi
                    maKH = Get_MaKH_MoiNhat_At_D();
                    return maKH;

                }

            }
            else
            {
                //MessageBox.Show("ton tai sdt!!!");
                //->CN 1 KH(tong tien), get maKH theo SDT
                maKH = Get_MaKH_From_SDT_At_D(SDT);
                //C.Nhat T.Tien
                if (mn_tab_KhachHang_1.Sua1_DT_Theo_MaDT_Va_TongTien(maKH, tongTien) == false) {
                    maKH = -1;
                }
                return maKH;
            }

            //
            return maKH;
        }







        //1. get Tong tien
        /// tongTien  DV1->DV4 BD
        //1
        private decimal Get_GiaDV_From_ShowGiaMua_GetDecimal(string sShowGiaDV)
        {
            decimal giaDV = 0;

            giaDV = Convert.ToDecimal(sShowGiaDV);
            // MessageBox.Show("" + a);

            return giaDV;
        }

        /// tongTien DV1->DV4 BD
        //DV1
        public decimal Get_TongTien_Of_DV1_At_D_GetDecimal()
        {

            decimal tongTien = 0;

            //1. xet cac muc
            if (ck_TT_DV_1.Checked == true)
            {
                if (nb_TT_DV_1.Value > 0)
                {
                    //giaMua
                    decimal giaDV = Get_GiaDV_From_ShowGiaMua_GetDecimal(txt_TT_GiaDV_DV_1.Text);
                    decimal soLuong = nb_TT_DV_1.Value;
                    tongTien += (decimal)(giaDV * soLuong);
                }

            }

            return tongTien;
        }

        //DV2
        public decimal Get_TongTien_Of_DV2_At_D_GetDecimal()
        {

            decimal tongTien = 0;

            //1. xet cac muc
            if (ck_TT_DV_2.Checked == true)
            {
                if (nb_TT_DV_2.Value > 0)
                {
                    //giaMua
                    decimal giaDV = Get_GiaDV_From_ShowGiaMua_GetDecimal(txt_TT_GiaDV_DV_2.Text);
                    decimal soLuong = nb_TT_DV_2.Value;
                    tongTien += (decimal)(giaDV * soLuong);
                }

            }

            return tongTien;
        }

        //DV3
        public decimal Get_TongTien_Of_DV3_At_D_GetDecimal()
        {

            decimal tongTien = 0;

            //1. xet cac muc
            if (ck_TT_DV_3.Checked == true)
            {
                if (nb_TT_DV_3.Value > 0)
                {
                    //giaMua
                    decimal giaDV = Get_GiaDV_From_ShowGiaMua_GetDecimal(txt_TT_GiaDV_DV_3.Text);
                    decimal soLuong = nb_TT_DV_3.Value;
                    tongTien += (decimal)(giaDV * soLuong);
                }

            }

            return tongTien;
        }

        //DV4
        public decimal Get_TongTien_Of_DV4_At_D_GetDecimal()
        {

            decimal tongTien = 0;

            //1. xet cac muc
            if (ck_TT_DV_4.Checked == true)
            {
                if (nb_TT_DV_4.Value > 0)
                {
                    //giaMua
                    decimal giaDV = Get_GiaDV_From_ShowGiaMua_GetDecimal(txt_TT_GiaDV_DV_4.Text);
                    decimal soLuong = nb_TT_DV_4.Value;
                    tongTien += (decimal)(giaDV * soLuong);
                }

            }

            return tongTien;
        }


        /// tongTien DV1->DV4 END
        //HH ALL HH
        public decimal Get_TongTien_Of_ALL_DV_At_D_GetDecimal()
        {

            decimal tongTien = 0;

            //1. xet cac muc
            //DV1
            if (ck_TT_DV_1.Checked == true)
            {
                if (nb_TT_DV_1.Value > 0)
                {
                    //giaMua
                    decimal T_Tien = Get_TongTien_Of_DV1_At_D_GetDecimal();
                    tongTien += T_Tien;
                }
            }

            //DV2
            if (ck_TT_DV_2.Checked == true)
            {
                if (nb_TT_DV_2.Value > 0)
                {
                    //giaMua
                    decimal T_Tien = Get_TongTien_Of_DV2_At_D_GetDecimal();
                    tongTien += T_Tien;
                }
            }

            //DV3
            if (ck_TT_DV_3.Checked == true)
            {
                if (nb_TT_DV_3.Value > 0)
                {
                    //giaMua
                    decimal T_Tien = Get_TongTien_Of_DV3_At_D_GetDecimal();
                    tongTien += T_Tien;
                }
            }

            //DV4
            if (ck_TT_DV_4.Checked == true)
            {
                if (nb_TT_DV_4.Value > 0)
                {
                    //giaMua
                    decimal T_Tien = Get_TongTien_Of_DV4_At_D_GetDecimal();
                    tongTien += T_Tien;
                }
            }

            return tongTien;
        }





        /// 1.2 sInsert data CT_HH_DV H1->H8 BD  
        //get ND insert
        //HH 1
        public bool SUCCESS_Insert_CT_HD_DV_For_DV_1_GetBool(int maHD)
        {

            if (ck_TT_DV_1.Checked == true)
            {
                //get ND
                int maDV = mn_tab_DV_1.Get_MaDV_From_ShowTenDV_GetInt(lab_TT_DV1.Text);
                decimal soLuong = nb_TT_DV_1.Value;
                decimal DonGia = Convert.ToDecimal(txt_TT_GiaDV_DV_1.Text);

                //run + KT
                if (mn_tab_CT_HD_DV.Them1_DT(maHD, maDV, soLuong, DonGia) == false)
                {
                    return false;
                }
            }
            return true;
        }


        //HH 2
        public bool SUCCESS_Insert_CT_HD_DV_For_DV_2_GetBool(int maHD)
        {

            if (ck_TT_DV_2.Checked == true)
            {
                //get ND
                int maDV = mn_tab_DV_1.Get_MaDV_From_ShowTenDV_GetInt(lab_TT_DV2.Text);
                decimal soLuong = nb_TT_DV_2.Value;
                decimal DonGia = Convert.ToDecimal(txt_TT_GiaDV_DV_2.Text);

                //run + KT
                if (mn_tab_CT_HD_DV.Them1_DT(maHD, maDV, soLuong, DonGia) == false)
                {
                    return false;
                }
            }
            return true;
        }

        //HH 3
        public bool SUCCESS_Insert_CT_HD_DV_For_DV_3_GetBool(int maHD)
        {

            if (ck_TT_DV_3.Checked == true)
            {
                //get ND
                int maDV = mn_tab_DV_1.Get_MaDV_From_ShowTenDV_GetInt(lab_TT_DV3.Text);
                decimal soLuong = nb_TT_DV_3.Value;
                decimal DonGia = Convert.ToDecimal(txt_TT_GiaDV_DV_3.Text);

                //run + KT
                if (mn_tab_CT_HD_DV.Them1_DT(maHD, maDV, soLuong, DonGia) == false)
                {
                    return false;
                }
            }
            return true;
        }

        //HH 4
        public bool SUCCESS_Insert_CT_HD_DV_For_DV_4_GetBool(int maHD)
        {

            if (ck_TT_DV_4.Checked == true)
            {
                //get ND
                int maDV = mn_tab_DV_1.Get_MaDV_From_ShowTenDV_GetInt(lab_TT_DV4.Text);
                decimal soLuong = nb_TT_DV_4.Value;
                decimal DonGia = Convert.ToDecimal(txt_TT_GiaDV_DV_4.Text);

                //run + KT
                if (mn_tab_CT_HD_DV.Them1_DT(maHD, maDV, soLuong, DonGia) == false)
                {
                    return false;
                }
            }
            return true;
        }




        public bool SUCCESS_Insert_CT_HD_DV_For_ALL_DV_GetBool(int maHD)
        {

            //duyet 
            //HH 1  
            if (SUCCESS_Insert_CT_HD_DV_For_DV_1_GetBool(maHD) == false)
            {
                return false;
            }

            //HH 2
            if (SUCCESS_Insert_CT_HD_DV_For_DV_2_GetBool(maHD) == false)
            {
                return false;
            }

            //HH 3
            if (SUCCESS_Insert_CT_HD_DV_For_DV_3_GetBool(maHD) == false)
            {
                return false;
            }

            //HH 4
            if (SUCCESS_Insert_CT_HD_DV_For_DV_4_GetBool(maHD) == false)
            {
                return false;
            }


            return true;
        }












        //4. Chuc nang
        //Tab ThanhToan
        public void ThanhToan_Tab_TT() {
            //BD

            //1. KT
            if (Tab_TT_Have_ND_Txt() == false) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!!!");
                return;
            }

            //DV
            if (Tab_TT_Da_Chon_DV_At_D() == false) {
                MessageBox.Show("Vui lòng Dịch vụ đã dụng!!!");
                return;
            }


            //2. Do get maKH
            //2.1 get ND Chen
            //get tongTien
            //da co all TT
            //input: sdt
            int maKH = InsertUpdate_And_Get_maKH_From_KH_GetInt();
            if (maKH == -1) {
                MessageBox.Show("Chèn Khách hàng: Thất bại!!!");
                return;
            }
            //MessageBox.Show("maKH: "+maKH);

            //-> da co maKH-> chen HoaDon
            decimal tongTien = Get_TongTien_Of_ALL_DV_At_D_GetDecimal();
            decimal giamGia = Convert.ToDecimal(txt_TT_GiamGia.Text);
            decimal soTienDaThanhToan = Convert.ToDecimal(txt_TT_SoTienDaThanhToan.Text);

            if (mn_hoaDon_1.Them1_DT(tongTien, giamGia, soTienDaThanhToan, maKH) == false) {
                MessageBox.Show("Chèn Hóa đơn: Thất bại!!!");
                return;
            }

            int maHD = mn_hoaDon_1.Get_MaHD_MoiNhat_GetInt();

            //-> da co HoaDon-> get maHD-> chen CT_HD_DV
            //Chen CT_HD_DV
            if (SUCCESS_Insert_CT_HD_DV_For_ALL_DV_GetBool(maHD) == false) {
                MessageBox.Show("Chèn CT_HD_DV: Thất bại!!!");
                return;
            }





            //CN
            MessageBox.Show("Thanh Toán: Thành công!!!");
            //Set_Tab_TT_MD_ALL_TXT_Check_TenDV_GiaDVMD();
            Load_ALL_For_ThanhToan();

            //END
        }




        //4. Chuc nang----------------------------------------------THANH TOAN END


        //4. Chuc nang----------------------------------------------><===============><----------------------------------------------TongQuan BD


        //4. Chuc nang----------------------------------------------TongQuan BD
        public void Load_Tab_tongQuan() {
            txt_TQ_SL_KH_in_Day.Text = mn_TQ_1.Get_SL_KH_In_Day_GetInt().ToString();
            txt_TQ_Thu.Text = mn_TQ_1.Get_Thu_In_Day_GetDecimal().ToString();
            txt_TQ_Chi.Text = mn_TQ_1.Get_Chi_In_Day_GetDecimal().ToString();

        }







        //4. Chuc nang----------------------------------------------TongQuan END






        //4. Chuc nang----------------------------------------------><===============><----------------------------------------------

        //4. Chuc nang----------------------------------------------Bao Cao BD
        public void Load_Tab_BaoCao()
        {
            //
            ck_BC_Ngay.Checked = false;
            ck_BC_Thang.Checked = false;
            ck_BC_Nam.Checked = false;
            ck_BC_TuAdenB.Checked = false;

            dtp_BC_TuNgayA.Value = DateTime.Now;
            dtp_BC_TuNgayB.Value=DateTime.Now;

        }


        //KT
        //da chon chua
        public bool Tab_BC_Da_Chon_Moc_Time() {
            if (ck_BC_Ngay.Checked == true || ck_BC_Thang.Checked == true ||
                ck_BC_Nam.Checked == true || ck_BC_TuAdenB.Checked == true) { 
                return true;
            
            }
            return false;

        }

        //CN
        public void Tab_BC_ThongKe() {
            if (Tab_BC_Da_Chon_Moc_Time() == false) {

                MessageBox.Show("Vui lòng chọn mốc thời gian!!!");
                return;
            }


            ///day
            if (ck_BC_Ngay.Checked == true) {
                MessageBox.Show("Cập Nhật Báo Cáo Theo Ngày: Thành Công!!!");
                txt_BC_SL_KH.Text = mn_TQ_1.Get_SL_KH_In_Day_GetInt().ToString();
                txt_BC_Thu.Text = mn_TQ_1.Get_Thu_In_Day_GetDecimal().ToString();
                txt_BC_Chi.Text = mn_TQ_1.Get_Chi_In_Day_GetDecimal().ToString();
                //
                gb1_BC_CTBC.Text = "Báo Cáo: Theo Ngày";
            }



            ///month
            if (ck_BC_Thang.Checked == true)
            {
                MessageBox.Show("Cập Nhật Báo Cáo Theo Tháng: Thành Công!!!");
                txt_BC_SL_KH.Text = mn_BC_1.Get_SL_KH_In_Month_GetInt().ToString();
                txt_BC_Thu.Text = mn_BC_1.Get_Thu_In_Month_GetDecimal().ToString();
                txt_BC_Chi.Text = mn_BC_1.Get_Chi_In_Month_GetDecimal().ToString();
                //
                gb1_BC_CTBC.Text = "Báo Cáo: Theo Tháng";
            }


            ///Year
            if (ck_BC_Nam.Checked == true)
            {
                MessageBox.Show("Cập Nhật Báo Cáo Theo Năm: Thành Công!!!");
                txt_BC_SL_KH.Text = mn_BC_1.Get_SL_KH_In_Year_GetInt().ToString();
                txt_BC_Thu.Text = mn_BC_1.Get_Thu_In_Year_GetDecimal().ToString();
                txt_BC_Chi.Text = mn_BC_1.Get_Chi_In_Year_GetDecimal().ToString();
                //
                gb1_BC_CTBC.Text = "Báo Cáo: Theo Năm";
            }


            ///A->B
            if (ck_BC_TuAdenB.Checked == true)
            {
                //get date
                DateTime dt_A_1 = dtp_BC_TuNgayA.Value;
                DateTime dt_B_1 = dtp_BC_TuNgayB.Value;
                ///
                int dayA=dt_A_1.Day;
                int monthA = dt_A_1.Month;
                int yearA = dt_A_1.Year;

                //B
                int dayB = dt_B_1.Day;
                int monthB = dt_B_1.Month;
                int yearB = dt_B_1.Year;


                MessageBox.Show("Cập Nhật Báo Cáo Theo Khoảng: Thành Công!!!");
                txt_BC_SL_KH.Text = mn_BC_1.Get_SL_KH_In_A_To_B_GetInt(dayA, monthA, yearA, dayB, monthB, yearB).ToString();
                txt_BC_Thu.Text = mn_BC_1.Get_Thu_In_A_To_B_GetDecimal(dayA, monthA, yearA, dayB, monthB, yearB).ToString();
                txt_BC_Chi.Text = mn_BC_1.Get_Chi_In_A_To_B_GetDecimal(dayA, monthA, yearA, dayB, monthB, yearB).ToString();
                //
                string a="("+dayA+"/"+monthA+"/"+yearA+")";
                string b = "(" + dayB + "/" + monthB + "/" + yearB + ")";

                gb1_BC_CTBC.Text = "";
                gb1_BC_CTBC.Text = "Báo Cáo: Theo Khoảng " + a+ " -> "+b;
            }






            //CN
            Load_Tab_BaoCao();
        }




        //4. Chuc nang----------------------------------------------Bao Cao END
















        ///===================================LOAD======================================================
        private void frm_LoanSpa_Main_01_Load(object sender, EventArgs e)
        {


            

            //1 Load
            //1.-1 load Color btn_
            LoadColor_Btn();
            //1.0 Load img
            Load_Imgs();




            //1.1 Load HoaDon
            LoadHoaDon_At_D();

            //1.2 Load KhachHang
            LoadKhachHang_At_D();

            //1.3 Load NCC
            LoadNCC_At_D();

            //1.4 Load NH
            LoadNH_At_D();

            //1.4 Load HH
            LoadHH_At_D();

            //1.4 Load DV
            LoadDV_At_D();

            //2. Thanh Toan
            // load tenDV_GiaDV
            Load_Tab_TT_TenDV_GiaDV_At_D();

            Set_Tab_TT_MD_ALL_TXT_Check_TenDV_GiaDVMD();

            Load_Tab_tongQuan();


            Load_Tab_BaoCao();

            //Tbao
            if (iQuyen == 0)
            {
                MessageBox.Show("Chào mừng: Nhân viên '" + taiKhoan + "'\n" +
                    ">==================<" + "\n" +
                    "Have a nice Day"// + "\n" +
                    ////
                );


                //
                XoaTabDoiVoi_NhanVien();

            }
            else if (iQuyen == 1)
            {
                MessageBox.Show("Chào mừng: Admin '" + taiKhoan + "'\n" +
                    ">==================<" + "\n" +
                    "Have a nice Day"// + "\n" +
                );

            }
            //load cb_





            ///2. Cap Nhat
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Test1_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedIndex = 0;
        }   

        private void btn_Test2_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedIndex = 1;
        }

        private void btn_Test3_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedIndex = 2;
        }

        private void frm_LoanSpa_Main_01_FormClosing(object sender, FormClosingEventArgs e)
        {
            Part_0_1_PT_For_WF_Base_1 hs=new Part_0_1_PT_For_WF_Base_1();
      
            hs.NoticeWhenClosing(sender, e);
            //this.ShowDialog();
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendDataRowToCommand_HoaDon();

        }

        private void btn_Them_HDon_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedIndex = 1;
        }








        //4.2.n .. Test LK
        public void m1()
        {
            DB_Mau hs = new DB_Mau();
            Manager_DataBase_1 db0 = new Manager_DataBase_1();
            Part_0_2_PT_For_DataBase_1 db1 = new Part_0_2_PT_For_DataBase_1();
            Manager_HoaDon_1 db2 = new Manager_HoaDon_1();


        }

        private void btn_ChiTiet_HDon_Click(object sender, EventArgs e)
        {
            Watch_CTHD_HD_DV();

           // MessageBox.Show("dan: "+maHD);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedIndex = 5;
           // MessageBox.Show(nb_chonSL_M_Da.Value.ToString());
        }

        private void dgv_HoaDon_SelectionChanged(object sender, EventArgs e)
        {
            ChooseFirstValue_And_SendDataRowToCommand_HD();
        }

        private void btn_Sua_Hdon_Click(object sender, EventArgs e)
        {
            Sua1_DT_At_Design();
        }

        private void txt_TongTien_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender,e);
        }

        private void txt_TongSauGiam_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender,e);
        }

        private void txt_SoTienDaThanhToan_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_TongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedIndex = 4;
            //decimal so_toDecimal = Convert.ToDecimal(txt_TongTien.Text );
            
            //MessageBox.Show("text: "+ txt_TongTien.Text + "\n"+
            //    "toDecimal: "+ so_toDecimal + "\n" +
            //    "text: " + txt_TongTien.Text + "\n" +
            //    "textBoPhay: " + txt_TongTien.Text.Replace(",","") + "\n" +
            //    "textBoPhay_ToInt: " + Convert.ToInt32(txt_TongTien.Text.Replace(",", "")) + "\n" +
            //    "textBoPhay_ToDecimal: " + Convert.ToDecimal(txt_TongTien.Text.Replace(",", ""))// + "\n" +

            // );
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedIndex = 3;
            //decimal so_1 = Convert.ToDecimal(txt_TongTien.Text);
            ////   int so_2 = Convert.ToInt32("100,000");
            ////1. se bao loi vi co "," :))
            ////1. int so=Convert.ToInt32(txt_TongTien.Text);
            //MessageBox.Show("dan: " + so_1 + "\n" +
            //    "dan: "// + so_2

            //    );
        }

        private void txt_GiamGia_TextChanged(object sender, EventArgs e)
        {
            //BD

            int a;//Cho cho nhao tu x->y
            if (int.TryParse(txt_GiamGia.Text, out a))
            {
                //ko thoa dk Tho Bo
                if (a < 0 || a > 100)
                {
                    txt_GiamGia.Text = "";
                }

            }

            if (txt_GiamGia.Text == "") {
                txt_GiamGia.Text = "0";
            }

            //end
        }

        private void txt_GiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender,e);
        }

        private void txt_SoTienDaThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void btn_Xoa_HDon_Click(object sender, EventArgs e)
        {
            Xoa1_DT_At_Design();
        }

        private void txt_TenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyText(sender,e);
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void ck_M_Da_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_TT_DV_1.Checked == true)
            {
               // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_1.Enabled = true;
                nb_TT_DV_1.Value = 1;
            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_1.Enabled = false;
                nb_TT_DV_1.Value = 0;
            }
        }

        private void ck_M_Mat_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_TT_DV_3.Checked == true)
            {
                // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_3.Enabled = true;
                nb_TT_DV_3.Value = 1;
            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_3.Enabled = false;
                nb_TT_DV_3.Value = 0;
            }
        }

        private void ck_M_ToanThan_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_TT_DV_2.Checked == true)
            {
                // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_2.Enabled = true;
                nb_TT_DV_2.Value = 1;
            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_2.Enabled = false;
                nb_TT_DV_2.Value = 0;
            }
        }

        private void ck_M_GoiDau_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_TT_DV_4.Checked == true)
            {
                // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_4.Enabled = true;
                nb_TT_DV_4.Value = 1;
            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_4.Enabled = false;
                nb_TT_DV_4.Value = 0;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedIndex = 6;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedIndex = 7;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyText(sender,e);
        }

        private void txt_OnlyDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_KH_SDT.MaxLength = 12;
            part_0.TextBoxOnlyNumberMaDT(sender,e);
        }

        private void txt_KH_TongTien_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender,e);
        }

        private void txt_KH_TongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            part_0.TextBoxOnlyNumberMaDT(sender,e);
        }

        private void dgv_KhachHang_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendDataRowToCommand_KhachHang();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedIndex = 8;
        }

        private void btn_tab_KH_Sua_Click(object sender, EventArgs e)
        {
            Sua1_DT_KH_At_Design();
        }

        private void btn_tab_KH_Xoa_Click(object sender, EventArgs e)
        {
            Xoa1_DT_KH_At_Design();
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            Watch_Them_NhapHang();
        }



        private void btn_Hodoan_Click_1(object sender, EventArgs e)
        {

        }

        private void tab_LoanSpa_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // KT neu co truy cap vao tab x (index x)
            //if (iQuyen == 0) {
            //    if (e.TabPage == tab_LoanSpa.TabPages[3] || e.TabPage == tab_LoanSpa.TabPages[4]||
            //        e.TabPage == tab_LoanSpa.TabPages[5] || e.TabPage == tab_LoanSpa.TabPages[6]
            //        )
            //    {
            //        // bo chon tab tab
            //        e.Cancel = true;

            //        // T.Bao
            //        MessageBox.Show("Bạn không được phép vào tab này!", "Thông báo",
            //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }

            //}




        }

        private void dgv_NCC_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendDataRowToCommand_NCC();
        }

        private void txt_NCC_TongNo_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender,e);
        }

        private void txt_NCC_TongNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender,e);
        }

        private void txt_NCC_TongTien_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_NCC_TongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void txt_NCC_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_NCC_SDT.MaxLength = 12;
            part_0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void txt_NCC_TenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyText(sender, e);
        }

        private void btn_Sua_NCC_Click(object sender, EventArgs e)
        {
            Sua1_DT_NCC_At_Design();
        }

        private void btn_Them_NCC_Click(object sender, EventArgs e)
        {
            Them1_DT_NCC_At_Design();
        }

        private void btn_NH_Xoa_Click(object sender, EventArgs e)
        {
            Xoa1_DT_NH_At_Design();
        }

        private void btn_Xoa_NCC_Click(object sender, EventArgs e)
        {
            Xoa1_DT_NCC_At_Design();
        }

        private void dgv_NhapHang_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendDataRowToCommand_NH();
        }

        private void txt_NH_TenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyText(sender,e);
        }

        private void txt_NH_TongTien_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender,e);  
        }

        private void txt_NH_TongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender,e);
        }

        private void btn_Sua_NH_Click(object sender, EventArgs e)
        {
            Sua1_DT_NH_At_Design();
        }

        private void btn_ChiTiet_NH_Click(object sender, EventArgs e)
        {
            Watch_CT_NH_HH();
        }

        private void dgv_HangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendDataRowToCommand_HangHoa();
        }

        private void txt_HH_GiaMua_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender,e);
        }

        private void txt_HH_GiaMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void txt_HH_SLTon_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_HH_SLTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void btn_Sua_HH_Click(object sender, EventArgs e)
        {
            Sua1_DT_HangHoa_At_Design();
        }

        private void btn_Xoa_HH_Click(object sender, EventArgs e)
        {
            Xoa1_DT_HangHoa_At_Design();
        }

        private void btn_Them_HH_Click(object sender, EventArgs e)
        {
            Them1_DT_HangHoa_At_Design();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender,e);
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void dgv_DichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendDataRowToCommand_DV();
        }

        private void btn_Sua_DV_Click(object sender, EventArgs e)
        {
            Sua1_DT_DichVu_At_Design();
        }

        private void btn_ChiTiet_DV_Click(object sender, EventArgs e)
        {
            Watch_CT_DV_HH();
        }

        private void btn_Xoa_DV_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_DV_Click(object sender, EventArgs e)
        {
            Them1_DT_DichVu_At_Design();
        }

        private void btn_Them_NH_Click(object sender, EventArgs e)
        {
            Watch_Them_NhapHang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime hs= DateTime.Now;

            MessageBox.Show(""+mn_TQ_1.Get_SL_KH_In_Day_GetInt().ToString() );
            //MessageBox.Show("dan 2: " + Get_TongTien_Of_DV2_At_D_GetDecimal());
            //MessageBox.Show("dan 3: " + Get_TongTien_Of_DV3_At_D_GetDecimal());
            //MessageBox.Show("dan 4: " + Get_TongTien_Of_DV4_At_D_GetDecimal());
            //tab_LoanSpa.TabPages.Remove(tab_Page_BaoCao);
            //tab_LoanSpa.TabPages.Remove(tab_Page_KhachHang);
            //tab_LoanSpa.TabPages.Remove(tab_Page_NCC);
            // tab_LoanSpa.TabPages.Remove(tab_Page_NhapHang);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedTab = tab_Page_DichVu;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            //
            if (ck_BC_TuAdenB.Checked == true) { 
                
                ck_BC_Ngay.Checked = false;
                ck_BC_Thang.Checked = false;
                ck_BC_Nam.Checked = false;
            }
        }

        private void txt_TT_GiamGia_TextChanged(object sender, EventArgs e)
        {
            //BD

            int a;//Cho cho nhao tu x->y
            if (int.TryParse(txt_TT_GiamGia.Text, out a))
            {
                //ko thoa dk Tho Bo
                if (a < 0 || a > 100)
                {
                    txt_TT_GiamGia.Text = "";
                }

            }


            ///
            decimal tongTien = Get_TongTien_Of_ALL_DV_At_D_GetDecimal();
            if (txt_TT_GiamGia.Text != "") {
                
                int giamGia = Convert.ToInt32(txt_TT_GiamGia.Text);
                decimal s = (decimal)(tongTien * giamGia) / 100;
                decimal s1 = tongTien - s;
                txt_TT_TongSauGiam.Text = s1.ToString();
                txt_TT_SoTienDaThanhToan.Text = s1.ToString();
            } else {
                txt_TT_GiamGia.Text = "0";
                txt_TT_TongSauGiam.Text = tongTien.ToString();
                txt_TT_SoTienDaThanhToan.Text = tongTien.ToString();

            }


            //end
            // part_0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_TT_GiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender, e);    
        }

        private void txt_TT_SoTienDaThanhToan_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender, e);
            //
            if (txt_TT_SoTienDaThanhToan.Text == "") {
                txt_TT_SoTienDaThanhToan.Text = 0.ToString();


            }
        }

        private void txt_TT_SoTienDaThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void ck_TT_M_Da_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_TT_DV_1.Checked == true)
            {
                // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_1.Enabled = true;
                nb_TT_DV_1.Value = 1;

                //get money to txt
                Tab_TT_Update_TongTien_To_ChucNang();


            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_1.Enabled = false;
                nb_TT_DV_1.Value = 0;
            }
        }

        private void ck_TT_M_ToanThan_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_TT_DV_2.Checked == true)
            {
                // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_2.Enabled = true;
                nb_TT_DV_2.Value = 1;
                Tab_TT_Update_TongTien_To_ChucNang();
            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_2.Enabled = false;
                nb_TT_DV_2.Value = 0;
            }
        }

        private void ck_TT_M_Mat_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_TT_DV_3.Checked == true)
            {
                // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_3.Enabled = true;
                nb_TT_DV_3.Value = 1;
                Tab_TT_Update_TongTien_To_ChucNang();
            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_3.Enabled = false;
                nb_TT_DV_3.Value = 0;
            }
        }

        private void ck_TT_GoiDau_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_TT_DV_4.Checked == true)
            {
                // MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_4.Enabled = true;
                nb_TT_DV_4.Value = 1;
                Tab_TT_Update_TongTien_To_ChucNang();
            }
            else
            {
                //MessageBox.Show("Da Chon: " + ck_M_Da.Checked);
                nb_TT_DV_4.Enabled = false;
                nb_TT_DV_4.Value = 0;
            }
        }

        private void btn_TT_ThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan_Tab_TT();
        }

        private void nb_TT_DV_1_ValueChanged(object sender, EventArgs e)
        {
            //get money to txt
            Tab_TT_Update_TongTien_To_ChucNang();
        }

        private void nb_TT_DV_2_ValueChanged(object sender, EventArgs e)
        {
            Tab_TT_Update_TongTien_To_ChucNang();
        }

        private void nb_TT_DV_3_ValueChanged(object sender, EventArgs e)
        {
            Tab_TT_Update_TongTien_To_ChucNang();
        }

        private void nb_TT_DV_4_ValueChanged(object sender, EventArgs e)
        {
            Tab_TT_Update_TongTien_To_ChucNang();
        }

        private void txt_TT_TongTien_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_TT_TongSauGiam_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_TQ_SL_KH_in_Day_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_TQ_Thu_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_TQ_Chi_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender, e);
        }

        private void btn_BC_ThongKe_Click(object sender, EventArgs e)
        {
            Tab_BC_ThongKe();
        }

        private void ck_BC_Ngay_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_BC_Ngay.Checked == true) {
              //  ck_BC_Ngay.Checked = false;
                ck_BC_Thang.Checked = false;
                ck_BC_Nam.Checked = false;
                ck_BC_TuAdenB.Checked = false;
            }
        }

        private void ck_BC_Thang_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_BC_Thang.Checked == true) {
                ck_BC_Ngay.Checked = false;
                //ck_BC_Thang.Checked = false;
                ck_BC_Nam.Checked = false;
                ck_BC_TuAdenB.Checked = false;
            }
        }

        private void ck_BC_Nam_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_BC_Nam.Checked == true) {
                ck_BC_Ngay.Checked = false;
                ck_BC_Thang.Checked = false;
          //      ck_BC_Nam.Checked = false;
                ck_BC_TuAdenB.Checked = false;
            }
        }

        private void txt_BC_SL_KH_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_BC_SL_KH_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender, e);    
        }

        private void txt_BC_Thu_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_BC_Thu_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void txt_BC_Chi_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_BC_Chi_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedTab = tab_Page_ThanhToan;
        }

        private void tổngQuanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedTab = tab_Page_TongQuan ;
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedTab = tab_Page_HoaDon;
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedTab=tab_Page_BaoCao;
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedTab = tab_Page_KhachHang;
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedTab = tab_Page_NCC;
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedTab=tab_Page_NhapHang;
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedTab = tab_Page_HangHoa;
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab_LoanSpa.SelectedTab = tab_Page_DichVu;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_About_1 hs=new frm_About_1();
            hs.ShowDialog();
        }

        private void mn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //////////END-Class
    }
}
// MessageBox.Show("dan: ");
