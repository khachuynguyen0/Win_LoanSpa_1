//using DA_Loan_Spa._3_DataBase_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
//using System.Windows.Forms;
//P-1
using L4_DTO;
using L3_DAL;

namespace L2_DLL
{
    //Giong Class ben Java
    public class Manager_ChuyenNganh_1
    {
        //Nguyen Khac Huy - 2280601183
        //////////Start-Class
        //B-2. 
        //B-2. 
        //B-2. 
        Manager_DataBase_1 db = new Manager_DataBase_1();
        Manager_Khoa_1 mn_Khoa_1 = new Manager_Khoa_1();
        
        DataTable dt = new DataTable();
        //K-3.1
        public Manager_ChuyenNganh_1() { }
        //K-3.2
        //K-3.3


        //CTC-4.1


        //CTC-4.2
        //-4.2.1 Load all sv
        public DataTable Get_DT_GetDataTable()
        {
            //BD
            string truyVan = "";
            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
        }

        public DataTable Get_Name_GetDataTable()
        {
            //BD
            string truyVan = "select distinct a.tenCNganh\r\n" +
                "from MAJOR a";
            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);
            //End
        }

        //4.2.2 get maID theo name
        public int Get_maID_Theo_Name_GetInt(string tenDT)
        {
            //BD
            //1. 
            int maDT_DB = -1;

            //2. lay maKhoa tu tenKhoa
            string truyVan = "select distinct a.maCNganh\r\n" +
                "from MAJOR a\r\n" +
                "where a.tenCNganh=N'"+tenDT+"'";

            //3. tao dt chua date
            dt = db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);


            //4. KT rong
            //TH: KO tim dc
            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("Khong Ton Tai Khoa: " + tenDT);
                return maDT_DB;
            }

            //TH: tim dc
            maDT_DB = Convert.ToInt32(dt.Rows[0][1].ToString());

            return maDT_DB;
            //End
        }

        //1 TenCNganh theo ten tenKhoa
        public DataTable Get_TenDT_Theo_Orther_TenDT_GetDataTable(string tenKhoa)
        {
            //1 get ma khoa
            int maKhoa1= mn_Khoa_1.Get_maDT_From_tenDT_GetInt(tenKhoa);
            //BD
            string truyVan = "select distinct a.tenCNganh\r\n" +
                "from MAJOR a\r\n" +
                "where a.maKhoa="+maKhoa1+"";

            //tao DT chua
            dt = db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(truyVan);

            return dt;
            //End
        }

        //4.2.2





        ////-4.2.3 Kiem tra Ton tai maID
        ////T.Tai: Tra ve True
        ////KO T.Tai: False
        //public bool CoTonTaiMaID(string maID)
        //{

        //    //0.tao bien
        //    DataTable dtTemp = new DataTable();
        //    bool tontai = true;

        //    //1. you can change TruyVan :))
        //    string truyVan = "select 1 as tonTai\r\nfrom Student a \r\nwhere a.maSV='" + maID + "'";

        //    //2. dan vao dtTemp
        //    dtTemp = db.TruyVan1TableWithDataTable_GetDataTable(truyVan);

        //    //3. dan KT
        //    if (dtTemp.Rows.Count == 0) {
        //        tontai = false;
        //    }

        //    return tontai;
        //}

        //public bool CoTonTaiMaID_Short(string maID)
        //{
        //    //1. you can change TruyVan :))
        //    string truyVan = "select 1 as tonTai\r\n" +
        //        "from Student a \r\n" +
        //        "where a.maSV='" + maID + "'";

        //    //Neu lay dc g.Tri(have rows) thi return true
        //    return db.TruyVan1TableWithDataTable_GetDataTable(truyVan).Rows.Count > 0;
        //}


        ////-4.2.4 Them 1 DT
        ////inp: maID, tenKhoa
        //public void Them1DoiTuong(string maID, string tenSV, float diemSV, string tenKhoa) {
        //    //1. kiem tra MaID tontai chua
        //    if (CoTonTaiMaID_Short(maID) == true)
        //    {
        //        MessageBox.Show("maSV da Ton Tai: Yes");
        //        return; 
        //    }
        //    else {
        //        //2. lay maKhoa tu tenKhoa
        //        string truyVan = "select distinct a.maKhoa\r\n" +
        //            "from Student a join Faculty b on (a.maKhoa=b.maKhoa)\r\n" +
        //            "where b.tenKhoa=N'"+tenKhoa+"'";

        //        //3. tao dt chua date
        //        dt=db.TruyVan1TableWithDataTable_GetDataTable(truyVan);


        //        //4. KT rong
        //        //TH: KO tim dc
        //        if (dt.Rows.Count == 0) {
        //            MessageBox.Show("Khong Ton Tai Khoa: "+tenKhoa);
        //            return;
        //        }

        //        //TH: tim dc
        //        int maKhoa_DB = Convert.ToInt32(dt.Rows[0][1].ToString());

        //        //5. Dan data
        //        string truyVanThem = "INSERT INTO Student (maSV, tenSV, diemTB, maKhoa, avata) " +
        //            "VALUES (N'"+maID+"', N'"+tenSV+"', "+diemSV+", "+maKhoa_DB+", N'http//path1');";
        //        db.KhoiTaoSqlCmdVoiTruyVanOf(truyVanThem);

        //        // 6. Thông báo kết quả
        //        //kiem tra so row bi T.doi trong SQL
        //        //kq > 0-> T.cong, kq = 0-> false


        //        //6. T.Bao
        //        MessageBox.Show("Thêm: Thành công");
        //    }

        //}


        ////-4.2.5 Sua 1 DT
        ////inp: maID, tenKhoa
        //public void Sua1DoiTuong(string maID, string tenSV, float diemSV, string tenKhoa)
        //{
        //    //1. kiem tra MaID tontai chua
        //    if (CoTonTaiMaID_Short(maID) == true)
        //    {
        //        //2. lay maKhoa tu tenKhoa
        //        string truyVan = "select distinct a.maKhoa\r\n" +
        //            "from Student a join Faculty b on (a.maKhoa=b.maKhoa)\r\n" +
        //            "where b.tenKhoa=N'" + tenKhoa + "'";

        //        //3. tao dt chua date
        //        dt = db.TruyVan1TableWithDataTable_GetDataTable(truyVan);


        //        //4. KT rong
        //        //TH: KO tim dc
        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("Khong Ton Tai Khoa: " + tenKhoa);
        //            return;
        //        }

        //        //TH: tim dc
        //        int maKhoa_DB = Convert.ToInt32(dt.Rows[0][1].ToString());

        //        //5. Dan data
        //        string truyVanSua = "update a\r\nset a.tenSV='"+tenSV+"', a.diemTB="+diemSV+", a.maKhoa="+maKhoa_DB+"\r\n" +
        //            "from Student a\r\nwhere a.maSV='"+maID+"'";
        //        db.KhoiTaoSqlCmdVoiTruyVanOf(truyVanSua);

        //        // 6. Thông báo kết quả
        //        //kiem tra so row bi T.doi trong SQL
        //        //kq > 0-> T.cong, kq = 0-> false


        //        //6. T.Bao
        //        MessageBox.Show("Sửa: Thành công");
        //    }
        //    else
        //    {
        //        MessageBox.Show("maSV da Ton Tai: NO");
        //        return;

        //    }

        //}


        ////-4.2.6 Xoa 1 DT
        ////inp: maID, tenKhoa
        //public void Xoa1DoiTuong(string maID)
        //{
        //    //1. kiem tra MaID tontai chua
        //    if (CoTonTaiMaID_Short(maID) == true)
        //    {
        //        //5. Dan data
        //        string truyVanSua = "delete a\r\n" +
        //            "from Student a\r\n" +
        //            "where a.maSV='"+maID+"'";
        //        db.KhoiTaoSqlCmdVoiTruyVanOf(truyVanSua);

        //        //6. T.Bao
        //        MessageBox.Show("Xóa: Thành công");
        //    }
        //    else
        //    {
        //        MessageBox.Show("maSV da Ton Tai: NO");
        //        return;

        //    }

        //}


        //-4.2.7 DK Chuyen Nganh
        //inp: maID, tenKhoa

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
