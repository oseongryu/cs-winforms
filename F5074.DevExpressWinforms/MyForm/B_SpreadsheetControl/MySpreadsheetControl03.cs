using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.BarCodes;
using System.IO;

namespace F5074.DevExpressWinforms.MyForm.B_SpreadsheetControl
{
    public partial class MySpreadsheetControl03 : UserControl
    {
        private string filePath = string.Empty;
        public MySpreadsheetControl03()
        {
            InitializeComponent();
#if DEBUG
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            filePath = Path.GetFullPath(Path.Combine(projectDirectory, @"..\\..\\..\\..\\Data\\a.xlsx"));
            this.spreadsheetControl1.LoadDocument("a.xlsx", DocumentFormat.Xlsx);
#else
                filePath = string.Format("{0}Data\\a.xlsx", AppDomain.CurrentDomain.BaseDirectory);
#endif

            MakeWorksheet();
        }

        private void MakeWorksheet()
        {
            BarCode barCode = new BarCode() { Symbology = Symbology.Code128, BackColor = Color.White, ForeColor = Color.Black, RotationAngle = 0, };
            barCode.CodeText = "111111111";
            barCode.CodeBinaryData = Encoding.Default.GetBytes(barCode.CodeText);
            barCode.Options.Code128.ShowCodeText = false;
            barCode.Paddings.Left = 10;
            barCode.Paddings.Right = 10;
            this.spreadsheetControl1.Document.Worksheets[0].Pictures.AddPicture(barCode.BarCodeImage, spreadsheetControl1.Document.Worksheets[0].Range["L2:P2"]);


            spreadsheetControl1.Document.Worksheets[0].Cells["D3"].Value = "가공지시번호";
            spreadsheetControl1.Document.Worksheets[0].Cells["D4"].Value = "재종";

            spreadsheetControl1.Document.Worksheets[0].Cells["I3"].Value = "품명";
            spreadsheetControl1.Document.Worksheets[0].Cells["I4"].Value = "형번";

            spreadsheetControl1.Document.Worksheets[0].Cells["N3"].Value = "고객명";
            spreadsheetControl1.Document.Worksheets[0].Cells["N4"].Value = "품번";

            spreadsheetControl1.Document.Worksheets[0].Cells[11, 1].Value = "공정명";

        }

    }
}
