using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SDSU_Rock_Wall_CRM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var report = new Report();
            report.generateMasterReport();
            var loginForm = new loginForm();
            loginForm.Show();
            Application.Run();
        }
    }
}
