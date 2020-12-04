using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.DevExpressWinforms.Report;
using DevExpress.XtraReports.UI;

namespace F5074.DevExpressWinforms.MyForm.I_XtraReport
{
    public partial class MyXtraReport01 : UserControl
    {
        public MyXtraReport01()
        {
            InitializeComponent();
            this.simpleButton1.Click += SimpleButton1_Click;
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            Report01 report = new Report01();
            //report.PrintingSystem.Document.AutoFitToPagesWidth = 3;
            ReportPrintTool pt = new ReportPrintTool(report);
            // https://www.devexpress.com/Support/Center/Question/Details/Q296340/position-of-the-report-on-the-screen
            // https://www.devexpress.com/Support/Center/Question/Details/T587198/how-to-zoom-a-report-in-the-documentviewer-to-fit-into-the-page-width
            pt.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            pt.PreviewForm.SaveState = false;
            pt.PreviewForm.SetDesktopBounds(0, 0, 1000, 900);
            pt.PreviewForm.PrintControl.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToPageWidth, null);
            //pt.ShowPreview();
            pt.ShowRibbonPreviewDialog();
            //pt.ShowRibbonPreview();
        }
    }
}
