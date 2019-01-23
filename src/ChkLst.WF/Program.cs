using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace ChkLst.WF
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

            WFSettings.Init();

            Application.Run(new MainForm());
        }
    }
}
