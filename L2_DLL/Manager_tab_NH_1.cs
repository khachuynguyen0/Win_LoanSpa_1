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
    public class Manager_tab_NH_1
    {
        //Nguyen Khac Huy - 2280601183
        //////////Start-Class
        //B-2. 
        Manager_DataBase_1 db =new Manager_DataBase_1(); 
        

        //K-3.1
        public Manager_tab_NH_1() { }
        //K-3.2
        //K-3.3


        //CTC-4.1
        public DataTable Get_DT_GetDataTable() {
            //BD
            string truyVan = "select b.tenNCC, a.ngayLap, a.tongTien, (case a.trangThai\r\n\t\t\t\t\t\t\t\t\t\t" +
                "when 1 then N'Đã thanh toán'\r\n\t\t\t\t\t\t\t\t\t\twhen 0 then N'Chưa thanh toán'\r\n\t\t\t\t\t\t\t\t\t\tend) " +
                "as sTrangThai, a.trangThai, a.maNH, a.maNCC\r\n" +
                "from NHAPHANG a join NCC b on (a.maNCC=b.maNCC)";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //
           
        }

        //CTC-4.2
        //4.2.1 co ton tai KO?
        //inp: maHD
        public bool CoTonTai_DT(int maID) { 
            //BD

            //1.tao biens
            bool CoTonTai=true;
            DataTable dtTemp = new DataTable();

            //2.tao truyu van
            string truyVan = "";
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
        public bool CoTonTai_DT_in_CT_NH_HH(int maID)
        {
            //BD

            //1.tao biens
            bool CoTonTai = true;
            DataTable dtTemp = new DataTable();

            //2.tao truyu van
            string truyVan = "select *\r\n" +
                "from NHAPHANG a join CT_NHAPHANG_HANGHOA b on" +
                " (a.maNH=b.maNH)\r\nwhere a.maNH="+maID+"";

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
        //TC: true
        //inp: a.maHD, ngayLap, tongTien, giamGia, soTienDaThanhToanm
        public bool Sua1_DT(int maDT, DateTime ngayLap, decimal tongTien, int trangThai)
        {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "update a\r\nset a.ngayLap='"+ngayLap.Year+"-"+ngayLap.Month+"-"+ngayLap.Day+"', a.tongTien="+tongTien+"," +
                " a.trangThai="+trangThai+"\r\n" +
                "from NHAPHANG a\r\n" +
                "where a.maNH="+maDT+"";

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
        public bool Xoa1_DT(int maDT) {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "delete a\r\n" +
                "from NHAPHANG a\r\n" +
                "where a.maNH="+maDT+"";

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
