using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;

namespace F5074.DevExpressWinforms.MyForm.A_GridControl
{
    public partial class MyGridControl04 : UserControl
    {
        private DataTable _dtOrderList = new DataTable();

        public MyGridControl04()
        {
            InitializeComponent();
            this.init();
        }

        void init()
        {
            RepositoryItemCheckEdit repositoryItemCheckEdit = new RepositoryItemCheckEdit();
            repositoryItemCheckEdit.ValueChecked = true;
            repositoryItemCheckEdit.ValueUnchecked = false;
            //repositoryItemCheckEdit.ValueGrayed = "False";
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Checked", Caption = "Checked", Visible = true, ColumnEdit = repositoryItemCheckEdit });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Count", Caption = "Count", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Name", Caption = "Name", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Age", Caption = "Age", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Spec", Caption = "Spec", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Spec2", Caption = "Spec2", Visible = true });


            this.gridView1.OptionsBehavior.Editable = true;
            this.gridView1.Columns["Checked"].OptionsColumn.AllowEdit = true;
            this.gridView1.Columns["Count"].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns["Name"].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns["Name"].Visible = false;

            this.gridView1.Columns["Age"].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns["Age"].Visible = false;

            this.simpleButton1.Click += SimpleButton1_Click;
            this.gridControl1.DataSource = CreateTable(7);
            this.gridView1.RowCellStyle += GridView1_RowCellStyle;

        }

        private void GridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {

            //try
            //{
            //    GridView oCurrentView = sender as GridView;

            //    string focusedColumnFieldName = string.Empty;
            //    if (oCurrentView.FocusedColumn != null)
            //    {
            //        focusedColumnFieldName = oCurrentView.FocusedColumn.FieldName;
            //    }

            //    if (e.RowHandle == oCurrentView.FocusedRowHandle)
            //    {
            //        e.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            //        e.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


            //if (e.RowHandle > 0 && e.Column.AbsoluteIndex == (int)DbColumnIndexRight.QTY)
            //{
            //    e.Appearance.ForeColor = Color.Black;
            //    e.Appearance.BackColor = Color.Yellow;
            //}


            //if (e.CellValue.ToString() != null && !string.IsNullOrWhiteSpace(e.CellValue.ToString()))
            //{
            //    e.Appearance.ForeColor = Color.Black;
            //    e.Appearance.BackColor = Color.White;
            //}


        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            //this.gridControl1.DataSource = CreateTable(7);

            //string a = "NAME_BC".Split('_')[0];
            //MessageBox.Show(a);
            DataRow focusedRow = this.gridView1.GetDataRow(this.gridView1.FocusedRowHandle);
            //_dtOrderList = new DataTable();
            _dtOrderList = gridControl1.DataSource as DataTable;
            DataTable dt = _dtOrderList.Clone();
            DataRow row = dt.NewRow();
            row.ItemArray = focusedRow.ItemArray;
            dt.Rows.Add(row);
            this.gridControl2.DataSource = dt;

        }

        // 테이블데이터생성
        private DataTable CreateTable(int RowCount)
        {
            Random rnd = new Random();
            DataTable tbl = new DataTable();

            tbl.Columns.Add("Checked", typeof(bool));
            tbl.Columns.Add("Count", typeof(int));
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("Age", typeof(int));
            tbl.Columns.Add("Spec", typeof(string));
            tbl.Columns.Add("Spec2", typeof(string));

            for (int i = 0; i < RowCount; i++)
                if (i % 2 == 1)
                {
                    tbl.Rows.Add(new object[] { true, i, "kim", (10 + i), "Y", "N" });
                }
                else
                {
                    tbl.Rows.Add(new object[] { false, i, "kim", (10 + i), "N", "Y" });
                }
            return tbl;
        }
    }
}
