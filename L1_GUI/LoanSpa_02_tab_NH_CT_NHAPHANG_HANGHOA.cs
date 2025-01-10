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
    public partial class frm_LoanSpa_02_tab_NH_CT_NHAPHANG_HANGHOA : Form
    {

        //B-2
        //2.1 "3_DataBase_Layer"
        Part_0_1_PT_For_WF_Base_1 part_0 = new Part_0_1_PT_For_WF_Base_1();

        int maNH;

        //2.1 "2_Xuly_Layer"
        //Manager_SinhVien_1 mn_SV_1 = new Manager_SinhVien_1();
        //Manager_Khoa_1 mn_Khoa_WF = new Manager_Khoa_1();
        Manager_CT_NHAPHANG_HANGHOA_1 mn_CT_NHAPHANG_HANGHOA_1;


        //2.3 DataTables
        DataTable dt_1_CT_NH_HH = new DataTable();




        public frm_LoanSpa_02_tab_NH_CT_NHAPHANG_HANGHOA()
        {
            InitializeComponent();
        }

        public frm_LoanSpa_02_tab_NH_CT_NHAPHANG_HANGHOA(int maNH)
        {
            this.maNH = maNH;
            mn_CT_NHAPHANG_HANGHOA_1=new Manager_CT_NHAPHANG_HANGHOA_1(maNH);
            InitializeComponent();
        }




        //Load
        //1.-n Load color btn
        public void LoadColorForThemXoa() { 
           // btn_Them_HDon.BackColor=Color.LightGreen;
            btn_Xoa_CT_NH_HH.BackColor = Color.OrangeRed;
            btn_XoaAll_CT_NH_HH.BackColor = Color.Violet;
        }

        //CTC
        //1.1 Load
        public void Load_CT_NH_HH_At_Design()
        {
            //-> da dc kiemtra
            //1. get data
           dt_1_CT_NH_HH = mn_CT_NHAPHANG_HANGHOA_1.Get_DT_GetDataTable();

            dgv_CT_NH_HH.DataSource = dt_1_CT_NH_HH;

            ChooseFirstValue_And_SendDataRowToCommand_CT_NH_HH();

        }


        //1.1 Load img
        public void Load_Imgs()
        {
            pic_CT_NH_HH_AnhNH.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\CT_NhapHang_1.png");
        }
        //1.2 Load color btn







        //2. Find
        //2.1 Hoa Don
        public void SendDataRowToCommand_CT_NH_HH()
        {
            //DK do
            //0. get VT
            //DK do
            //if (dgv_CTHD_HOADON_DICHVU.Rows.Count > 0) { 

            //}
            if (dgv_CT_NH_HH.Rows.Count > 0)
            {
                int rowIndex = dgv_CT_NH_HH.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon

                //6. 
                string tenDT = Convert.ToString(dgv_CT_NH_HH.Rows[rowIndex].Cells["tenHH"].Value);
                txt_CT_NH_HH_TenHH.Text = tenDT;

                //2. 
                decimal soLuong = Convert.ToDecimal(dgv_CT_NH_HH.Rows[rowIndex].Cells["soLuong"].Value);
                txt_CT_NH_HH_SoLuong.Text = soLuong.ToString("N0");

                //3. 
                decimal donGia = Convert.ToDecimal(dgv_CT_NH_HH.Rows[rowIndex].Cells["donGia"].Value);
                txt_CT_NH_HH_DonGia.Text = donGia.ToString("N0");

                //4. 
                decimal tongTien = Convert.ToDecimal(dgv_CT_NH_HH.Rows[rowIndex].Cells["tongTien"].Value);
                txt_CT_NH_HH_TongTien.Text = tongTien.ToString("N0");
            }



        }

        public void SendDataRowToCommand_CT_NH_HH(int rowIndex)
        {
            //DK do
            //0. get VT
            //DK do
            //if (dgv_CTHD_HOADON_DICHVU.Rows.Count > 0) { 

            //}
            if (dgv_CT_NH_HH.Rows.Count > 0)
            {
               // int rowIndex = dgv_CT_NH_HH.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon

                //6. 
                string tenDT = Convert.ToString(dgv_CT_NH_HH.Rows[rowIndex].Cells["tenHH"].Value);
                txt_CT_NH_HH_TenHH.Text = tenDT;

                //2. 
                decimal soLuong = Convert.ToDecimal(dgv_CT_NH_HH.Rows[rowIndex].Cells["soLuong"].Value);
                txt_CT_NH_HH_SoLuong.Text = soLuong.ToString("N0");

                //3. 
                decimal donGia = Convert.ToDecimal(dgv_CT_NH_HH.Rows[rowIndex].Cells["donGia"].Value);
                txt_CT_NH_HH_DonGia.Text = donGia.ToString("N0");

                //4. 
                decimal tongTien = Convert.ToDecimal(dgv_CT_NH_HH.Rows[rowIndex].Cells["tongTien"].Value);
                txt_CT_NH_HH_TongTien.Text = tongTien.ToString("N0");
            }



        }






        //2.2 ChooseFirstValue_And_SendDataRowToCommand_CTHD_HD_DV
        public void ChooseFirstValue_And_SendDataRowToCommand_CT_NH_HH()
        {
            //dk Do
            if (dgv_CT_NH_HH.Rows.Count > 0)
            {
                dgv_CT_NH_HH.Rows[0].Selected = true;
                SendDataRowToCommand_CT_NH_HH(0);
            }

        }




        //3. Do
        //3.1 Sua
        public void Sua1_DT_At_Design()
        {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_CT_NH_HH.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_CT_NH_HH.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                decimal soLuong = Convert.ToDecimal(txt_CT_NH_HH_SoLuong.Text);
                decimal donGia = Convert.ToDecimal(txt_CT_NH_HH_DonGia.Text);
                int maNH = Convert.ToInt32(dgv_CT_NH_HH.Rows[nowIndex].Cells["maNH"].Value);
                int maHH = Convert.ToInt32(dgv_CT_NH_HH.Rows[nowIndex].Cells["maHH"].Value);

                //KT
                //MessageBox.Show(" | "+soLuong  +"\n"+
                //    " | " + donGia + "\n" +
                //    " | " + maHD + "\n" +
                //    " | " + maHD //+ "\n" +
                //    );
                //3.GoiHam
                if (mn_CT_NHAPHANG_HANGHOA_1.Sua1_DT(maNH, maHH, soLuong, donGia) == false)
                {
                    MessageBox.Show("Sửa: Thất Bại!!!");
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa: Thành công!!!");
                    Load_CT_NH_HH_At_Design();
                    ChooseFirstValue_And_SendDataRowToCommand_CT_NH_HH();
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

        //3.2 Xóa
        public void Xoa1_DT_At_Design()
        {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_CT_NH_HH.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_CT_NH_HH.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                int maNH = Convert.ToInt32(dgv_CT_NH_HH.Rows[nowIndex].Cells["maNH"].Value);
                int maHH = Convert.ToInt32(dgv_CT_NH_HH.Rows[nowIndex].Cells["maHH"].Value);

                //KT
                //MessageBox.Show(" | "+soLuong  +"\n"+
                //    " | " + donGia + "\n" +
                //    " | " + maHD + "\n" +
                //    " | " + maHD //+ "\n" +
                //    );
                //3.GoiHam
                if (mn_CT_NHAPHANG_HANGHOA_1.Xoa1_DT(maNH, maHH) == false)
                {
                    MessageBox.Show("Xóa: Thất Bại!!!");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa: Thành công!!!");
                    Load_CT_NH_HH_At_Design();
                    ChooseFirstValue_And_SendDataRowToCommand_CT_NH_HH();
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
        public void XoaN_DT_TheoMaHD_At_Design()
        {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_CT_NH_HH.Rows.Count > 0)
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
                if (mn_CT_NHAPHANG_HANGHOA_1.XoaN_DT_TheoMaHD() == false)
                {
                    MessageBox.Show("Xóa: Thất Bại!!!");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa: Thành công!!!");
                    Load_CT_NH_HH_At_Design();
                    //SendDataRowToCommand_CTHD_HD_DV();
                    return;
                }

                //C.Nhat
            }

            //end

        }













        private void frm_No1_Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Part_0_1_PT_For_WF_Base_1 hs = new Part_0_1_PT_For_WF_Base_1();
            hs.NoticeWhenClosing(sender, e);

        }


        private void frm_No4_dgv_txt_btn_Load(object sender, EventArgs e)
        {
            //1.1 Load color btn
            LoadColorForThemXoa();

            //1.2 load imgs
            Load_Imgs();

            //load dgv
            Load_CT_NH_HH_At_Design();

        }






        //4.2.n .. Test LK
        public void m1()
        {
            DB_Mau hs = new DB_Mau();
            Manager_DataBase_1 db0 = new Manager_DataBase_1();
            Part_0_2_PT_For_DataBase_1 db1 = new Part_0_2_PT_For_DataBase_1();
            Manager_HoaDon_1 db2 = new Manager_HoaDon_1();

        }

        private void lab_Button_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CT_NH_HH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendDataRowToCommand_CT_NH_HH();
        }

        private void txt_CT_NH_HH_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            part_0.TextBoxOnlyNumberMaDT(sender,e);
        }

        private void txt_CT_NH_HH_SoLuong_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_CT_NH_HH_TongTien_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender, e);
        }

        private void txt_CT_NH_HH_DonGia_TextChanged(object sender, EventArgs e)
        {
            part_0.TextBoxOnlyMoney(sender, e);
        }

        private void btn_Sua_CT_NH_HH_Click(object sender, EventArgs e)
        {
            Sua1_DT_At_Design();
        }

        private void btn_Xoa_CT_NH_HH_Click(object sender, EventArgs e)
        {
            Xoa1_DT_At_Design();
        }

        private void btn_XoaAll_CT_NH_HH_Click(object sender, EventArgs e)
        {
            XoaN_DT_TheoMaHD_At_Design();
        }

        //////////END-Class
    }
}
