//using DA_Loan_Spa._2_Xuly_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//P-1
//p-1
using L2_DLL;
using L3_DAL;
using L4_DTO;
namespace L1_GUI
{
    public class Part_0_Forms_1
    {
        //Nguyen Khac Huy - 2280601183
        //////////Start-Class
        //B-2. 


        //K-3.1
        //K-3.2
        //K-3.3


        //CTC-4.1

        //CTC-4.2
        //4.2.1. for all Class
        public void FormForAllClass() {
            //Nguyen Khac Huy - 2280601183
            //////////Start-Class
            //B-2. 


            //K-3.1
            //K-3.2
            //K-3.3


            //CTC-4.1

            //CTC-4.2


            //////////END-Class
            /////Nguyen Khac Huy - 2280601183
        }

        //4.2.2. for all "1_Designer_Layer">==========BD=============<
        //Lv-0 Safe-Nothing
        public void FormForAll_1_Designer_Layer() {
            //BD
            //B-2
            Part_0_1_PT_For_WF_Base_1 sp_WF = new Part_0_1_PT_For_WF_Base_1();




            //CTC
            //1. Load
            //1.1 Load 
            //1.2 Load 
            //End
        }

        //LV-1  Safe-have load...
        public void FormForAll_1_Designer_Layer_lv1()
        {
            //B-2
            //2.1 "3_DataBase_Layer"
            Part_0_1_PT_For_WF_Base_1 sp_WF = new Part_0_1_PT_For_WF_Base_1();

            //2.1 "3_DataBase_Layer"
            //Manager_!TenCLXL_1 mn_SV_1 = new Manager_!TenCLX_1();

            //2.3 DataTables
            //DataTable dt_1_!TenCLX = new DataTable();




            //CTC
            //1. Load
            //public void Load!TenCLX_At_Design()
            //{
            //    dt_1_!TenCLX = mn_!TenCLX_1.Load!TenCLX();
            //    dgv_!TenCLX.DataSource = dt_1_!TenCLX;
            //}
            //1.1 Load 
            //1.2 Load 
        }

        //LV-2 mau T.Te
        public void FormForAll_1_Designer_Layer_lv2()
        {
            //B-2
            //2.1 "3_DataBase_Layer"
            Part_0_1_PT_For_WF_Base_1 sp_WF = new Part_0_1_PT_For_WF_Base_1();

            //2.1 "3_DataBase_Layer"
            //Manager_SinhVien_1 mn_SV_1 = new Manager_SinhVien_1();

            //2.3 DataTables
            //DataTable dt_1_SV = new DataTable();




            //CTC
            //1. Load
            //public void LoadSinhVien_At_Design()
            //{
            //    dt_1_SV = mn_SV_1.LoadSinhVien();
            //    dgv_SinhVien.DataSource = dt_1_SV;
            //}
            //1.1 Load 
            //1.2 Load 
        }


        //4.2.2.1 In ND
        public void SendNDToTextBox_SV()
        {
            //BD
            /*
             
            //BD

            if (//dgv_SinhVien.SelectedRows.Count > 0 ||
                dgv_SinhVien.SelectedCells.Count > 0)
            {
                //1.get rowindex
                //1.1 Lay theo V.Tri Cot
                int rowIndex = dgv_SinhVien.CurrentCell.RowIndex;
                txt_MaSo.Text = dt_1_SV.Rows[rowIndex][1].ToString();
                txt_HoTen.Text = dt_1_SV.Rows[rowIndex][2].ToString();

                //1.2 Lay theo Ten Cot
                //dt_
                txt_DiemTB.Text = dt_1_SV.Rows[rowIndex]["diemTB"].ToString();
                //dgv_
                txt_DiemTB.Text = dgv_SinhVien.CurrentRow.Cells["diemTB"].Value.ToString();

                ;

            }

            //end

            */
            //end
        }


        //1.CTC 
        public void GioiHanValueSoNhapVao_At_TextChanged()
        {
            ////1. lam tai "TextChanged" of TextBox
            //private void txt_Nomal_TextChanged(object sender, EventArgs e)
            //{//BD

            ////BD

            //    int a;//Cho cho nhao tu x->y
            //    if (int.TryParse(txt_GiamGia.Text, out a))
            //    {
            //        //ko thoa dk Tho Bo
            //        if (a < 0 || a > 100)
            //        {
            //            txt_GiamGia.Text = "";
            //        }

            //    }

            //    //end

            // }//end
        }


        //4.2.2. for all "1_Designer_Layer">==========END=============<








        //4.2.n .. Test LK
        public void m1()
        {
            DB_Mau hs = new DB_Mau();
            Manager_DataBase_1 db0 = new Manager_DataBase_1();
            Part_0_2_PT_For_DataBase_1 db1 = new Part_0_2_PT_For_DataBase_1();
            Manager_HoaDon_1 db2 = new Manager_HoaDon_1();

        }        //////////END-Class
        //////////END-Class
        /////Nguyen Khac Huy - 2280601183

    }
}