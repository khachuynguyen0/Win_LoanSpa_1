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
    public partial class frm_LoanSpa_03_tab_DV_CTSD_DICHVU_HANGHOA : Form
    {

        //B-2
        //2.1 "3_DataBase_Layer"
        
        Part_0_1_PT_For_WF_Base_1 part0 = new Part_0_1_PT_For_WF_Base_1();
        //2.1 "2_Xuly_Layer"
        //Manager_SinhVien_1 mn_SV_1 = new Manager_SinhVien_1();
        //Manager_Khoa_1 mn_Khoa_WF = new Manager_Khoa_1();
        Manager_CTSD_DICHVU_HANGHOA_1 mn_CT_DV_HH;
        Manager_tab_HangHoa_1 mn_HangHoa_1=new Manager_tab_HangHoa_1();


        //2.3 DataTables
        //DataTable dt_1_SV = new DataTable();
        DataTable dt_1= new DataTable();


        //Bien
        int maDT;







        public frm_LoanSpa_03_tab_DV_CTSD_DICHVU_HANGHOA()
        {
            maDT = 0;
            InitializeComponent();
        }



        public frm_LoanSpa_03_tab_DV_CTSD_DICHVU_HANGHOA(int maDT)
        {
            //
            this.maDT = maDT;
            mn_CT_DV_HH = new Manager_CTSD_DICHVU_HANGHOA_1(maDT);
            //
            InitializeComponent();
        }










        //1.-n Load color btn
        public void LoadColorForThemXoa() { 
            btn_Them_CT_DV_HH.BackColor=Color.LightGreen;
            btn_Xoa_CT_DV_HH.BackColor = Color.OrangeRed;
            btn_XoaAll_CT_DV_HH.BackColor = Color.Violet;
        }

        public void Load_Imgs()
        {
            pb_CT_DV_HH_AnhCT.Image = new Bitmap(Application.StartupPath + "\\P1_C_Sharp_png\\QLSpa\\TieuThu_1.png");
        }


        //CTC
        //1.1 Load
        public void Load_CT_DV_HH_At_Design()
        {
            //lock
            gb_CT_DV_HH_ThemCT_DV.Enabled = false;


            //-> da dc kiemtra
            //1. get data
            dt_1 = mn_CT_DV_HH.Get_DT_GetDataTable();

            dgv_CT_DV_HH.DataSource = dt_1;




            //2. add cb_ & nb
            DataTable listTenHH= new DataTable();
            listTenHH = mn_HangHoa_1.Get_TenDT_GetDataTable();
            //clean cb_
            cb_CT_DV_HH_ThemTenDV.Items.Clear();
            foreach (DataRow row in listTenHH.Rows) {
                //MessageBox.Show(""+ row["tenHH"].ToString());
                cb_CT_DV_HH_ThemTenDV.Items.Add(row["tenHH"].ToString());

            }
            cb_CT_DV_HH_ThemTenDV.SelectedIndex = 0;
            
            //3. 

            //
            ChooseFirstValue_And_SendDataRowToCommand_CT_DV_HH();

        }



        //2. Find
        //2.1 CT_DV_HH
        public void SendDataRowToCommand_CT_DV_HH()
        {
            //DK do
            //0. get VT
            //DK do
            //if (dgv_CTHD_HOADON_DICHVU.Rows.Count > 0) { 

            //}
            if (dgv_CT_DV_HH.Rows.Count > 0)
            {
                int rowIndex = dgv_CT_DV_HH.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon

                //6. 
                string tenDV = Convert.ToString(dgv_CT_DV_HH.Rows[rowIndex].Cells["tenDV"].Value);
                txt_CT_DV_HH_TenDV.Text = tenDV;

                //6. 
                string tenHH = Convert.ToString(dgv_CT_DV_HH.Rows[rowIndex].Cells["tenHH"].Value);
                txt_CT_DV_HH_TenHH.Text = tenHH;

                //2. 
                decimal soLuong = Convert.ToDecimal(dgv_CT_DV_HH.Rows[rowIndex].Cells["soLuong"].Value);
                txt_CT_DV_HH_SoLuong.Text = soLuong.ToString();


            }



        }

        public void SendDataRowToCommand_CT_DV_HH(int rowIndex)
        {
            //DK do
            //0. get VT
            //DK do
            //if (dgv_CTHD_HOADON_DICHVU.Rows.Count > 0) { 

            //}
            if (dgv_CT_DV_HH.Rows.Count > 0)
            {
               // int rowIndex = dgv_CT_DV_HH.CurrentCell.RowIndex;
                // MessageBox.Show("Bna vua chon a: " + rowIndex);

                //Convert Ko quan tam KDL of Nguon

                //6. 
                string tenDV = Convert.ToString(dgv_CT_DV_HH.Rows[rowIndex].Cells["tenDV"].Value);
                txt_CT_DV_HH_TenDV.Text = tenDV;

                //6. 
                string tenHH = Convert.ToString(dgv_CT_DV_HH.Rows[rowIndex].Cells["tenHH"].Value);
                txt_CT_DV_HH_TenHH.Text = tenHH;

                //2. 
                decimal soLuong = Convert.ToDecimal(dgv_CT_DV_HH.Rows[rowIndex].Cells["soLuong"].Value);
                txt_CT_DV_HH_SoLuong.Text = soLuong.ToString();


            }



        }








        //2.2 ChooseFirstValue_And_SendDataRowToCommand_CTHD_HD_DV
        public void ChooseFirstValue_And_SendDataRowToCommand_CT_DV_HH()
        {
            //dk Do
            if (dgv_CT_DV_HH.Rows.Count > 0)
            {
                dgv_CT_DV_HH.Rows[0].Selected = true;
                SendDataRowToCommand_CT_DV_HH(0);
            }

        }






        //3. Do
        //3.1 Them
        public void Them1_DT_At_Design() {
            //1. neu dang Tat thi mo
            if (gb_CT_DV_HH_ThemCT_DV.Enabled == false)
            {
                gb_CT_DV_HH_ThemCT_DV.Enabled = true;
                nbUD_CT_DV_HH_ThemSoLuong.Value = 1;
                cb_CT_DV_HH_ThemTenDV.SelectedIndex = 0;
                cb_CT_DV_HH_ThemTenDV.Focus();
                MessageBox.Show("Vui lòng thêm 'Hàng hóa' và 'Số lượng' cho Chi Tiết DV!!!");



            }
            else
            {////Neu dang bat_> the data
                //<insert ND>
                //1. get ND
                decimal soLuong=Convert.ToDecimal(nbUD_CT_DV_HH_ThemSoLuong.Value);
                string tenHH=cb_CT_DV_HH_ThemTenDV.Text;

                //get nd
                DataTable dt_temp = new DataTable();
                dt_temp=mn_HangHoa_1.Get_maDT_From_TenDT_GetDataTable(tenHH);

                int maHH = Convert.ToInt32(dt_temp.Rows[0]["maHH"]);

                //MessageBox.Show("Dan: "+ tenHH +"\n"+
                //    "Dan: " + soLuong  + "\n" +
                //     "Dan maHH: " +maHH// + "\n" +

                // );

                //KT
                //maHH da co Chua
                if (mn_CT_DV_HH.CoTonTai_maHH_in_CT_DV_HH(maHH) == true)
                {
                    MessageBox.Show("Đã tồn tại sản phẩm '"+tenHH+"' trong Chi tiết dịch vụ!!!"+"\n"+
                        ">=============================<" + "\n" +
                        "Vui lòng chọn sản phẩm khác!!!" //+ "\n" +
                        );
                    return;
                }
                else 
                {
                    //MessageBox.Show("maHH chua TT-> co the chen");
                    //<insert ND>-2
                    if (mn_CT_DV_HH.Them1_DT(maHH, soLuong) == false)
                    {
                        MessageBox.Show("Thêm: Thất bại!!!");
                        return;
                    }
                    else {
                        MessageBox.Show("Thêm: Thành công!!!");
                        //load
                        Load_CT_DV_HH_At_Design();
                        //
                        nbUD_CT_DV_HH_ThemSoLuong.Value = 0;
                        cb_CT_DV_HH_ThemTenDV.SelectedIndex = 0;
                        gb_CT_DV_HH_ThemCT_DV.Enabled = false;
                    }

                }




            }

        }


        //3.1 Sua
        public void Sua1_DT_At_Design()
        {
            //BD
            // dgv_CTHD_HOADON_DICHVU.Rows[0].Selected = true;
            //0. DK do
            if (dgv_CT_DV_HH.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_CT_DV_HH.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                decimal soLuong = Convert.ToDecimal(txt_CT_DV_HH_SoLuong.Text);
                
                int maDV = Convert.ToInt32(dgv_CT_DV_HH.Rows[nowIndex].Cells["maDV"].Value);
                int maHH = Convert.ToInt32(dgv_CT_DV_HH.Rows[nowIndex].Cells["maHH"].Value);

                //KT
                //MessageBox.Show(" | "+soLuong  +"\n"+
                //    " | " + donGia + "\n" +
                //    " | " + maHD + "\n" +
                //    " | " + maHD //+ "\n" +
                //    );
                //3.GoiHam
                if (mn_CT_DV_HH.Sua1_DT(maDV, maHH, soLuong) == false)
                {
                    MessageBox.Show("Sửa: Thất Bại!!!");
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa: Thành công!!!");
                    Load_CT_DV_HH_At_Design();
                    ChooseFirstValue_And_SendDataRowToCommand_CT_DV_HH();
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
            if (dgv_CT_DV_HH.SelectedRows.Count > 0)
            {
                //1. vt
                int nowIndex = dgv_CT_DV_HH.CurrentCell.RowIndex;

                // txt_SoLuong.Text
                //2. get data
                //MessageBox.Show(" | " +txt_SoLuong.Text);
                int maDV = Convert.ToInt32(dgv_CT_DV_HH.Rows[nowIndex].Cells["maDV"].Value);
                int maHH = Convert.ToInt32(dgv_CT_DV_HH.Rows[nowIndex].Cells["maHH"].Value);

                //KT
                //MessageBox.Show(" | "+soLuong  +"\n"+
                //    " | " + donGia + "\n" +
                //    " | " + maHD + "\n" +
                //    " | " + maHD //+ "\n" +
                //    );
                //3.GoiHam
                if (mn_CT_DV_HH.Xoa1_DT(maDV, maHH) == false)
                {
                    MessageBox.Show("Xóa: Thất Bại!!!");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa: Thành công!!!");
                    Load_CT_DV_HH_At_Design();
                    ChooseFirstValue_And_SendDataRowToCommand_CT_DV_HH();
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
            if (dgv_CT_DV_HH.Rows.Count > 0)
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
                if (mn_CT_DV_HH.XoaN_DT_TheoMaHD() == false)
                {
                    MessageBox.Show("Xóa: Thất Bại!!!");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa: Thành công!!!");
                    Load_CT_DV_HH_At_Design();
                    //SendDataRowToCommand_CTHD_HD_DV();
                    return;
                }

                //C.Nhat
            }

            //end

        }

























        /// <summary>
        /// /////////////////////////////////////////////////////////////////////end
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            part0.TextBoxOnlyNumberMaDT(sender, e);

            //END
        }

        private void frm_No4_dgv_txt_btn_Load(object sender, EventArgs e)
        {
            //1.1 Load color btn
            LoadColorForThemXoa();

            //1.2 Load imgs
            Load_Imgs();

            //1.2 Load gdv
            Load_CT_DV_HH_At_Design();







        }






        //4.2.n .. Test LK
        public void m1()
        {
            DB_Mau hs = new DB_Mau();
            Manager_DataBase_1 db0 = new Manager_DataBase_1();
            Part_0_2_PT_For_DataBase_1 db1 = new Part_0_2_PT_For_DataBase_1();
            Manager_HoaDon_1 db2 = new Manager_HoaDon_1();

        }

        private void dgv_CT_DV_HH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SendDataRowToCommand_CT_DV_HH();
        }

        private void btn_Them_CT_DV_HH_Click(object sender, EventArgs e)
        {
            Them1_DT_At_Design();
            

        }

        private void txt_CT_DV_HH_SoLuong_TextChanged(object sender, EventArgs e)
        {
            part0.TextBoxOnlyMoney(sender, e);
        }

        private void btn_Sua_CT_DV_HH_Click(object sender, EventArgs e)
        {
            Sua1_DT_At_Design();
        }

        private void btn_Xoa_CT_DV_HH_Click(object sender, EventArgs e)
        {
            Xoa1_DT_At_Design();
        }

        private void btn_XoaAll_CT_DV_HH_Click(object sender, EventArgs e)
        {
            XoaN_DT_TheoMaHD_At_Design();
        }

        //////////END-Class
    }
}
