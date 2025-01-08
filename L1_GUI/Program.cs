
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//p-1
using L2_DLL;
using L3_DAL;
using L4_DTO;

namespace L1_GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_N1());
            //Application.Run(new frm_LoanSpa_Main_01());
            Application.Run(new frm_LoanSpa_00_Login());

        }
    }
}
