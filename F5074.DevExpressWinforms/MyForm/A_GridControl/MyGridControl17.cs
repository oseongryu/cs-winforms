using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace F5074.DevExpressWinforms.MyForm.A_GridControl
{
    public partial class MyGridControl17 : UserControl
    {
        public MyGridControl17()
        {
            InitializeComponent();
            GridControl1.DataSource = this.GetTestDataTable();
            attachRepositoryItemButtonEdit.ButtonClick += attachRepositoryItemButtonEdit_ButtonClick;
        }

        private OpenFileDialog attachFileDialog;
        private void attachRepositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            attachFileDialog = new OpenFileDialog();
            attachFileDialog.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg";
            attachFileDialog.RestoreDirectory = true;
            attachFileDialog.FilterIndex = 2;
            attachFileDialog.FileName = string.Empty;
            attachFileDialog.Title = "Attach Image: Select Image File to Attach to this item and Click Open";

            DialogResult result = attachFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (File.Exists(attachFileDialog.FileName))
                {
                    try
                    {
                        Image im = Image.FromFile(attachFileDialog.FileName);
                        byte[] obj = DevExpress.XtraExport.ByteImageConverter.ToByteArray(im, System.Drawing.Imaging.ImageFormat.Jpeg);
                        this.GridView1.SetRowCellValue(this.GridView1.FocusedRowHandle, this.GridView1.Columns["Image"], im);
                    }
                    catch (Exception ex)
                    {
                        string exceptionMessage = ex.Message;
                    }
                }
            }
        }

        private DataTable GetTestDataTable()
        {
            DataTable myDataTable = new DataTable("TestTable");
            DataColumn myDataColumn;
            DataRow myDataRow;

            myDataColumn = new DataColumn();
            myDataColumn.ColumnName = "Id";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.ColumnName = "ParentItem";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.ColumnName = "AnotherColumn";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.ColumnName = "FileSetImageColumn";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn("Image", typeof(Image));
            myDataColumn.ColumnName = "Image";
            myDataTable.Columns.Add(myDataColumn);

            int i;
            for (i = 0; i <= 6; i++)
            {
                myDataRow = myDataTable.NewRow();
                myDataRow["Id"] = i.ToString();
                myDataRow["ParentItem"] = "ParentItem " + i.ToString();
                myDataRow["AnotherColumn"] = Guid.NewGuid();
                myDataTable.Rows.Add(myDataRow);
            }

            return myDataTable;
        }

    }
}
