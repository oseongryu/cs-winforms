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
using System.IO;

namespace F5074.DevExpressWinforms.MyForm.B_SpreadsheetControl
{
    public partial class MySpreadsheetControl04 : UserControl
    {
        private string filePath = string.Empty;
        public MySpreadsheetControl04()
        {
            InitializeComponent();
#if DEBUG
            this.spreadsheetControl1.LoadDocument("b.xlsx", DocumentFormat.Xlsx);
#else
            filePath = string.Format("{0}Data\\b.xlsx", AppDomain.CurrentDomain.BaseDirectory);
#endif
            MakeWorksheet_Kor();
            MakeWorksheet_Eng();
        }

        private void MakeWorksheet_Kor()
        {
            spreadsheetControl1.BeginUpdate();
            //this.spreadsheetControl1.Document.Worksheets[0].Pictures.AddPicture("C:\\Users\\itcomm\\Desktop\\stamp.png", spreadsheetControl1.Document.Worksheets[0].Range["L47:N50"]);
            //this.spreadsheetControl1.Document.Worksheets[0].Pictures.AddPicture("C:\\Users\\itcomm\\Desktop\\stamp.png", spreadsheetControl1.Document.Worksheets[0].Range["O47:Q50"]);
            //this.spreadsheetControl1.Document.Worksheets[0].Pictures.AddPicture("C:\\Users\\itcomm\\Desktop\\accepted_modify.png", spreadsheetControl1.Document.Worksheets[0].Range["L41:Q45"]);


            spreadsheetControl1.Document.Worksheets[0].Cells["L2"].Value = "작성일 : 2019. 04. 29";
            spreadsheetControl1.Document.Worksheets[0].Cells["L5"].Value = "고객명";
            spreadsheetControl1.Document.Worksheets[0].Cells["L6"].Value = "로트번호";
            spreadsheetControl1.Document.Worksheets[0].Cells["L7"].Value = "품명";
            spreadsheetControl1.Document.Worksheets[0].Cells["L8"].Value = "재종";
            spreadsheetControl1.Document.Worksheets[0].Cells["L9"].Value = "형번";
            spreadsheetControl1.Document.Worksheets[0].Cells["L10"].Value = "검사수";
            spreadsheetControl1.Document.Worksheets[0].Cells["L11"].Value = "검사원";
            for (int x = 0; x < 4; x++)
            {

                int cellVal = 14 + x;

                if (x % 2 == 0)
                {
                    spreadsheetControl1.Document.Worksheets[0].Cells[cellVal, 1].Value = "검사항목";
                    spreadsheetControl1.Document.Worksheets[0].Cells[cellVal, 3].Value = "검사기준";
                    spreadsheetControl1.Document.Worksheets[0].Cells[cellVal + 1, 3].Value = "검사기준2";

                    spreadsheetControl1.Document.Worksheets[0].Cells[cellVal, 3].Value = "검사기준";
                    spreadsheetControl1.Document.Worksheets[0].Cells[cellVal + 1, 3].Value = "검사기준2";

                    spreadsheetControl1.Document.Worksheets[0].Cells[cellVal, 5].Value = "x1";
                    spreadsheetControl1.Document.Worksheets[0].Cells[cellVal + 1, 5].Value = "x1";

                    spreadsheetControl1.Document.Worksheets[0].Cells[cellVal, 6].Value = "x2";
                    spreadsheetControl1.Document.Worksheets[0].Cells[cellVal + 1, 6].Value = "x2";

                    spreadsheetControl1.Document.Worksheets[0].Cells[cellVal, 7].Value = "x3";
                    spreadsheetControl1.Document.Worksheets[0].Cells[cellVal + 1, 7].Value = "x3";
                }

            }
            spreadsheetControl1.EndUpdate();
        }

        private void MakeWorksheet_Eng()
        {
            // https://www.devexpress.com/Support/Center/Question/Details/Q580543/spreadsheet-setting-values-by-code-is-slow
            //https://www.devexpress.com/Support/Center/Question/Details/Q578955/set-value-for-a-large-number-of-cells-efficient
            spreadsheetControl1.BeginUpdate();
            //spreadsheetControl1.Document.Worksheets[1].Pictures.AddPicture("C:\\Users\\itcomm\\Desktop\\stamp.png", spreadsheetControl1.Document.Worksheets[1].Range["I46:I50"]);
            //spreadsheetControl1.Document.Worksheets[1].Pictures.AddPicture("C:\\Users\\itcomm\\Desktop\\stamp.png", spreadsheetControl1.Document.Worksheets[1].Range["J46:J50"]);

            //spreadsheetControl1.Document.Worksheets[1].Pictures.AddPicture("C:\\Users\\itcomm\\Desktop\\rejected_modify.png", spreadsheetControl1.Document.Worksheets[1].Range["I40:J44"]);

            spreadsheetControl1.Document.Worksheets[1].Cells["I2"].Value = "작성일 : 2019. 04. 29";
            spreadsheetControl1.Document.Worksheets[1].Cells["H5"].Value = "고객명";
            spreadsheetControl1.Document.Worksheets[1].Cells["H6"].Value = "로트번호";
            spreadsheetControl1.Document.Worksheets[1].Cells["H7"].Value = "품명";
            spreadsheetControl1.Document.Worksheets[1].Cells["H8"].Value = "재종";
            spreadsheetControl1.Document.Worksheets[1].Cells["H9"].Value = "형번";
            spreadsheetControl1.Document.Worksheets[1].Cells["H10"].Value = "검사수";
            spreadsheetControl1.Document.Worksheets[1].Cells["H11"].Value = "검사원";
            for (int x = 0; x < 4; x++)
            {

                int cellVal = 13 + x;

                if (cellVal % 2 == 1)
                {
                    spreadsheetControl1.Document.Worksheets[1].Cells[cellVal, 1].Value = "검사항목";
                    spreadsheetControl1.Document.Worksheets[1].Cells[cellVal, 3].Value = "검사기준";
                    spreadsheetControl1.Document.Worksheets[1].Cells[cellVal + 1, 3].Value = "검사기준2";

                    spreadsheetControl1.Document.Worksheets[1].Cells[cellVal, 3].Value = "검사기준";
                    spreadsheetControl1.Document.Worksheets[1].Cells[cellVal + 1, 3].Value = "검사기준2";

                    spreadsheetControl1.Document.Worksheets[1].Cells[cellVal, 5].Value = "x1";
                    spreadsheetControl1.Document.Worksheets[1].Cells[cellVal + 1, 5].Value = "x1";

                    spreadsheetControl1.Document.Worksheets[1].Cells[cellVal, 6].Value = "x2";
                    spreadsheetControl1.Document.Worksheets[1].Cells[cellVal + 1, 6].Value = "x2";

                    spreadsheetControl1.Document.Worksheets[1].Cells[cellVal, 7].Value = "x3";
                    spreadsheetControl1.Document.Worksheets[1].Cells[cellVal + 1, 7].Value = "x3";
                }

            }
            spreadsheetControl1.EndUpdate();
        }
    }
}
