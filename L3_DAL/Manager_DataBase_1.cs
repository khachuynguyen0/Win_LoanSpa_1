//using DA_Loan_Spa._0_Class_Frm_Support;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DA_Loan_Spa;
///
using L4_DTO;

namespace L3_DAL
{
    public class Manager_DataBase_1
    {
        //Nguyen Khac Huy - 2280601183
        //////////Start-Class
        //B-2. 
        //string strCon = @""data source=HUY_PC_I5_VOSTR\SQLEXPRESS;initial catalog=QLSpa_1;integrated security=True";
        Part_0_2_PT_For_DataBase_1 db;
        string a1 = "HUY_PC_I5_VOSTR\\SQLEXPRESS";
        string a2 = "QLSpa_1";

        //B-2. 
        //2.1 name Sever
        public string nameServer;
        //2.2 name DataBase
        public string nameDataBase;
        //2.3 Chuoi LK
        public string strCon;


        //2.3
        public SqlConnection sqlCon = null;
        public SqlCommand sqlCmd = new SqlCommand();
        public DataTable dt = new DataTable();

        //K-3.1
        public Manager_DataBase_1()
        {
            //string strCon = @"data source=HUY_PC_I5_VOSTR\SQLEXPRESS;initial catalog=QLSpa_1;integrated security=True;";
            db=new Part_0_2_PT_For_DataBase_1(a1, a2, sqlCon, sqlCmd, dt);
            
        }
        //K-3.2
        //K-3.3


        //CTC-4.1
        //4. Truy Van 1 Table with ListView
        //HD



        //CTC-4.2
        //CTC-4.1

        //CTC-4.2
        //CTC
        //1. Mo connect on sqlCon
        public void OpenConnect()
        {
            db.OpenConnect();
        }

        //2. Khoi tao SqlCommand on sqlCmd
        public bool KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(string lenhTruyVan)
        {
            return db.KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(lenhTruyVan);

        }

        //4.2.3 Lay Table Theo Struy van va tra ve data Table:
        //Thuong dung de LoadData
        public DataTable Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(string lenhTruyVan)
        {
            return db.Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(lenhTruyVan);
        }

        //4.2.4 ..



        //4.2.n .. Test LK
        public void m1()
        {
            DB_Mau hs = new DB_Mau();
        }        //////////END-Class
        /////Nguyen Khac Huy - 2280601183
    }
}
