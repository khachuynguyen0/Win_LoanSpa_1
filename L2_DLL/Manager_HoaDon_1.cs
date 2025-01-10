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
    public class Manager_HoaDon_1
    {
        //Nguyen Khac Huy - 2280601183
        //////////Start-Class
        //B-2. 
        Manager_DataBase_1 db =new Manager_DataBase_1(); 
        

        //K-3.1
        public Manager_HoaDon_1() { }
        //K-3.2
        //K-3.3


        //CTC-4.1
        public DataTable Get_DT_GetDataTable() {
            //BD
            string truyVan = "select a.ngayLap, a.tongTien, a.giamGia, a.tongSauGiam," +
                " a.soTienDaThanhToan, b.tenKH, a.maHD, a.maKH\r\n" +
                "from HOADON a join KHACHHANG b on (a.maKH=b.maKH)";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //
           
        }

        public DataTable Get_MaHD_MoiNhat_GetDataTable()
        {
            //BD
            string truyVan = "select max(a.maHD) as maHD\r\n" +
                "from HOADON a";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //

        }

        public int Get_MaHD_MoiNhat_GetInt()
        {
            //BD
            int maHD=-1;
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1=Get_MaHD_MoiNhat_GetDataTable();

            maHD = Convert.ToInt32(dt_temp_1.Rows[0]["maHD"]);

            return maHD;
            //End
            //

        }










        //CTC-4.2
        //4.2.1 co ton tai CTHD KO?
        //inp: maHD
        public bool CoTonTai_CTHD_HOADON_DICHVU(int maHD) { 
            //BD

            //1.tao biens
            bool CoTonTai=true;
            DataTable dtTemp = new DataTable();

            //2.tao truyu van
            string truyVan = "select b.tenDV, a.soLuong, a.donGia, (a.soLuong*a.donGia) as tongTien, " +
                "a.maHD, b.maDV\r\n" +
                "from CTHD_HOADON_DICHVU a join DICHVU b on (a.maDV=b.maDV)\r\n" +
                "where a.maHD="+maHD+"";
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
        //4.2.1 
        //->dau vao da kiem duyet
        //TC: true
        //inp: a.maHD, ngayLap, tongTien, giamGia, soTienDaThanhToanm
        public bool Them1_DT( decimal tongTien, decimal giamGia, decimal soTienDaThanhToan, int maKH)
        {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "insert into HOADON( tongTien, giamGia, soTienDaThanhToan,maKH) " +
                "values("+tongTien+", "+giamGia+", "+soTienDaThanhToan+", "+maKH+");";

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
        public bool Sua1_DT(int maHD, DateTime ngayLap, decimal tongTien, decimal giamGia, decimal soTienDaThanhToan)
        {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "update a\r\nset a.ngayLap='"+ngayLap.Year+"-"+ngayLap.Month+"-"+ngayLap.Day+"'," +
                " a.tongTien="+tongTien+", a.giamGia ="+giamGia+", a.soTienDaThanhToan="+soTienDaThanhToan+"\r\n" +
                "from HOADON a\r\nwhere a.maHD = "+maHD+"";

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
        public bool Xoa1_DT(int maHD) {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "delete a\r\n" +
                "from HOADON a\r\n" +
                "where a.maHD= '"+maHD+"'";

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
