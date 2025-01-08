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
    public partial class frm_DangKyCNganh : Form
    {
        public frm_DangKyCNganh()
        {
            InitializeComponent();
        }
        //B-2
        //2.1 "3_DataBase_Layer"
        Part_0_1_PT_For_WF_Base_1 sp_WF = new Part_0_1_PT_For_WF_Base_1();

        //2.1 "2_Xuly_Layer"
        Manager_SinhVien_1 mn_SV_1 = new Manager_SinhVien_1();
        Manager_ChuyenNganh_1 mn_CN_1 = new Manager_ChuyenNganh_1();
        Manager_Khoa_1 mn_Khoa_1 = new Manager_Khoa_1();

        //2.3 DataTables
        DataTable dt_1_SV = new DataTable();
        



        //1.-n Load color btn
        public void LoadColorForThemXoa() { 
            //btn_Them_HDon.BackColor=Color.LightGreen;
            //btn_Xoa_HDon.BackColor = Color.Orange;
            
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

        //1.1 Load SV
        public void LoadSinhVienNullCNganh_At_Design()
        {
            dt_1_SV = mn_SV_1.Get_DT_Null_CNganh_GetDataTable();
            dgv_SV_chuaDK.DataSource = dt_1_SV;
        }

        //1.2 Load LoadTenKhoa
        public void LoadTenKhoa_At_Design()
        {
            //tao dt chua
            DataTable dt_1_Khoa_Cb = new DataTable();
            //get data tui DB
            dt_1_Khoa_Cb = mn_Khoa_1.Get_TenDT_GetDataTable();
            //add ND
            foreach (DataRow i in dt_1_Khoa_Cb.Rows)
            {
                //  cb_TenCB.Items.Add(i[1].ToString());
                cb_TenKhoa.Items.Add(i["tenKhoa"].ToString());

            }
            //Chon dau
            cb_TenKhoa.SelectedIndex = 0;
        }

        //1.2 Load LoadTenCNganh




        //1.2 Load LoadTenCNganh theo Khoa
        public void Load_TenCNganh_Theo_TenKhoa_GetDataTable_At_Design()
        {
            //1. DK do
            if (cb_TenKhoa.Text != "")
            {
                //BD
                DataTable dt_1 = new DataTable();
                string tenCN = cb_TenKhoa.Text;
                dt_1 = mn_CN_1.Get_TenDT_Theo_Orther_TenDT_GetDataTable(tenCN);
                //0. KT empty
                if (dt_1.Rows.Count == 0)
                {
                    //T.bao
                    MessageBox.Show("Khoa Không có chuyên ngành!!! ");
                    //don dep cb_
                    cb_TenCNganh.Items.Clear();
                    cb_TenCNganh.Text = "";
                    return;
                }

                //1. Clear cb_ truoc khi load :))
                cb_TenCNganh.Items.Clear();
                foreach (DataRow i in dt_1.Rows)
                {
                    //MessageBox.Show("i= "+ i["tenCNganh"].ToString());
                    cb_TenCNganh.Items.Add(i["tenCNganh"].ToString());
                }
                //CN ND
                cb_TenCNganh.SelectedIndex = 0;
                //END
            }
            //MessageBox.Show("s");
        }

        //1.2 Dang ky chuyen nganh choSV
        public void DK_CNganh_For_SV() {
            //BD
            //1 get tenCN
            string tenDT = cb_TenCNganh.Text;

            //get maSV 
            int now_Index = dgv_SV_chuaDK.CurrentCell.RowIndex;
            string maDT = dt_1_SV.Rows[now_Index]["maSV"].ToString();
            //MessageBox.Show("Dan: "+tenDT);
            //MessageBox.Show("Dan: "+maDT);

            mn_SV_1.Add_maDT_For1_DT_Theo_Orther_TenDT(maDT, tenDT);

            //CN
            LoadSinhVienNullCNganh_At_Design();
            //END

        }
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

            //txt_DiemDT.MaxLength = 3;//vd 8.5
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

            //1.2 load cb_Khoa cb_CN
            LoadTenKhoa_At_Design();
            //LoadTenCNganh_At_Design();
            //


            //1.3 sv chua dk
            LoadSinhVienNullCNganh_At_Design();

        }

        private void cb_TenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            Load_TenCNganh_Theo_TenKhoa_GetDataTable_At_Design();


        }

        private void btn_Test1_Click(object sender, EventArgs e)
        {
            string tenCN=cb_TenCNganh.Text;
            int maCN = mn_CN_1.Get_maID_Theo_Name_GetInt(tenCN);
            MessageBox.Show("D.an: "+tenCN+" | "+maCN);
        }

        private void btn_Test2_Click(object sender, EventArgs e)
        {
            //BD
            //1 get tenCN
            string tenDT=cb_TenCNganh.Text;

            //get maSV 
            int now_Index=dgv_SV_chuaDK.CurrentCell.RowIndex;
            string maDT = dt_1_SV.Rows[now_Index]["maSV"].ToString();
            //MessageBox.Show("Dan: "+tenDT);
            //MessageBox.Show("Dan: "+maDT);

            mn_SV_1.Add_maDT_For1_DT_Theo_Orther_TenDT(maDT, tenDT);

            //CN
            LoadSinhVienNullCNganh_At_Design();
            //END
        }

        private void btn_DangKyCNganh_Click(object sender, EventArgs e)
        {
            DK_CNganh_For_SV();
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
// MessageBox.Show("Dan: "+tenDT);
