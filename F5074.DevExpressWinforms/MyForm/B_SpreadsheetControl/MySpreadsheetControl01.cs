using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using DevExpress.Spreadsheet;

namespace F5074.DevExpressWinforms.MyForm.B_SpreadsheetControl
{
    public partial class MySpreadsheetControl01 : UserControl
    {
        public MySpreadsheetControl01()
        {
            InitializeComponent();
            WindowsUIButton btn1 = new WindowsUIButton("Btn1", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/refresh_16x16.png") });
            WindowsUIButton btn2 = new WindowsUIButton("Btn2", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_16x16.png") });
            WindowsUIButton btn3 = new WindowsUIButton("Btn3", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/apply_16x16.png") });
            WindowsUIButton btn4 = new WindowsUIButton("Btn4", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/cancel_16x16.png") });
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] { btn1, btn2, btn3, btn4 });
            this.windowsUIButtonPanel1.ButtonClick += windowsUIButtonPanel1_ButtonClick;
        }
        private void windowsUIButtonPanel1_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Caption != null && btn.Caption.Equals("Btn1"))
            {
                //MessageBox.Show(btn.Caption);
                string.Format("{0}Data\\생산일보(배합).xlsx", AppDomain.CurrentDomain.BaseDirectory);
                //DevExpress.XtraPrinting.XlsxExportOptions xOptions = new DevExpress.XtraPrinting.XlsxExportOptions();
                //this.gridControl1.ExportToXlsx("생산일보(배합).xlsx", xOptions);
                IWorkbook workbook = spreadsheetControl1.Document;
                this.spreadsheetControl1.LoadDocument("text.xls", DocumentFormat.Xls);
                //spreadsheetControl1.LoadDocument("생산일보(배합).xlsx");
                //Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];
                workbook.Worksheets.ActiveWorksheet = workbook.Worksheets["general"];
                //workbook.Worksheets.ActiveWorksheet = workbook.Worksheets["Sheet2"];
                //this.spreadsheetControl1.ShowPrintPreview();

                //// Header 정보
                //string _str = "";
                //int _index = 0;
                //for (int x = 65; x < 65 + 5; x++)
                //{
                //    _str = Convert.ToChar(x) + "1";
                //    worksheet.Cells[_str].Value = "a";
                //    worksheet.Cells[_str].ColumnWidth = 200;
                //    _index += 1;
                //}

                //XtraReport1 report = new XtraReport1();
                //DevExpress.XtraReports.Parameters.Parameter p = new DevExpress.XtraReports.Parameters.Parameter();
                //p.Visible = true;
                //report.CreateDocument();
                //XtraReport1 report = new XtraReport1();
                //XtraUserControl1 frm = new XtraUserControl1();
                //frm.ShowDialog();

            }
        }
    }
}
