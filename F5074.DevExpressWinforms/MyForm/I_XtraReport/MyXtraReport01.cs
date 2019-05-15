using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.DevExpressWinforms.MyReport;
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
            ReportPrintTool pt = new ReportPrintTool(report);
            pt.ShowPreview();
        }
    }
}
