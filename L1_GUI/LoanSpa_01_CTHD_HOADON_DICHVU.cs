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
    public partial class frm_CTHD_HOADON_DICHVU : Form
    {


        private int maHD;
        //B-2
        //2.1 "3_DataBase_Layer"
        Part_0_1_PT_For_WF_Base_1 sp_WF = new Part_0_1_PT_For_WF_Base_1();

       
        //2.1 "3_DataBase_Layer"
        Manager_DataBase_1 db = new Manager_DataBase_1();
        Manager_CTHD_HOADON_DICHVU_1 mn_CTHD_HOADON_DICHVU_1;
        Part_0_1_PT_For_WF_Base_1 part_WF_1 = new Part_0_1_PT_For_WF_Base_1();

        //2.3 DataTables
        DataTable dt_1= new DataTable();



        //K-3
        public frm_CTHD_HOADON_DICHVU()
        {
            InitializeComponent();
        }

        public frm_CTHD_HOADON_DICHVU(int maHD)
        {
            //this.maHD = maHD;
            //InitializeComponent();

            InitializeComponent();
            this.maHD = maHD;

            // Truyền maHD cho Manager_CTHD_HOADON_DICHVU_1
            mn_CTHD_HOADON_DICHVU_1 = new Manager_CTHD_HOADON_DICHVU_1(maHD);


        }


        //CTC
        //1. Load
        public void Load_CTHD_HOADON_DICHVU_At_Design()
        {
            //-> da dc kiemtra
            //1. get data
            dt_1 = mn_CTHD_HOADON_DICHVU_1.Get_DT_GetDataTable();

            dgv_CTHD_HOADON_DICHVU.DataSource=dt_1;

        }

        //1.1 Load img
        public void Load_Imgs() {
            pic_Detail_1.Image = new Bitmap(Application.StartupPath+ "\\P1_C_Sharp_png\\QLSpa\\detail_1.png");
        }
        //1.2 Load color btn
        public void Load_Color_Btn() {
            btn_Xoa.BackColor = Color.OrangeRed;
            btn_XoaAll.BackColor = Color.Violet;
        }





        //2. Find
        //2.1 Hoa Don
        public void SendDataRowToCommand_CTHD_HD_DV()
        {
            //DK do
            //0. get VT
            //DK do
            //if (dgv_CTHD_HOADON_DICHVU.Rows.Count > 0) { 

            //}
            if (dgv_CTHD_HOADON_DICHVU.Rows.Count > 0)
            {
                int rowIndex = dgv_CTHD_HOADON_DICHVU.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon

                //6. 
                string tenDV = Convert.ToString(dgv_CTHD_HOADON_DICHVU.Rows[rowIndex].Cells["tenDV"].Value);
                txt_TenDV.Text = tenDV;

                //2. 
                decimal soLuong = Convert.ToDecimal(dgv_CTHD_HOADON_DICHVU.Rows[rowIndex].Cells["soLuong"].Value);
                txt_SoLuong.Text = soLuong.ToString("N0");

                //3. 
                decimal donGia = Convert.ToDecimal(dgv_CTHD_HOADON_DICHVU.Rows[rowIndex].Cells["donGia"].Value);
                txt_DonGia.Text = donGia.ToString("N0");

                //4. 
                decimal tongTien = Convert.ToDecimal(dgv_CTHD_HOADON_DICHVU.Rows[rowIndex].Cells["tongTien"].Value);
                txt_TongTien.Text = tongTien.ToString("N0");
            }



        }

        public void SendDataRowToCommand_CTHD_HD_DV_Have_VT(int rowIndex)
        {
            //DK do
            //0. get VT
            //DK do
            //if (dgv_CTHD_HOADON_DICHVU.Rows.Count > 0) { 

            //}
            if (dgv_CTHD_HOADON_DICHVU.Rows.Count > 0)
            {
                //int rowIndex = dgv_CTHD_HOADON_DICHVU.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon

                //6. 
                string tenDV = Convert.ToString(dgv_CTHD_HOADON_DICHVU.Rows[rowIndex].Cells["tenDV"].Value);
                txt_TenDV.Text = tenDV;

                //2. 
                decimal soLuong = Convert.ToDecimal(dgv_CTHD_HOADON_DICHVU.Rows[rowIndex].Cells["soLuong"].Value);
                txt_SoLuong.Text = soLuong.ToString("N0");

                //3. 
                decimal donGia = Convert.ToDecimal(dgv_CTHD_HOADON_DICHVU.Rows[rowIndex].Cells["donGia"].Value);
                txt_DonGia.Text = donGia.ToString("N0");

                //4. 
                decimal tongTien = Convert.ToDecimal(dgv_CTHD_HOADON_DICHVU.Rows[rowIndex].Cells["tongTien"].Value);
                txt_TongTien.Text = tongTien.ToString("N0");
            }
        }








        //2.2 ChooseFirstValue_And_SendDataRowToCommand_CTHD_HD_DV
        public void ChooseFirstValue_And_SendDataRowToCommand_CTHD_HD_DV() {
            //dk Do
            if (dgv_CTHD_HOADON_DICHVU.Rows.Count > 0) {
                dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
                SendDataRowToCommand_CTHD_HD_DV_Have_VT(0);
            }

        }

        //2.3 KT txt_ Rong
        //2.3.1
        public bool Have_Txt_Is_Empty_At_CTHD_HD_DV() {
            //kt
            if (txt_TenDV.Text == "" || txt_SoLuong.Text == "" ||
                txt_DonGia.Text == "" || txt_TongTien.Text == "") 
            {
                return true;
            }
            return false;
        }


        public bool Have_Txt_Is_Empty_At_Tab_THANHTOAN() { 
        
            //
            return false;
        }

        //3. Do
        //3.1 Sua
        public void Sua1_DT_At_Design() {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_CTHD_HOADON_DICHVU.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_CTHD_HOADON_DICHVU.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                decimal soLuong = Convert.ToDecimal(txt_SoLuong.Text);
                decimal donGia = Convert.ToDecimal(txt_DonGia.Text);
                int maHD = Convert.ToInt32(dgv_CTHD_HOADON_DICHVU.Rows[nowIndex].Cells["maHD"].Value);
                int maDV = Convert.ToInt32(dgv_CTHD_HOADON_DICHVU.Rows[nowIndex].Cells["maDV"].Value);

                //KT
                //MessageBox.Show(" | "+soLuong  +"\n"+
                //    " | " + donGia + "\n" +
                //    " | " + maHD + "\n" +
                //    " | " + maHD //+ "\n" +
                //    );
                //3.GoiHam
                if (mn_CTHD_HOADON_DICHVU_1.Sua1_DT(maHD, maDV, soLuong, donGia) == false)
                {
                    MessageBox.Show("Sửa: Thất Bại!!!");
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa: Thành công!!!");
                    Load_CTHD_HOADON_DICHVU_At_Design();
                    ChooseFirstValue_And_SendDataRowToCommand_CTHD_HD_DV();
                    return;
                }

                //C.Nhat
            }
            else {
                MessageBox.Show("Vui Long Chon Doi Tuong!!!" +"\n" +
                    "====================" + "\n" +
                    "Click vào đầu dòng!!!" //+ "\n" +
                    );
            }

            //end
        }

        //3.2 Xóa
        public void Xoa1_DT_At_Design() {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_CTHD_HOADON_DICHVU.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_CTHD_HOADON_DICHVU.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                int maHD = Convert.ToInt32(dgv_CTHD_HOADON_DICHVU.Rows[nowIndex].Cells["maHD"].Value);
                int maDV = Convert.ToInt32(dgv_CTHD_HOADON_DICHVU.Rows[nowIndex].Cells["maDV"].Value);

                //KT
                //MessageBox.Show(" | "+soLuong  +"\n"+
                //    " | " + donGia + "\n" +
                //    " | " + maHD + "\n" +
                //    " | " + maHD //+ "\n" +
                //    );
                //3.GoiHam
                if (mn_CTHD_HOADON_DICHVU_1.Xoa1_DT(maHD, maDV) == false)
                {
                    MessageBox.Show("Xóa: Thất Bại!!!");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa: Thành công!!!");
                    Load_CTHD_HOADON_DICHVU_At_Design();
                    ChooseFirstValue_And_SendDataRowToCommand_CTHD_HD_DV();
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

        //3.3 Xóa All
        public void XoaN_DT_TheoMaHD_At_Design() {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_CTHD_HOADON_DICHVU.Rows.Count > 0)
            {
                //1. vt
                //int nowIndex = dgv_CTHD_HOADON_DICHVU.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                //Vi all giong nhau-> lay 1 la du
                //int maHD = Convert.ToInt32(dt_1.Rows[0]["maHD"].ToString());
                

                //KT
                //MessageBox.Show(" | "+soLuong  +"\n"+
                //    " | " + donGia + "\n" +
                //    " | " + maHD + "\n" +
                //    " | " + maHD //+ "\n" +
                //    );
                //3.GoiHam
                if (mn_CTHD_HOADON_DICHVU_1.XoaN_DT_TheoMaHD() == false)
                {
                    MessageBox.Show("Xóa: Thất Bại!!!");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa: Thành công!!!");
                    Load_CTHD_HOADON_DICHVU_At_Design();
                    //SendDataRowToCommand_CTHD_HD_DV();
                    return;
                }

                //C.Nhat
            }

            //end

        }












        ////////////////////////////////////
        private void frm_No2_Nomal_size_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Part_0_1_PT_For_WF_Base_1 hs = new Part_0_1_PT_For_WF_Base_1();
            //hs.NoticeWhenClosing(sender, e);

        }






        //4.2.n .. Test LK
        public void m1()
        {
            DB_Mau hs = new DB_Mau();
            Manager_DataBase_1 db0 = new Manager_DataBase_1();
            Part_0_2_PT_For_DataBase_1 db1 = new Part_0_2_PT_For_DataBase_1();
            Manager_HoaDon_1 db2 = new Manager_HoaDon_1();
            

        }

        private void btn_Test1_Click(object sender, EventArgs e)
        {
            if (dt_1.Rows.Count > 0) {
                MessageBox.Show("dan: " + dt_1.Rows[0]["maHD"].ToString());
            }
            //dgv_CTHD_HOADON_DICHVU.Rows[2].Selected = true;
            //SendDataRowToCommand_CTHD_HD_DV_Have_VT(2);
        }

        private void btn_Test3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ChiTiet_HDon_Click(object sender, EventArgs e)
        {

        }

        private void frm_CTHD_HOADON_DICHVU_Load(object sender, EventArgs e)
        {
            //1. Load
            //1.1 load dgv_ theo maHD
            Load_CTHD_HOADON_DICHVU_At_Design();

            //1.2 load imgs
            Load_Imgs();

            //1.3 load btn
            Load_Color_Btn();

            
            //CN
            ChooseFirstValue_And_SendDataRowToCommand_CTHD_HD_DV();
            //textBox1.Text = 10000000.ToString();
        }

        private void dgv_CTHD_HOADON_DICHVU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendDataRowToCommand_CTHD_HD_DV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Sua1_DT_At_Design();

        }

        private void txt_TenDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_WF_1.TextBoxOnlyText(sender,e);
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_WF_1.TextBoxOnlyNumberMaDT(sender,e);
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_WF_1.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void txt_TongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_WF_1.TextBoxOnlyNumberMaDT(sender, e);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //BD
            Xoa1_DT_At_Design();

            //end
        }

        private void txt_DonGia_TextChanged(object sender, EventArgs e)
        {
            Part_0_1_PT_For_WF_Base_1 hs = new Part_0_1_PT_For_WF_Base_1();
            hs.TextBoxOnlyMoney(sender, e);
        }

        private void txt_TongTien_TextChanged(object sender, EventArgs e)
        {
            part_WF_1.TextBoxOnlyMoney(sender, e);
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            part_WF_1.TextBoxOnlyMoney(sender, e);
        }

        private void btn_XoaAll_Click(object sender, EventArgs e)
        {
            XoaN_DT_TheoMaHD_At_Design();
        }


        //////////END-Class
    }
}
