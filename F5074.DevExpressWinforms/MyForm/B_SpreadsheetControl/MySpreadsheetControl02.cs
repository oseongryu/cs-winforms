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
using DevExpress.BarCodes;

namespace F5074.DevExpressWinforms.MyForm.B_SpreadsheetControl
{
    public partial class MySpreadsheetControl02 : UserControl
    {
        public MySpreadsheetControl02()
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
                IWorkbook workbook = spreadsheetControl1.Document;
                this.spreadsheetControl1.LoadDocument("text.xlsx", DocumentFormat.Xlsx);
                workbook.Worksheets.ActiveWorksheet = workbook.Worksheets["general"];

                Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];


                //this.spreadsheetControl1.Document.Worksheets[0].Cells[15, 2].Value = "15,2";
                //this.spreadsheetControl1.Document.Worksheets[0].Cells[15, 3].Value = "15,3";
                //this.spreadsheetControl1.Document.Worksheets[0].Cells[7, 2].Value = "7,2";
                //this.spreadsheetControl1.Document.Worksheets[0].Cells[7, 3].Value = "7,3";
                //this.spreadsheetControl1.Document.Worksheets[0].Cells[8, 2].Value = "8,2";
                //this.spreadsheetControl1.Document.Worksheets[0].Cells[8, 3].Value = "8,3";


                //// 20170407 TP 작업지시는 배치번호로 변경
                this.spreadsheetControl1.Document.Worksheets[1].Cells[10, 5].Value = "10,5";// 15 -> 10
                this.spreadsheetControl1.Document.Worksheets[1].Cells[10, 10].Value = "10,10";
                this.spreadsheetControl1.Document.Worksheets[1].Cells[5, 5].Value = "5,5";
                this.spreadsheetControl1.Document.Worksheets[1].Cells[5, 10].Value = " 5,10";// 7--> 5
                this.spreadsheetControl1.Document.Worksheets[1].Cells[6, 5].Value = "6,5";// 8 --> 6
                this.spreadsheetControl1.Document.Worksheets[1].Cells[6, 10].Value = "6,10";


                this.spreadsheetControl1.Document.Worksheets[1].Cells[31, 3].Value = "31,3";            // 연결생산오더 // 37 + 4 ==> 31
                this.spreadsheetControl1.Document.Worksheets[1].Cells[31, 11].Value = "31,11";           // 연결생산오더
                this.spreadsheetControl1.Document.Worksheets[1].Cells[32, 5].Value = "32,5";    // 완분작지번호 // 37 + 5 ==> 
                this.spreadsheetControl1.Document.Worksheets[1].Cells[32, 13].Value = "32,13";   // 완분작지번호


                this.spreadsheetControl1.Document.Worksheets[1].Cells[33, 5].Value = "33,5";
                this.spreadsheetControl1.Document.Worksheets[1].Cells[33, 13].Value = "33,13";

                this.spreadsheetControl1.Document.Worksheets[1].Cells[33, 2].Value = "33,2";
                this.spreadsheetControl1.Document.Worksheets[1].Cells[33, 10].Value = "33,10";



                // https://documentation.devexpress.com/OfficeFileAPI/12092/Spreadsheet-Document-API/Examples/Cells/How-to-Access-a-Cell-in-a-Worksheet
                spreadsheetControl1.Document.Worksheets[0].Cells[14, 2].Value = "100";
                spreadsheetControl1.Document.Worksheets[1].Cells[9, 5].Value = "100";
                spreadsheetControl1.Document.Worksheets[1].Cells[4, 5].Value = DateTime.Now.ToString("yyyy-MM-dd");


                this.spreadsheetControl1.Document.Worksheets[0].Cells[4, 2].Value = DateTime.Now.ToString("yyyy-MM-dd");
                this.spreadsheetControl1.Document.Worksheets[0].Cells[4, 3].Value = string.Format("( {0} / {1} )", "eeee", "eeeee");

                this.spreadsheetControl1.Document.Worksheets[1].Cells[4, 5].Value = DateTime.Now.ToString("yyyy-MM-dd");
                this.spreadsheetControl1.Document.Worksheets[1].Cells[4, 10].Value = string.Format("( {0} / {1} )", "eeee", "eeee");


                //this.pictureBox1.Image = null;
                BarCode barCode = new BarCode() { Symbology = Symbology.Code128, BackColor = Color.White, ForeColor = Color.Black, RotationAngle = 0, };
                //barCode.Symbology = Symbology.Code128;
                //barCode.BackColor = Color.White;
                //barCode.ForeColor = Color.Black;
                //barCode.RotationAngle = 0;
                barCode.CodeText = "DBE2006S-060-V0.9N6S4";
                barCode.CodeBinaryData = Encoding.Default.GetBytes(barCode.CodeText);
                barCode.Options.Code128.ShowCodeText = false;
                barCode.Paddings.Left = 10;
                barCode.Paddings.Right = 10;

                //barCode.DpiX = 72;
                //barCode.DpiY = 72;

                // https://www.devexpress.com/Support/Center/Question/Details/T600305/save-images-to-excel-sheet-new-and-existing-excel-sheet
                //this.spreadsheetControl1.Document.Worksheets[1].Cells[4, 10].Value = barCode.BarCodeImage;
                //this.spreadsheetControl1.Document.Worksheets[0].Pictures.AddPicture(barCode.BarCodeImage, workbook.Worksheets[0].Cells["B1"]);
                this.spreadsheetControl1.Document.Worksheets[0].Pictures.AddPicture(barCode.BarCodeImage, workbook.Worksheets[0].Range["D9"]);
                this.spreadsheetControl1.Document.Worksheets[0].Pictures.AddPicture(barCode.BarCodeImage, workbook.Worksheets[0].Range["D10"]);
                this.spreadsheetControl1.Document.Worksheets[0].Pictures.AddPicture(barCode.BarCodeImage, workbook.Worksheets[0].Range["D12"]);
                this.spreadsheetControl1.Document.Worksheets[0].Pictures.AddPicture(barCode.BarCodeImage, workbook.Worksheets[0].Range["C14:D14"]);
                this.spreadsheetControl1.Document.Worksheets[0].Pictures.AddPicture(barCode.BarCodeImage, workbook.Worksheets[0].Range["D16"]);


            }
            else
            {
                //// https://documentation.devexpress.com/OfficeFileAPI/15114/Barcode-Generation-API/Getting-Started
                //this.pictureBox1.Image = null;
                //BarCode barCode = new BarCode();
                //barCode.Symbology = Symbology.Code128;
                //barCode.CodeText = "http://www.devexpress.com";
                //barCode.BackColor = Color.White;
                //barCode.ForeColor = Color.Black;
                //barCode.RotationAngle = 0;
                //barCode.CodeBinaryData = Encoding.Default.GetBytes(barCode.CodeText);
                //barCode.Options.QRCode.CompactionMode = QRCodeCompactionMode.Byte;
                //barCode.Options.QRCode.ErrorLevel = QRCodeErrorLevel.Q;
                //barCode.Options.QRCode.ShowCodeText = false;
                //barCode.DpiX = 72;
                //barCode.DpiY = 72;
                //this.pictureBox1.Image = barCode.BarCodeImage;
                //pictureBox1.Size = pictureBox1.Image.Size;
            }

        }
    }
}
