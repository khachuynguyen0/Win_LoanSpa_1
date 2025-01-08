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
    public partial class frm_No5_dgv_txt_btn_mn_ts : Form
    {
        public frm_No5_dgv_txt_btn_mn_ts()
        {
            InitializeComponent();
        }
        //B-2
        //2.1 "3_DataBase_Layer"
        Part_0_1_PT_For_WF_Base_1 sp_WF = new Part_0_1_PT_For_WF_Base_1();

        //2.1 "2_Xuly_Layer"
        //Manager_SinhVien_1 mn_SV_1 = new Manager_SinhVien_1();
        //Manager_Khoa_1 mn_Khoa_WF = new Manager_Khoa_1();

        //2.3 DataTables
        //DataTable dt_1_SV = new DataTable();




        //1.-n Load color btn
        public void LoadColorForThemXoa() { 
            btn_Them_HDon.BackColor=Color.LightGreen;
            btn_Xoa_HDon.BackColor = Color.Orange;
        }


        //CTC-4.2
        //0. reset
        //public void ResetAllTxt_SV()
        //{
        //    txt_MaSo.Text = "";
        //    txt_HoTen.Text = "";
        //    txt_DiemTB.Text = "";
        //    cb_TenCB.SelectedIndex = 0;

        //    //Cn
        //    txt_MaSo.Focus();
        //}

        ////1. Load
        ////1.0 Load color btn
        //public void LoadColorForThemXoa()
        //{
        //    btn_Them_SV.BackColor = Color.LightGreen;
        //    btn_Xoa_SV.BackColor = Color.Orange;
        //}

        ////1.1 Load SV
        //public void LoadSinhVien_At_Design()
        //{
        //    dt_1_SV = mn_SV_1.LoadSinhVien();
        //    dgv_SinhVien.DataSource = dt_1_SV;
        //}

        ////1.2 Load LoadTenKhoa
        //public void LoadTenKhoa_At_Design()
        //{
        //    //tao dt chua
        //    DataTable dt_1_Khoa_Cb = new DataTable();
        //    //get data tui DB
        //    dt_1_Khoa_Cb = mn_Khoa_WF.LoadTenKhoa();
        //    //add ND
        //    foreach (DataRow i in dt_1_Khoa_Cb.Rows)
        //    {
        //        //  cb_TenCB.Items.Add(i[1].ToString());
        //        cb_TenCB.Items.Add(i["tenKhoa"].ToString());

        //    }
        //    //Chon dau
        //    cb_TenCB.SelectedIndex = 0;
        //}


        ////4.2.2 In ND
        //public void SendNDToTextBox_SV()
        //{
        //    //BD

        //    if (//dgv_SinhVien.SelectedRows.Count > 0 ||
        //        dgv_SinhVien.SelectedCells.Count > 0)
        //    {
        //        //1.get rowindex
        //        //1.1 Lay theo V.Tri Cot
        //        int rowIndex = dgv_SinhVien.CurrentCell.RowIndex;
        //        txt_MaSo.Text = dt_1_SV.Rows[rowIndex][1].ToString();
        //        txt_HoTen.Text = dt_1_SV.Rows[rowIndex][2].ToString();

        //        //1.2 Lay theo Ten Cot
        //        //dt_
        //        txt_DiemTB.Text = dt_1_SV.Rows[rowIndex][3].ToString();
        //        cb_TenCB.Text = dt_1_SV.Rows[rowIndex][4].ToString();
        //        //dgv_
        //        //txt_DiemTB.Text = dgv_SinhVien.CurrentRow.Cells["diemTB"].Value.ToString();
        //    }

        //    //end
        //}


        ////3. Them
        ////3.1 them 1 SV
        //public void Them1DoiTuong_SV_At_Design()
        //{
        //    //1. KT dau vao
        //    // ko co data -> out
        //    if (txt_MaSo.Text == "" || txt_HoTen.Text == "" ||
        //        txt_DiemTB.Text == "" || cb_TenCB.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng điền đủ thông tin ");
        //        return;
        //    }



        //    //2. them
        //    string maSV = txt_MaSo.Text;
        //    string tenSV = txt_HoTen.Text;
        //    float diemTB = Convert.ToSingle(txt_DiemTB.Text);
        //    string tenKhoa = cb_TenCB.Text;
        //    //MessageBox.Show(""+maSV+tenSV+diemTB+tenKhoa);
        //    mn_SV_1.Them1DoiTuong(maSV, tenSV, diemTB, tenKhoa);
        //    //
        //    //Load dgv_
        //    ResetAllTxt_SV();
        //    LoadSinhVien_At_Design();
        //}

        ////4. Sua
        ////4.1 Sua 1 SV
        //public void Sua1DoiTuong_SV_At_Design()
        //{
        //    //1. KT dau vao
        //    // ko co data -> out
        //    if (txt_MaSo.Text == "" || txt_HoTen.Text == "" ||
        //        txt_DiemTB.Text == "" || cb_TenCB.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng điền đủ thông tin ");
        //        return;
        //    }



        //    //2. them
        //    string maSV = txt_MaSo.Text;
        //    string tenSV = txt_HoTen.Text;
        //    float diemTB = Convert.ToSingle(txt_DiemTB.Text);
        //    string tenKhoa = cb_TenCB.Text;
        //    //MessageBox.Show(""+maSV+tenSV+diemTB+tenKhoa);
        //    mn_SV_1.Sua1DoiTuong(maSV, tenSV, diemTB, tenKhoa);
        //    //
        //    //Load dgv_
        //    ResetAllTxt_SV();
        //    LoadSinhVien_At_Design();
        //}

        ////4. Xoa
        ////4.1 Xoa 1 SV
        //public void Xoa1DoiTuong_SV_At_Design()
        //{
        //    //1. KT dau vao
        //    // ko co data -> out
        //    if (txt_MaSo.Text == "" || txt_HoTen.Text == "" ||
        //        txt_DiemTB.Text == "" || cb_TenCB.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng điền đủ thông tin ");
        //        return;
        //    }

        //    //2. them
        //    string maSV = txt_MaSo.Text;

        //    mn_SV_1.Xoa1DoiTuong(maSV);
        //    //
        //    //Load dgv_
        //    ResetAllTxt_SV();
        //    LoadSinhVien_At_Design();
        //}



        private void frm_No1_Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Part_0_1_PT_For_WF_Base_1 hs = new Part_0_1_PT_For_WF_Base_1();
            hs.NoticeWhenClosing(sender, e);

        }

        private void txt_GiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_TongSauGiam_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_MaDT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_TenDT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_DiemDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //BD

            txt_DiemDT.MaxLength = 3;//vd 8.5
            //3. Chi Cho Nhap So: So Thuc(VD: Diem TB)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                //MessageBox.Show("Vui lòng Nhập: Số");
            }

            //END
        }

        private void frm_No4_dgv_txt_btn_Load(object sender, EventArgs e)
        {
            //1.1 Load color btn
            LoadColorForThemXoa();

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
