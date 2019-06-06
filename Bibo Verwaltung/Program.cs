using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    static class Program
    {
        //[DllImport("Shcore.dll")]
        //static extern int SetProcessDpiAwareness(int PROCESS_DPI_AWARENESS);

        //// According to https://msdn.microsoft.com/en-us/library/windows/desktop/dn280512(v=vs.85).aspx
        //private enum DpiAwareness
        //{
        //    None = 0,
        //    SystemAware = 1,
        //    PerMonitorAware = 2
        //}
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process.Start("ScreenSize.exe");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new w_s_login());
        }
    }
}
