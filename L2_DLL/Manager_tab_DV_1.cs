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
using System.Data.SqlClient;




namespace L2_DLL
{
    //Giong Class ben Java
    public class Manager_tab_DV_1
    {
        //Nguyen Khac Huy - 2280601183
        //////////Start-Class
        //B-2. 
        Manager_DataBase_1 db =new Manager_DataBase_1(); 
        

        //K-3.1
        public Manager_tab_DV_1() { }
        //K-3.2
        //K-3.3


        //CTC-4.1
        public DataTable Get_DT_GetDataTable() {
            //BD
            string truyVan = "select a.tenDV, a.giaDV, a.maDV\r\n" +
                "from DICHVU a";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //
           
        }

        //CTC-4.2
        //4.2.1 co ton tai KO?
        //inp: maHD
        public bool CoTonTai_DT_Theo_TenDV(string tenDV) { 
            //BD
            
            //1.tao biens
            bool CoTonTai=true;
            DataTable dtTemp = new DataTable();

            //2.tao truyu van
            string truyVan = "select *\r\n" +
                "from DICHVU a\r\n" +
                "where a.tenDV=N'"+tenDV+"'";
            dtTemp = db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);

            //3. KT empty
            if (dtTemp.Rows.Count == 0) { 
                CoTonTai = false;
            }

            //4.return
            return CoTonTai;

            //End
        }

        //CTC-4.2
        //4.2.1 co ton tai KO?
        //inp: maHD
        public bool CoTonTai_DT_in_CT_DV_HH(int maID)
        {
            //BD

            //1.tao biens
            bool CoTonTai = true;
            DataTable dtTemp = new DataTable();

            //2.tao truyu van
            string truyVan = "select *\r\nfrom DICHVU a join CTSD_DICHVU_HANGHOA b \r\non" +
                " (a.maDV=b.maDV)\r\n" +
                "where a.maDV="+maID+"";
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



        //CTC-4.2
        //4.2.1 
        //->dau vao da kiem duyet
        //-> ko con ton tai CTHD
        //TC: true
        //inp: a.maHD
        public bool Them1_DT(string tenDT, decimal giaDV)
        {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "insert into DICHVU(tenDV, giaDV) " +
                "values(N'"+tenDT+"', "+giaDV+");";

            //2. T.Th & KT
            //-> false-> succ=false
            succ = db.KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(truyVan);
            //
            return succ;

            //END
        }

        //CTC-4.2
        //4.2.1 
        //->dau vao da kiem duyet
        //TC: true
        //inp: a.maHD, ngayLap, tongTien, giamGia, soTienDaThanhToanm
        public bool Sua1_DT(int maDT, string tenDT, decimal giaDT)
        {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "update a\r\n" +
                "set a.tenDV=N'"+tenDT+"', a.giaDV="+giaDT+"\r\n" +
                "from DICHVU a\r\n" +
                "where a.maDV="+maDT+"\r\n";

            //2. T.Th & KT
            //-> false-> succ=false
            succ = db.KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(truyVan);
            //
            return succ;

            //END
        }

        //CTC-4.2
        //4.2.1 
        //->dau vao da kiem duyet
        //-> ko con ton tai CTHD
        //TC: true
        //inp: a.maHD
        public bool Xoa1_DT_Theo_MaDT(int maDT) {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "";

            //2. T.Th & KT
            //-> false-> succ=false
            succ = db.KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(truyVan);
            //
            return succ;

            //END
        }






        //4.2.n .. Test LK
        public void m1()
        {            DB_Mau hs = new DB_Mau();
            Manager_DataBase_1 db0 = new Manager_DataBase_1();
            Part_0_2_PT_For_DataBase_1 db1 = new Part_0_2_PT_For_DataBase_1();
            
        }        //////////END-Class
        /////Nguyen Khac Huy - 2280601183
    }
}
