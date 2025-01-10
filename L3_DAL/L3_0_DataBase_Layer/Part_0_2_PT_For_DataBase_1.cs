using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
///
using L4_DTO;

namespace L3_DAL
{
    public class Part_0_2_PT_For_DataBase_1
    {
        //string strCon = @"data source=HUY_PC_I5_VOSTR\SQLEXPRESS;initial catalog=QLSpa_1;integrated security=True;";
        //Nguyen Khac Huy - 2280601183
        //////////Start-Class
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
        public Part_0_2_PT_For_DataBase_1() { }
        //K-3.2
        //3.2.1 two name
        public Part_0_2_PT_For_DataBase_1(string nameS, string nameD)
        {
            this.nameServer = nameS;
            this.nameDataBase = nameD;
            this.strCon = "data source=" + nameServer + ";" +
                "initial catalog=" + nameDataBase + ";" +
                "integrated security=True;";
        }

        //3.2.2 one duong dan LK
        public Part_0_2_PT_For_DataBase_1(string duongDanLK)
        {
            this.strCon = duongDanLK;
        }

        //3.2.3 five name
        public Part_0_2_PT_For_DataBase_1(string nameS, string nameD, SqlConnection sqlCon,
            SqlCommand sqlCmd, DataTable dt)
        {
            this.nameServer = nameS;
            this.nameDataBase = nameD;
            this.strCon = "data source=" + nameServer + ";" +
                "initial catalog=" + nameDataBase + ";" +
                "integrated security=True;";
            //
            this.sqlCon = sqlCon;
            this.sqlCmd = sqlCmd;
            this.dt = dt;
        }


        //K-3.3


        //CTC-4.1

        //CTC-4.2
        //CTC
        //4.2.1. Mo connect on sqlCon
        public void OpenConnect()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }

        //4.2.2. Khoi tao SqlCommand on sqlCmd
        public bool KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(string lenhTruyVan)
        {
            bool run_able = true;
            try
            {
                //1. Mo connect
                OpenConnect();

                //set type
                sqlCmd.CommandType = CommandType.Text;
                //T'
                sqlCmd.CommandText = lenhTruyVan;

                //C-KN
                sqlCmd.Connection = sqlCon;

                //2.(very Important) T.thuc Thi lenhTruyVan len SQL/DB
                int kq = sqlCmd.ExecuteNonQuery();

                //3. tra ve 1-> run ok
                run_able=true;
                return run_able;
            }
            catch (Exception ex)
            {
                run_able = false;
                return run_able;
                //MessageBox.Show("loi nek: " + ex.Message);

            }

        }

        //4.2.3 Lay Table Theo Struy van va tra ve data Table:
        //Thuong dung de LoadData
        public DataTable Get_1Table_Have_STT_With_LenhTruyVan_GetDataTable(string lenhTruyVan)
        {
            // tao dt_ De chua Du Lieu
            DataTable dt = new DataTable();

            try
            {
                // 1. add STT vao Dau DataTable
                DataColumn sttColumn = new DataColumn("STT", typeof(int))
                {
                    AutoIncrement = true, // auto Tang
                    AutoIncrementSeed = 1, // moc BD
                    AutoIncrementStep = 1 //Buoc Nhay
                };

                // Them col vao dau (vt= 0)
                dt.Columns.Add(sttColumn);
                sttColumn.SetOrdinal(0); //vt==0

                // Khoi tao sqlCommand
                KhoiTao_ThucThi_SqlCmd_With_LenhTruyVanOf(lenhTruyVan);

                // Thuc thi lenh va do vao DataTable
                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd))
                {
                    sqlAdapter.Fill(dt); //Do data vao DataTable
                }

            }
            catch (Exception ex)
            {
                // Xu ly khi co loi
                Console.WriteLine("Lỗi trong quá trình truy vấn: " + ex.Message);
            }
            finally
            {
                // Dong K.Noi neu can
                if (sqlCmd.Connection.State == ConnectionState.Open)
                {
                    sqlCmd.Connection.Close();
                }
            }

            //Get  DataTable chua Data
            return dt;
        }










        //4.2.n .. Test LK
        public void m1()
        {
            DB_Mau hs = new DB_Mau();
        }        //////////END-Class
        //////////END-Class
        /////Nguyen Khac Huy - 2280601183
        ///

        //////////ENDt-Class
    }
}
