//using DA_Loan_Spa._3_DataBase_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
//P-1
using L4_DTO;
using L3_DAL;

namespace L2_DLL
{
    //Giong Class ben Java
    public class Manager_SinhVien_1
    {
        //Nguyen Khac Huy - 2280601183
        //////////Start-Class
        //B-2. 
        Manager_DataBase_1 db = new Manager_DataBase_1();
        Manager_ChuyenNganh_1 mn_CN_1=new Manager_ChuyenNganh_1();
        
        DataTable dt = new DataTable();
        //K-3.1
        public Manager_SinhVien_1() { }
        //K-3.2
        //K-3.3


        //CTC-4.1


        //CTC-4.2
        //-4.2.1 Load all sv
        public DataTable Get_DT_GetDataTable()
        {
            //BD
            string truyVan = "select a.maSV, a.tenSV, a.diemTB, a.avata, b.tenKhoa, b.maKhoa, a.maCNganh\r\n" +
                "from Student a join Faculty b on (a.maKhoa=b.maKhoa) ";
            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
        }

        //-4.2.1 Load all sv
        public DataTable Get_DT_Null_CNganh_GetDataTable()
        {
            //BD
            string truyVan = "select a.maSV, a.tenSV, a.diemTB, a.avata, b.tenKhoa, b.maKhoa, a.maCNganh\r\n" +
                "from Student a join Faculty b on (a.maKhoa=b.maKhoa) \r\n" +
                "where a.maCNganh is null";
            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
        }

        //-4.2.3 Kiem tra Ton tai maID
        //T.Tai: Tra ve True
        //KO T.Tai: False
        public bool CoTonTaiMaDT_ID(string maID)
        {

            //0.tao bien
            DataTable dtTemp = new DataTable();
            bool tontai = true;

            //1. you can change TruyVan :))
            string truyVan = "select 1 as tonTai\r\nfrom Student a \r\nwhere a.maSV='" + maID + "'";

            //2. dan vao dtTemp
            dtTemp = db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);

            //3. dan KT
            if (dtTemp.Rows.Count == 0) {
                tontai = false;
            }

            return tontai;
        }

        public bool CoTonTaiMaDT_ID_Short(string maID)
        {
            //1. you can change TruyVan :))
            string truyVan = "select 1 as tonTai\r\n" +
                "from Student a \r\n" +
                "where a.maSV='" + maID + "'";

            //Neu lay dc g.Tri(have rows) thi return true
            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan).Rows.Count > 0;
        }


        //-4.2.4 Them 1 DT
        //inp: maID, tenKhoa
        public bool Them1_DT(string maID, string tenSV, float diemSV, string tenKhoa) {

                //1.tao bien
                bool run_able = true;

                //2. lay maKhoa tu tenKhoa
                string truyVan = "select distinct a.maKhoa\r\n" +
                    "from Student a join Faculty b on (a.maKhoa=b.maKhoa)\r\n" +
                    "where b.tenKhoa=N'"+tenKhoa+"'";

                //3. tao dt chua date
                dt=db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);


                //4. KT rong
                //TH: KO tim dc
                if (dt.Rows.Count == 0) {
                   // MessageBox.Show("Khong Ton Tai Khoa: "+tenKhoa);
                   run_able = false;
                    return run_able;
                }

                //TH: tim dc
                int maKhoa_DB = Convert.ToInt32(dt.Rows[0][1].ToString());

                //5. Dan data
                string truyVanThem = "INSERT INTO Student (maSV, tenSV, diemTB, maKhoa, avata) " +
                    "VALUES (N'"+maID+"', N'"+tenSV+"', "+diemSV+", "+maKhoa_DB+", N'http//path1');";

                //get value
                run_able= db.KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(truyVanThem);

            // 6. Thông báo kết quả



            //6. T.Bao
            //  MessageBox.Show("Thêm: Thành công");
            return run_able;
        }


        //-4.2.5 Sua 1 DT
        //inp: maID, tenKhoa
        public bool Sua1_DT(string maID, string tenSV, float diemSV, string tenKhoa)
        {
            //1. kiem tra MaID tontai chua
            if (CoTonTaiMaDT_ID_Short(maID) == true)
            {
                //2. lay maKhoa tu tenKhoa
                string truyVan = "select distinct a.maKhoa\r\n" +
                    "from Student a join Faculty b on (a.maKhoa=b.maKhoa)\r\n" +
                    "where b.tenKhoa=N'" + tenKhoa + "'";

                //3. tao dt chua date
                dt = db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);


                //4. KT rong
                //TH: KO tim dc
                if (dt.Rows.Count == 0)
                {
                    //MessageBox.Show("Khong Ton Tai Khoa: " + tenKhoa);
                    return false;
                }

                //TH: tim dc
                int maKhoa_DB = Convert.ToInt32(dt.Rows[0][1].ToString());

                //5. Dan data
                string truyVanSua = "update a\r\nset a.tenSV='"+tenSV+"', a.diemTB="+diemSV+", a.maKhoa="+maKhoa_DB+"\r\n" +
                    "from Student a\r\nwhere a.maSV='"+maID+"'";
                db.KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(truyVanSua);

                // 6. Thông báo kết quả
                //kiem tra so row bi T.doi trong SQL
                //kq > 0-> T.cong, kq = 0-> false


                //6. T.Bao
                //MessageBox.Show("Sửa: Thành công");
                return true;
            }
            else
            {
                //MessageBox.Show("maSV da Ton Tai: NO");
                return false;

            }

        }


        //-4.2.6 Xoa 1 DT
        //inp: maID, tenKhoa
        public bool Xoa1_DT(string maID)
        {
            //1. kiem tra MaID tontai chua
            if (CoTonTaiMaDT_ID_Short(maID) == true)
            {
                //5. Dan data
                string truyVanSua = "delete a\r\n" +
                    "from Student a\r\n" +
                    "where a.maSV='"+maID+"'";
                db.KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(truyVanSua);
                return true;
                //6. T.Bao
              //  MessageBox.Show("Xóa: Thành công");
            }
            else
            {
                //  MessageBox.Show("maSV da Ton Tai: NO");
                return false;

            }

        }


        //-4.2.7 DK Chuyen Nganh
        //inp: maID, tenKhoa
        //vd: thjem maCN vao cho 1 SV
        public bool Add_maDT_For1_DT_Theo_Orther_TenDT(string maDT, string tenDT) { 
            //BD

            //1. get maDT tu tenDT
            int new_maDT=Convert.ToInt32(mn_CN_1.Get_maID_Theo_Name_GetInt(tenDT));

            //2. update theo maDT thoi
            string truyVan = "update a\r\n" +
                "set a.maCNganh="+new_maDT+"\r\n" +
                "from Student a\r\n" +
                "where a.maSV='"+maDT+"'";

            //3. run
            return db.KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(truyVan);
            //Done
            
            //END
        }
        //



        //4.2.n .. Test LK
        public void m1()
        {
            DB_Mau hs = new DB_Mau();
            Manager_DataBase_1 db0 = new Manager_DataBase_1();
            Part_0_2_PT_For_DataBase_1 db1 = new Part_0_2_PT_For_DataBase_1();

        }        //////////END-Class
        //////////END-Class
        /////Nguyen Khac Huy - 2280601183
        /////MessageBox.Show("");
    }
}
