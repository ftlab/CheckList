using DevExpress.LookAndFeel;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;

namespace ChkLst.WF
{
    public static class WFSettings
    {
        public static void Init()
        {
            WindowsFormsSettings.ForceDirectXPaint();
            WindowsFormsSettings.EnableFormSkins();
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(SkinSvgPalette.Bezier.DarkTurquoise);
            var fs = WindowsFormsSettings.DefaultFont.Size;
            WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Segoe UI", fs);

            MVVMContext.RegisterXtraMessageBoxService();
            MVVMContext.RegisterOpenFileDialogService();
            MVVMContext.RegisterSaveFileDialogService();
        }
    }
}
