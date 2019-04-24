using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new Font("맑은 고딕", 9);
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultMenuFont = new Font("맑은 고딕", 9);
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultPrintFont = new Font("맑은 고딕", 9);

            //This set the style to use skin technology
            DevExpress.LookAndFeel.UserLookAndFeel.Default.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            //Here we specify the skin to use by its name           
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2016 Black");
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyMainForm());
        }
    }
}
