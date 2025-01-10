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
    public class Manager_Tab_BaoCao_1
    {
        //Nguyen Khac Huy - 2280601183
        //////////Start-Class
        //B-2. 
        Manager_DataBase_1 db =new Manager_DataBase_1(); 
        

        //K-3.1
        public Manager_Tab_BaoCao_1() { }
        //K-3.2
        //K-3.3


        //CTC-4.1
        //show
        public DataTable Get_DT_GetDataTable() {
            //BD
            string truyVan = "";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //
           
        }


        //------------------------------------------Day-BD
        //CTC-4.1
        //show
        public DataTable Get_SL_KH_In_Day_GetDataTable()
        {
            //BD
            string truyVan = "select count(*) as SL_KH_In_Day\r\n" +
                "from HOADON a\r\n" +
                "where day(a.ngayLap)=day(GETDATE()) and" +
                " \r\nmonth(a.ngayLap)=month(GETDATE()) " +
                "and \r\nyear(a.ngayLap)=year(GETDATE())";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //

        }


        //CTC-4.1
        //show
        public int Get_SL_KH_In_Day_GetInt()
        {
            //BD
            int sl_KH = 0;
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = Get_SL_KH_In_Day_GetDataTable();

            sl_KH = Convert.ToInt32(dt_temp_1.Rows[0]["SL_KH_In_Day"]);

            return sl_KH;

            //End
            //

        }


        //CTC-4.1
        //show
        public DataTable Get_Chi_In_Day_GetDataTable()
        {
            //BD
            string truyVan = "select ISNULL(sum(a.tongTien), 0) as tongChi\r\n" +
                "from NHAPHANG a\r\nwhere day(a.ngayLap)=day(GETDATE()) and \r\n" +
                "month(a.ngayLap)=month(GETDATE()) and" +
                " \r\nyear(a.ngayLap)=year(GETDATE())";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //

        }


        //CTC-4.1
        //show
        public decimal Get_Chi_In_Day_GetDecimal()
        {
            //BD
            decimal tongChi = 0;
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = Get_Chi_In_Day_GetDataTable();

            tongChi = Convert.ToDecimal(dt_temp_1.Rows[0]["tongChi"]);

            return tongChi;

            //End
            //
            //

        }


        //CTC-4.1
        //show
        public DataTable Get_Thu_In_Day_GetDataTable()
        {
            //BD
            string truyVan = "select ISNULL(sum(a.soTienDaThanhToan), 0) " +
                "as tongThu\r\nfrom HOADON a\r\n" +
                "where day(a.ngayLap)=day(GETDATE()) " +
                "and \r\nmonth(a.ngayLap)=month(GETDATE()) " +
                "and \r\nyear(a.ngayLap)=year(GETDATE())";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //

        }




        //CTC-4.1
        //show
        public decimal Get_Thu_In_Day_GetDecimal()
        {
            //BD
            decimal tongChi = 0;
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = Get_Thu_In_Day_GetDataTable();

            tongChi = Convert.ToDecimal(dt_temp_1.Rows[0]["tongThu"]);

            return tongChi;

            //End
            //
            //

        }


        //------------------------------------------Day-end

        //------------------------------------------month-BD
        //CTC-4.1
        //show
        public DataTable Get_SL_KH_In_Month_GetDataTable()
        {
            //BD
            string truyVan = "select count(*) as SL_KH_In_Month\r\n" +
                "from HOADON a\r\nwhere month(a.ngayLap)=month(GETDATE()) " +
                "and \r\nyear(a.ngayLap)=year(GETDATE())";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //

        }


        //CTC-4.1
        //show
        public int Get_SL_KH_In_Month_GetInt()
        {
            //BD
            int sl_KH = 0;
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = Get_SL_KH_In_Month_GetDataTable();

            sl_KH = Convert.ToInt32(dt_temp_1.Rows[0]["SL_KH_In_Month"]);

            return sl_KH;

            //End
            //

        }


        //->thu
        //CTC-4.1
        //show
        public DataTable Get_Thu_In_MonTh_GetDataTable()
        {
            //BD
            string truyVan = "select ISNULL(sum(a.soTienDaThanhToan), 0) as tongThu\r\n" +
                "from HOADON a\r\nwhere month(a.ngayLap)=month(GETDATE()) " +
                "and \r\nyear(a.ngayLap)=year(GETDATE())";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //

        }




        //CTC-4.1
        //show
        public decimal Get_Thu_In_Month_GetDecimal()
        {
            //BD
            decimal tongChi = 0;
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = Get_Thu_In_MonTh_GetDataTable();

            tongChi = Convert.ToDecimal(dt_temp_1.Rows[0]["tongThu"]);

            return tongChi;

            //End
            //
            //

        }



        //->Chi
        //CTC-4.1
        //show
        public DataTable Get_Chi_In_Month_GetDataTable()
        {
            //BD
            string truyVan = "select ISNULL(sum(a.tongTien), 0) as tongChi\r\n" +
                "from NHAPHANG a\r\nwhere month(a.ngayLap)=month(GETDATE()) " +
                "and \r\nyear(a.ngayLap)=year(GETDATE())";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //

        }


        //CTC-4.1
        //show
        public decimal Get_Chi_In_Month_GetDecimal()
        {
            //BD
            decimal tongChi = 0;
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = Get_Chi_In_Month_GetDataTable();

            tongChi = Convert.ToDecimal(dt_temp_1.Rows[0]["tongChi"]);

            return tongChi;

            //End
            //
            //

        }


        //------------------------------------------month-End

        //------------------------------------------year-BD

        //CTC-4.1
        //show
        public DataTable Get_SL_KH_In_Year_GetDataTable()
        {
            //BD
            string truyVan = "select count(*) as" +
                " SL_KH_In_Year\r\nfrom HOADON a\r\n" +
                "where year(a.ngayLap)=year(GETDATE())";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //

        }


        //CTC-4.1
        //show
        public int Get_SL_KH_In_Year_GetInt()
        {
            //BD
            int sl_KH = 0;
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = Get_SL_KH_In_Year_GetDataTable();

            sl_KH = Convert.ToInt32(dt_temp_1.Rows[0]["SL_KH_In_Year"]);

            return sl_KH;

            //End
            //

        }


        //->thu
        //CTC-4.1
        //show
        public DataTable Get_Thu_In_Year_GetDataTable()
        {
            //BD
            string truyVan = "select ISNULL(sum(a.soTienDaThanhToan), 0) " +
                "as tongThu\r\nfrom HOADON a\r\n" +
                "where year(a.ngayLap)=year(GETDATE())";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //

        }




        //CTC-4.1
        //show
        public decimal Get_Thu_In_Year_GetDecimal()
        {
            //BD
            decimal tongChi = 0;
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = Get_Thu_In_Year_GetDataTable();

            tongChi = Convert.ToDecimal(dt_temp_1.Rows[0]["tongThu"]);

            return tongChi;

            //End
            //
            //

        }



        //->Chi
        //CTC-4.1
        //show
        public DataTable Get_Chi_In_Year_GetDataTable()
        {
            //BD
            string truyVan = "select ISNULL(sum(a.tongTien), 0) as " +
                "tongChi\r\nfrom NHAPHANG a\r\n" +
                "where year(a.ngayLap)=year(GETDATE())";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //

        }


        //CTC-4.1
        //show
        public decimal Get_Chi_In_Year_GetDecimal()
        {
            //BD
            decimal tongChi = 0;
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = Get_Chi_In_Year_GetDataTable();

            tongChi = Convert.ToDecimal(dt_temp_1.Rows[0]["tongChi"]);

            return tongChi;

            //End
            //
            //

        }


        //------------------------------------------year-end

        //------------------------------------------Tu A->b-BD

        //CTC-4.1
        //show
        public DataTable Get_SL_KH_In_A_To_B_GetDataTable(int dayA, int monthA, int yearA,
            int dayB, int monthB, int yearB)
        {
            //BD
            string truyVan = "select count(*) as SL_KH\r\n" +
                "from HOADON a\r\nwhere (a.ngayLap>='"+yearA+"-"+monthA+"-"+dayA+"') " +
                "and (a.ngayLap <= '"+yearB+"-"+monthB+"-"+dayB+"')";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //

        }


        //CTC-4.1
        //show
        public int Get_SL_KH_In_A_To_B_GetInt(int dayA, int monthA, int yearA,
            int dayB, int monthB, int yearB)
        {
            //BD
            int sl_KH = 0;
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = Get_SL_KH_In_A_To_B_GetDataTable(dayA, monthA, yearA,
                dayB, monthB, yearB);

            sl_KH = Convert.ToInt32(dt_temp_1.Rows[0]["SL_KH"]);

            return sl_KH;

            //End
            //

        }


        //->thu
        //CTC-4.1
        //show
        public DataTable Get_Thu_In_A_To_B_GetDataTable(int dayA, int monthA, int yearA,
            int dayB, int monthB, int yearB)
        {
            //BD
            string truyVan = "select ISNULL(sum(a.soTienDaThanhToan), 0) " +
                "as tongThu\r\nfrom HOADON a\r\n" +
                "where (a.ngayLap>='"+yearA+"-"+monthA+"-"+dayA+"') " +
                "and (a.ngayLap <= '"+yearB+"-"+monthB+"-"+dayB+"')";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //

        }




        //CTC-4.1
        //show
        public decimal Get_Thu_In_A_To_B_GetDecimal(int dayA, int monthA, int yearA,
            int dayB, int monthB, int yearB)
        {
            //BD
            decimal tongChi = 0;
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = Get_Thu_In_A_To_B_GetDataTable(dayA, monthA, yearA,
                dayB, monthB, yearB);

            tongChi = Convert.ToDecimal(dt_temp_1.Rows[0]["tongThu"]);

            return tongChi;

            //End
            //
            //

        }



        //->Chi
        //CTC-4.1
        //show
        public DataTable Get_Chi_In_A_To_B_GetDataTable(int dayA, int monthA, int yearA,
            int dayB, int monthB, int yearB)
        {
            //BD
            string truyVan = "select ISNULL(sum(a.tongTien), 0) as tongChi\r\n" +
                "from NHAPHANG a\r\n" +
                "where (a.ngayLap>='"+yearA+"-"+monthA+"-"+dayA+"') " +
                "and (a.ngayLap <= '"+yearB+"-"+monthB+"-"+dayB+"')";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //

        }


        //CTC-4.1
        //show
        public decimal Get_Chi_In_A_To_B_GetDecimal(int dayA, int monthA, int yearA,
            int dayB, int monthB, int yearB)
        {
            //BD
            decimal tongChi = 0;
            DataTable dt_temp_1 = new DataTable();
            dt_temp_1 = Get_Chi_In_A_To_B_GetDataTable(dayA, monthA, yearA,
                dayB, monthB, yearB);

            tongChi = Convert.ToDecimal(dt_temp_1.Rows[0]["tongChi"]);

            return tongChi;

            //End
            //
            //

        }











        //------------------------------------------Tu A->b-end











        //CTC-4.2
        //4.2.1 co ton tai KO?
        //inp: maHD
        public bool CoTonTai_DT_Theo_TenHH(string tenHH) { 
            //BD
            
            //1.tao biens
            bool CoTonTai=true;
            DataTable dtTemp = new DataTable();

            //2.tao truyu van
            string truyVan = "select *\r\n" +
                "from HANGHOA a\r\n" +
                "where a.tenHH=N'"+tenHH+"'";

            dtTemp = db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);

            //3. KT empty
            if (dtTemp.Rows.Count == 0) { 
                CoTonTai = false;
            }

            //4.return
            return CoTonTai;

            //End
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
