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
    public partial class frm_QuanLyKhoa : Form
    {
        public frm_QuanLyKhoa()
        {
            InitializeComponent();
        }
        //B-2
        //2.1 "3_DataBase_Layer"
        Part_0_1_PT_For_WF_Base_1 sp_WF = new Part_0_1_PT_For_WF_Base_1();

        //2.1 "3_DataBase_Layer"
        Manager_Khoa_1 mn_K_1 = new Manager_Khoa_1();

        //2.3 DataTables
        DataTable dt_1_Khoa = new DataTable();




        //CTC
        //1. Load
        public void LoadKhoa_At_Design()
        {
            dt_1_Khoa = mn_K_1.Get_DT_GetDataTable();
            dgv_Khoa.DataSource = dt_1_Khoa;
        }
        //1.1 Load color btn
        public void LoadColorForThemXoa() { 
            btn_Them_K.BackColor=Color.LightGreen;
            btn_Xoa_K.BackColor = Color.Orange;
        }

        //1.2 Load 

        //4.2.2 In ND
        public void SendNDToTextBox_Khoa()
        {
            //BD

            if (//dgv_SinhVien.SelectedRows.Count > 0 ||
                dgv_Khoa.SelectedCells.Count > 0)
            {
                //1.get rowindex
                //1.1 Lay theo V.Tri Cot
                int rowIndex = dgv_Khoa.CurrentCell.RowIndex;
                txt_MaKhoa.Text = dt_1_Khoa.Rows[rowIndex][1].ToString();
                txt_TenKhoa.Text = dt_1_Khoa.Rows[rowIndex][2].ToString();
                txt_SLGiaoSu.Text = dt_1_Khoa.Rows[rowIndex][3].ToString();

            }

            //end
        }

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

            //1.2 
            LoadKhoa_At_Design();

        }

        private void dgv_Khoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendNDToTextBox_Khoa();
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
