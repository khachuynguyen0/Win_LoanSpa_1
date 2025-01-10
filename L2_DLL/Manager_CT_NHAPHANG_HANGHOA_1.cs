﻿//using DA_Loan_Spa._3_DataBase_Layer;
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
    public class Manager_CT_NHAPHANG_HANGHOA_1
    {
        //Nguyen Khac Huy - 2280601183
        //////////Start-Class
        //B-2. 
        Manager_DataBase_1 db =new Manager_DataBase_1();
        int maNH;

        //K-3.1
        public Manager_CT_NHAPHANG_HANGHOA_1() {
            this.maNH = 0;
                }
        //K-3.2
        public Manager_CT_NHAPHANG_HANGHOA_1(int maNH) {
            this.maNH = maNH;
        }
        //K-3.3


        //CTC-4.1
        //--3 load CTHD_HOADON_DICHVU +2-done
        //--inp: maHD
        //--oup: maDV->tenDV, soLuong, donGia, (sl* donGia), maHD, maDV
        public DataTable Get_DT_GetDataTable() {
            //BD
            string truyVan = "select b.tenHH, a.soLuong, a.donGia, (a.soLuong*a.donGia) " +
                "as tongTien, a.maNH, a.maHH\r\n" +
                "from CT_NHAPHANG_HANGHOA a join HANGHOA b on (a.maHH=b.maHH)\r\n" +
                "where a.maNH="+maNH+"";

            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
            //
           
        }











        //CTC-4.2
        //4.2.1 
        //->dau vao da kiem duyet
        //TC: true
        //inp: a.maHD, b.maDV
        public bool Them1_DT(int maNH, int maHH, decimal soLuong, decimal donGia)
        {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "insert into CT_NHAPHANG_HANGHOA( maNH, maHH, soLuong, donGia)" +
                " values("+maNH+", "+maHH+", "+soLuong+","+donGia+");";

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
        //inp: a.maHD, b.maDV
        public bool Sua1_DT(int maNH, int maHH, decimal soLuong, decimal donGia ) { 
            //BD

            bool succ=true;
            //1.truy van
            string truyVan = "update a\r\n" +
                "set a.soLuong="+soLuong+", a.donGia="+donGia+"\r\n" +
                "from CT_NHAPHANG_HANGHOA a\r\n" +
                "where a.maNH="+maNH+" and a.maHH="+maHH+"";

            //2. T.Th & KT
            //-> false-> succ=false
            succ= db.KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(truyVan);
            //
            return succ;

            //END
        }

        //CTC-4.2
        //4.2.2
        public bool Xoa1_DT(int maNH, int maHH) {
            //BD

            bool succ = true;
            //1.truy van
            string truyVan = "delete a\r\n" +
                "from CT_NHAPHANG_HANGHOA a\r\n" +
                "where a.maNH="+maNH+" and a.maHH="+maHH+"";

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
                "from CT_NHAPHANG_HANGHOA a\r\n" +
                "where a.maNH="+maNH+"";

            //2. T.Th & KT
            //-> false-> succ=false
            succ = db.KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(truyVan);
            //
            return succ;

            //END

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
