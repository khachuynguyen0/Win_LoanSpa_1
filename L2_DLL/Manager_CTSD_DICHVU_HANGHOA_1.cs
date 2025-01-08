//using DA_Loan_Spa._3_DataBase_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//P-1
using L4_DTO;
using L3_DAL;
using System.Security.AccessControl;




namespace L2_DLL
{
    //Giong Class ben Java
    public class Manager_CTSD_DICHVU_HANGHOA_1
    {
        //Nguyen Khac Huy - 2280601183
        //////////Start-Class
        //B-2. 
        Manager_DataBase_1 db =new Manager_DataBase_1();
        Manager_tab_HangHoa_1 mn_HangHoa_1=new Manager_tab_HangHoa_1();


        int maDV;

        //K-3.1
        public Manager_CTSD_DICHVU_HANGHOA_1() {
            this.maDV = 0;
                }
        //K-3.2
        public Manager_CTSD_DICHVU_HANGHOA_1(int maDV) {
            this.maDV = maDV;
        }
        //K-3.3


        //CTC-4.1
        //--3 load CTHD_HOADON_DICHVU +2-done
        //--inp: maHD
        //--oup: maDV->tenDV, soLuong, donGia, (sl* donGia), maHD, maDV
        public DataTable Get_DT_GetDataTable() {
            //BD
            string truyVan = "select b.tenDV, c.tenHH, a.soLuong, a.maDV, a.maHH\r\n\r\n" +
                "from CTSD_DICHVU_HANGHOA a join DICHVU b on (a.maDV=b.maDV) join \r\nHANGHOA c " +
                "on (a.maHH=c.maHH)\r\n\r\n" +
                "where a.maDV="+maDV+"";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //
           
        }

        //CTC-4.2
        //4.2.1 

        //->dau vao da kiem duyet
        //TC: true
        //inp: a.maHD, b.maDV
        public bool Sua1_DT(int maDV, int maHH, decimal soLuong ) { 
            //BD

            bool succ=true;
            //1.truy van
            string truyVan = "update a\r\n" +
                "set a.soLuong="+soLuong+"\r\n" +
                "from CTSD_DICHVU_HANGHOA a\r\n" +
                "where a.maHH="+maHH+" and a.maDV="+maDV+"";

            //2. T.Th & KT
            //-> false-> succ=false
            succ= db.KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(truyVan);
            //
            return succ;

            //END
        }

        //CTC-4.2
        //4.2.2
        public bool Xoa1_DT(int maDV, int maHH) {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "delete a\r\n" +
                "from CTSD_DICHVU_HANGHOA a\r\n" +
                "where a.maDV="+maDV+" and a.maHH="+maHH+"";

            //2. T.Th & KT
            //-> false-> succ=false
            succ = db.KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(truyVan);
            //
            return succ;

            //END
        }

        //CTC-4.2
        //4.2.2 dang N.cuu
        public bool Xoa1_DT_nRows(List<int> maHDs, List<int> maDVs)
        {
            //BD

            bool succ = true;
            
            //
            return succ;

            //END
        }

        //4.2.2 Xoa n CTHD_HOADON_DICHVU theo maHD
        public bool XoaN_DT_TheoMaHD() {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "delete a\r\n" +
                "from CTSD_DICHVU_HANGHOA a\r\n" +
                "where a.maDV="+maDV+"";

            //2. T.Th & KT
            //-> false-> succ=false
            succ = db.KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(truyVan);
            //
            return succ;

            //END

        }


        //CTC-4.2
        //4.2.2
        public bool Them1_DT(int maHH, decimal soLuong) {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "insert into CTSD_DICHVU_HANGHOA( maDV, maHH, soLuong) " +
                "values("+maDV+", "+maHH+", "+soLuong+");";

            //2. T.Th & KT
            //-> false-> succ=false
            succ = db.KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(truyVan);
            //
            return succ;

            //END

        }


        /////KT
        //1. Ton tai maHH in CT_DV_HH
        public bool CoTonTai_maHH_in_CT_DV_HH(int maHH)
        {
            //BD

            //1.tao biens
            bool CoTonTai = true;
            DataTable dtTemp = new DataTable();

            //2.tao truyu van
            string truyVan = "select *\r\n" +
                "from CTSD_DICHVU_HANGHOA a\r\n" +
                "where a.maDV=" + maDV + " and a.maHH=" + maHH + "";

            dtTemp = db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);

            //3. KT empty
            if (dtTemp.Rows.Count == 0)
            {
                CoTonTai = false;
            }

            //4.return
            return CoTonTai;

            //End
        }









        //4.2.n .. Test LK
        public void m1()
        {
            DB_Mau hs = new DB_Mau();
            Manager_DataBase_1 db0 = new Manager_DataBase_1();
            Part_0_2_PT_For_DataBase_1 db1 = new Part_0_2_PT_For_DataBase_1();
            
        }        //////////END-Class
        /////Nguyen Khac Huy - 2280601183
    }
}
