using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.DevExpressWinforms.MyCommon;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.Utils;

namespace F5074.DevExpressWinforms.MyForm.A_GridControl
{
    public partial class MyGridControl12 : UserControl
    {
        GridView gridView;
        GridControl gridControl;
        public MyGridControl12()
        {
            InitializeComponent();
            gridView = this.gridView1;
            gridControl = this.gridControl1;
            MyDevExpressFunctions.InitGridControl(this.gridView1, 0);
            gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Checked", Caption = "Checked", Visible = true, Width = 50 });
            gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Count", Caption = "Count", Visible = true, Width = 50 });
            gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Name", Caption = "Name", Visible = true, Width = 50 });
            gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Age", Caption = "Age", Visible = true, Width = 50 });
            gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Height", Caption = "Height", Visible = true, Width = 50 });
            this.gridView1.MouseDown += GridView1_MouseDown;
            this.gridView.FocusedRowChanged += GridView_FocusedRowChanged;

            gridControl.DataSource = CreateTable(10);
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            MessageBox.Show("Test");

        }

        // 그리드 포커스 안에 있을 경우 색깔이 변경되도록
        private void GridView1_MouseDown(object sender, MouseEventArgs e)
        {
            var view = sender as GridView;
            var hi = view.CalcHitInfo(e.Location);

            if (!hi.InRow)
            {
                return;
            }
            ((DXMouseEventArgs)e).Handled = true;
            var rh = hi.RowHandle;
            if (hi.InRowCell)
            {
                // 포커스 변경하도록
                this.gridView1.FocusedRowHandle = hi.RowHandle;
            }
            else
            {

                // 포커스 변경하지 않도록
                this.gridView1.FocusedRowHandle = this.gridView1.FocusedRowHandle;
            }

        }

        private DataTable CreateTable(int RowCount)
        {
            Random rnd = new Random();
            DataTable tbl = new DataTable();

            tbl.Columns.Add("Checked", typeof(string));
            tbl.Columns.Add("Count", typeof(int));
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("Age", typeof(int));
            tbl.Columns.Add("Height", typeof(int));

            //tbl.Columns.Add("Checked", typeof(bool));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { "False", i, "kim", (10 + i), (70 + i) });
            return tbl;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Test");
        }
    }
}
