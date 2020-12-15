using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Winforms.MyForm.I_Office {
    public partial class MyExcel01 : UserControl {
        public MyExcel01()
        {
            InitializeComponent();
            Referesh();
        }

        private void Referesh()
        {
            //object TypMissing = Type.Missing;
            //// Excel Application 정의
            //Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel.Workbook _workbook = null;
            //// 파일이 존재 하면 열고, 없으면 새로 만듬.

            //if (File.Exists(@"C:\DEV\abc.xls"))
            //{
            //    _workbook = ExcelApp.Workbooks.Open(@"C:\DEV\abc.xls", TypMissing, TypMissing, TypMissing, TypMissing,
            //        TypMissing, TypMissing,
            //        TypMissing, TypMissing, TypMissing, TypMissing, TypMissing, TypMissing, TypMissing, TypMissing);
            //}
            //else
            //{
            //    // Add Work Book
            //    _workbook = ExcelApp.Workbooks.Add(Type.Missing);
            //    // Save Excel File
            //    _workbook.SaveAs(@"C:\DEV\abc.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, TypMissing, TypMissing,
            //   TypMissing, TypMissing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
            //   TypMissing, TypMissing, TypMissing, TypMissing, TypMissing);
            //}
            //// 읽어들인 Excel에서Sheet1을 가져옴. item 이름이 정확 해야함.
            //Microsoft.Office.Interop.Excel.Worksheet Sheet = (Microsoft.Office.Interop.Excel.Worksheet)_workbook.Worksheets.get_Item("Sheet1");
            //Microsoft.Office.Interop.Excel.Range Range_ = Sheet.get_Range("A1", Type.Missing);
        }
    }
}
