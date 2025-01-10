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
    public class Manager_tab_KH_1
    {
        //Nguyen Khac Huy - 2280601183
        //////////Start-Class
        //B-2. 
        Manager_DataBase_1 db =new Manager_DataBase_1(); 
        

        //K-3.1
        public Manager_tab_KH_1() { }
        //K-3.2
        //K-3.3


        //CTC-4.1
        public DataTable Get_DT_GetDataTable() {
            //BD
            string truyVan = "select a.tenKH, a.SDT, a.ngayLap, " +
                "a.tongTien, a.maKH\r\n" +
                "from KHACHHANG a";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //
           
        }


        public DataTable Get_MaKH_MoiNhat_GetDataTable()
        {
            //BD
            string truyVan = "select max(a.maKH) as maKH\r\nfrom KHACHHANG a";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //

        }


        public DataTable Get_MaKH_From_SDT_GetDataTable(string SDT)
        {
            //BD
            string truyVan = "select a.maKH\r\n" +
                "from KHACHHANG a\r\n" +
                "where a.SDT='"+SDT+"'";

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
            string truyVan = "select *\r\n" +
                "from KHACHHANG a\r\n" +
                "where a.maKH="+maID+"";
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
        public bool CoTonTai_DT_in_HD(int maID)
        {
            //BD

            //1.tao biens
            bool CoTonTai = true;
            DataTable dtTemp = new DataTable();

            //2.tao truyu van
            string truyVan = "select *\r\n" +
                "from KHACHHANG a join HOADON b on (a.maKH=b.maKH)\r\n" +
                "where a.maKH="+maID+"";
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
        //4.2.1 co ton tai KO?
        //inp: maHD
        public bool CoTonTai_SDT_In_DT(string SDT)
        {
            //BD
            //1.tao biens
            bool CoTonTai = true;
            DataTable dtTemp = new DataTable();

            //2.tao truyu van
            string truyVan = "select *\r\nfrom KHACHHANG a\r\nwhere a.SDT='"+SDT+"'";
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
        public bool Them1_DT(string tenKH, string SDT, decimal tongTien)
        {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "insert into KHACHHANG(tenKH, SDT, tongTien) " +
                "values(N'"+tenKH+"', '"+SDT+"', "+tongTien+");";

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
        public bool Sua1_DT(int maDT, string tenKH, string SDT, DateTime ngayLap, decimal tongTien)
        {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "update a\r\n" +
                "set a.tenKH=N'"+tenKH+"',a.SDT='"+SDT+"' , a.ngayLap" +
                "='"+ngayLap.Year+"-"+ngayLap.Month+"-"+ngayLap.Day+"'," +
                " a.tongTien='"+tongTien+"'\r\n" +
                "from KHACHHANG a\r\n" +
                "where a.maKH="+maDT+"";

            //2. T.Th & KT
            //-> false-> succ=false
            succ = db.KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(truyVan);
            //
            return succ;

            //END
        }

        public bool Sua1_DT_Theo_MaDT_Va_TongTien(int maDT, decimal tongTien)
        {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "update a\r\n" +
                "set a.tongTien=a.tongTien+"+tongTien+"\r\n" +
                "from KHACHHANG a\r\n" +
                "where a.maKH="+maDT+";";

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
                "from KHACHHANG a\r\n" +
                "where a.maKH="+maDT+"";

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
