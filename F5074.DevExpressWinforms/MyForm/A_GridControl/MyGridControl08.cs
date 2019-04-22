using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace F5074.DevExpressWinforms.MyForm.A_GridControl
{
    public partial class MyGridControl08 : UserControl
    {
        string description = "그리드 컨트롤 안에 캘린더 팝업이 뜰 수 있도록 구현";
        public MyGridControl08()
        {
            InitializeComponent();
            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riteTextEditColumn = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();

            riteTextEditColumn.Mask.EditMask = "####-##-##"; // 0000-00-00
            riteTextEditColumn.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            //riteTextEditColumn.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            riteTextEditColumn.Mask.UseMaskAsDisplayFormat = true;
            riteTextEditColumn.BeforePopup += riteTextEditColumn_BeforePopup;
            this.gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;

            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "DateString", Caption = "DateString", Visible = true, ColumnEdit = riteTextEditColumn });

            this.gridControl1.DataSource = CreateTable(50);
        }
        void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gvCurrentView = sender as GridView;
            DataRow drFocusedRow = this.gridView1.GetDataRow(e.FocusedRowHandle);
            MessageBox.Show(drFocusedRow["DateString"].ToString());
        }

        void riteTextEditColumn_BeforePopup(object sender, EventArgs e)
        {
            try
            {
                var dateEdit = sender as DevExpress.XtraEditors.DateEdit;

                if (dateEdit == null)
                    return;

                DateTime b = Convert.ToDateTime(dateEdit.Text);
                dateEdit.DateTime = b;
            }
            catch (Exception ex)
            { }
        }

        private DataTable CreateTable(int RowCount)
        {
            Random rnd = new Random();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            tbl.Columns.Add("DateString", typeof(string));
            //tbl.Columns.Add("Checked", typeof(bool));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, rnd.Next(500), DateTime.Now.AddDays(rnd.Next(-250, 250)), "20181111" });
            return tbl;
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column != view.Columns["Name"])
                return;
            if (Convert.ToInt32(view.GetRowCellValue(e.RowHandle, view.Columns["Number"])) > 300)
            {
                e.Appearance.BackColor = Color.Red;
            }
        }
    }
}
