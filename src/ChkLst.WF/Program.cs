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

            WindowsFormsSettings.ForceDirectXPaint();
            WindowsFormsSettings.EnableFormSkins();
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(SkinSvgPalette.Bezier.DarkTurquoise);
            var fs = WindowsFormsSettings.DefaultFont.Size;
            WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Segoe UI", fs);

            Application.Run(new MainForm());
        }
    }
}
