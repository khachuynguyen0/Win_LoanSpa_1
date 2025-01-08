
//using NguyenKhacHuy_Week4_2280601183._3_DataBase_Layer.Modal_DB;
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
    public partial class frm_QuanLySV : Form
    {
        public frm_QuanLySV()
        {
            InitializeComponent();
        }
        //B-2
        //2.1 "3_DataBase_Layer"
        Part_0_1_PT_For_WF_Base_1 sp_WF =new Part_0_1_PT_For_WF_Base_1();

        //2.1 "2_Xuly_Layer"
        Manager_SinhVien_1 mn_SV_1 =new Manager_SinhVien_1();
        Manager_Khoa_1 mn_Khoa_WF=new Manager_Khoa_1();

        //2.3 DataTables
        DataTable dt_1_SV =new DataTable();




        //CTC
        //0. reset
        public void ResetAllTxt_SV() { 
            txt_MaSo.Text = "";
            txt_HoTen.Text = "";
            txt_DiemTB.Text = "";
            cb_TenCB.SelectedIndex = 0;
            chk_DK_CNganh.Checked = false;

            //Cn
            txt_MaSo.Focus();
        }

        //1. Load
        //1.0 Load color btn
        public void LoadColorForThemXoa()
        {
            btn_Them_SV.BackColor = Color.LightGreen;
            btn_Xoa_SV.BackColor = Color.Orange;
        }

        //1.1 Load SV
        public void LoadSinhVien_At_Design()
        {
            dt_1_SV = mn_SV_1.Get_DT_GetDataTable();
            dgv_SinhVien.DataSource = dt_1_SV;

        }

        //1.2 Load LoadTenKhoa
        public void LoadTenKhoa_At_Design() { 
            //tao dt chua
            DataTable dt_1_Khoa_Cb = new DataTable();
            //get data tui DB
            dt_1_Khoa_Cb=mn_Khoa_WF.Get_TenDT_GetDataTable();
            //add ND
            foreach (DataRow i in dt_1_Khoa_Cb.Rows) {
                //  cb_TenCB.Items.Add(i[1].ToString());
                cb_TenCB.Items.Add(i["tenKhoa"].ToString());
                
            }
            //Chon dau
            cb_TenCB.SelectedIndex = 0;
        }


        //4.2.2 In ND
        public void SendNDToTextBox_SV()
        {
            //BD

            if (//dgv_SinhVien.SelectedRows.Count > 0 ||
                dgv_SinhVien.SelectedCells.Count > 0)
            {
                //1.get rowindex
                //1.1 Lay theo V.Tri Cot
                int rowIndex = dgv_SinhVien.CurrentCell.RowIndex;
                txt_MaSo.Text = dt_1_SV.Rows[rowIndex]["maSV"].ToString();
                txt_HoTen.Text = dt_1_SV.Rows[rowIndex]["tenSV"].ToString();

                //1.2 Lay theo Ten Cot
                //dt_
                txt_DiemTB.Text = dt_1_SV.Rows[rowIndex]["diemTB"].ToString();
                cb_TenCB.Text = dt_1_SV.Rows[rowIndex]["tenKhoa"].ToString();
                //dgv_
                //txt_DiemTB.Text = dgv_SinhVien.CurrentRow.Cells["diemTB"].Value.ToString();
            }

            //end
        }


        //3. Them
        //3.1 them 1 SV
        public void Them1DoiTuong_SV_At_Design() {
            //1. KT dau vao
            // ko co data -> out
            if (txt_MaSo.Text == "" || txt_HoTen.Text == "" ||
                txt_DiemTB.Text == "" || cb_TenCB.Text == "") {
                MessageBox.Show("Vui lòng điền đủ thông tin ");
                return;
            }



            //2. them
            string maSV =txt_MaSo.Text;
            string tenSV=txt_HoTen.Text;
            float diemTB = Convert.ToSingle(txt_DiemTB.Text);
            string tenKhoa=cb_TenCB.Text;
            //MessageBox.Show(""+maSV+tenSV+diemTB+tenKhoa);
            mn_SV_1.Them1_DT(maSV, tenSV, diemTB, tenKhoa);
            //
            //Load dgv_
            ResetAllTxt_SV();
            LoadSinhVien_At_Design();
        }

        //4. Sua
        //4.1 Sua 1 SV
        public void Sua1DoiTuong_SV_At_Design()
        {
            //1. KT dau vao
            // ko co data -> out
            if (txt_MaSo.Text == "" || txt_HoTen.Text == "" ||
                txt_DiemTB.Text == "" || cb_TenCB.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin ");
                return;
            }



            //2. them
            string maSV = txt_MaSo.Text;
            string tenSV = txt_HoTen.Text;
            float diemTB = Convert.ToSingle(txt_DiemTB.Text);
            string tenKhoa = cb_TenCB.Text;
            //MessageBox.Show(""+maSV+tenSV+diemTB+tenKhoa);
            mn_SV_1.Sua1_DT(maSV, tenSV, diemTB, tenKhoa);
            //
            //Load dgv_
            ResetAllTxt_SV();
            LoadSinhVien_At_Design();
        }

        //4. Xoa
        //4.1 Xoa 1 SV
        public void Xoa1DoiTuong_SV_At_Design()
        {
            //1. KT dau vao
            // ko co data -> out
            if (txt_MaSo.Text == "" || txt_HoTen.Text == "" ||
                txt_DiemTB.Text == "" || cb_TenCB.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin ");
                return;
            }

            //2. them
            string maSV = txt_MaSo.Text;
           
            mn_SV_1.Xoa1_DT(maSV);
            //
            //Load dgv_
            ResetAllTxt_SV();
            LoadSinhVien_At_Design();
        }


        private void frm_No1_Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Part_0_1_PT_For_WF_Base_1 hs = new Part_0_1_PT_For_WF_Base_1();
            hs.NoticeWhenClosing(sender, e);

        }

        private void frm_QuanLySV_Load(object sender, EventArgs e)
        {
            //1. Load
            //1.1 Load SV
            LoadSinhVien_At_Design();
            //1.2 Load LoadTenKhoa
            LoadTenKhoa_At_Design();


            //1.2 Load btn_ Color
            //1.1 Load color btn
            LoadColorForThemXoa();



        }

        private void txt_TongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            sp_WF.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void txt_GiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            sp_WF.TextBoxOnlyText(sender, e);
        }

        private void txt_TongSauGiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            sp_WF.TextBoxOnlySoThuc(sender, e);
        }

        private void txt_MaSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            sp_WF.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void txt_HoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            sp_WF.TextBoxOnlyText(sender, e);
        }

        private void txt_Khoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            sp_WF.TextBoxOnlyText(sender, e);
        }

        private void txt_DiemTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_DiemTB.MaxLength = 3;
            sp_WF.TextBoxOnlySoThuc(sender, e);
        }

        private void dgv_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SendNDToTextBox_SV();
        }

        private void dgv_SinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendNDToTextBox_SV();
        }

        private void btn_Test1_Click(object sender, EventArgs e)
        {
            bool a1 = mn_SV_1.CoTonTaiMaDT_ID_Short("SV0019");
            if (a1 == true)
            {
                MessageBox.Show(a1.ToString());
            }
            else {
                MessageBox.Show(a1.ToString());
            }
        }

        private void btn_Test2_Click(object sender, EventArgs e)
        {


        }

        private void btn_Them_SV_Click(object sender, EventArgs e)
        {
            //Them 1 SV
            Them1DoiTuong_SV_At_Design();
        }

        private void btn_Sua_SV_Click(object sender, EventArgs e)
        {
            Sua1DoiTuong_SV_At_Design();
        }

        private void btn_Xoa_SV_Click(object sender, EventArgs e)
        {
            Xoa1DoiTuong_SV_At_Design();
        }

        private void chk_DK_CNganh_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_DK_CNganh.Checked == false)
            {
                dt_1_SV.Rows.Clear();
                dt_1_SV = mn_SV_1.Get_DT_GetDataTable();
                dgv_SinhVien.DataSource = dt_1_SV;
                return;
            }
            else
            {
                dt_1_SV.Rows.Clear();
                dt_1_SV = mn_SV_1.Get_DT_Null_CNganh_GetDataTable();
                dgv_SinhVien.DataSource = dt_1_SV;
                return;
            }
            // MessageBox.Show("s");
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
