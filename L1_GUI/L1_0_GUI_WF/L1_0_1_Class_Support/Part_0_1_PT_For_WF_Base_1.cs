//using DA_Loan_Spa.Class_Frm_Support;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//p-1
using L2_DLL;
using L3_DAL;
using L4_DTO;
namespace L1_GUI
{
    public class Part_0_1_PT_For_WF_Base_1
    {
        //Nguyen Khac Huy - 2280601183
        //////////Start-Class
        //B-2. 


        //K-3.1
        //K-3.2
        //K-3.3


        //CTC-4.1

        //CTC-4.2
        //>=================================1. On WF=============================<BD
        //1.1 Thong bao khi tat CT
        public void NoticeWhenClosing(object sender, FormClosingEventArgs e) {
            //BD
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

            //end

        }




        //>=================================1. On WF=============================<END

        //>================================2. On Common==============================<BD
        //2.1 On TextBox
        //2.1.1 TT-1. Chi Cho Nhap So(Số TKs/MaSV)
        public void TextBoxOnlyNumberMaDT(object sender, KeyPressEventArgs e) {
            //BD
            
            //1. Chi Cho Nhap So
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Vui lòng Nhập: Số");
            }

            //End
        }


        //2.1.2 TT-2. Chi Cho Nhap Chu (VD: Họ tên)
        public void TextBoxOnlyText(object sender, KeyPressEventArgs e) {
            //BD

            //2. Chi Cho Nhap Chu (VD: Họ tên)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Vui lòng Nhập: Chữ");
            }

            //End
        }

        //2.1.3 TT-3. Chi Cho Nhap So: So Thuc(VD: Diem TB)
        public void TextBoxOnlySoThuc(object sender, KeyPressEventArgs e) {
            //BD

            //txt_DiemTB.MaxLength = 3;//vd 8.5
            //3. Chi Cho Nhap So: So Thuc(VD: Diem TB)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                //MessageBox.Show("Vui lòng Nhập: Số");
            }

            //END
        }

        ///------------
        //2.1.4 TT-4: nhap money(have ",")
        public void TextBoxOnlyMoney(object sender, EventArgs e) {
            TextBox txt = sender as TextBox;

            if (txt.Text == "") return; // Nếu ô trống, không làm gì

            string input = txt.Text.Replace(",", ""); // Loại bỏ dấu phẩy cũ
            if (decimal.TryParse(input, out decimal number)) // Kiểm tra nếu là số
            {
                txt.Text = string.Format("{0:N0}", number); // Format lại theo hàng nghìn
                txt.SelectionStart = txt.Text.Length; // Đặt con trỏ cuối
            }
            //else//Them chan chu tai keypresss
            //{
            //    //MessageBox.Show("Chỉ được nhập số!"); // Thông báo nếu nhập sai
            //    txt.Text = ""; // Xóa nội dung không hợp lệ
            //}
        }

        //>================================2. On Common==============================<END






        //4.2.n .. Test LK
        public void m1()
        {
            DB_Mau hs = new DB_Mau();
            Manager_DataBase_1 db0 = new Manager_DataBase_1();
            Part_0_2_PT_For_DataBase_1 db1 = new Part_0_2_PT_For_DataBase_1();
            Manager_HoaDon_1 db2=new Manager_HoaDon_1();

        }        //////////END-Class
        //////////END-Class
        /////Nguyen Khac Huy - 2280601183
    }
}
