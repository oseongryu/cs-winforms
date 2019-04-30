using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;

namespace F5074.DevExpressWinforms.MyForm.A_GridControl
{
    public partial class MyGridControl10 : UserControl
    {
        string description = "그리드컨트롤 원클릭으로 셀 선택하기";
        public MyGridControl10()
        {
            InitializeComponent();
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Checked", Caption = "Checked", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Count", Caption = "Count", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Name", Caption = "Name", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Age", Caption = "Age", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Height", Caption = "Height", Visible = true });

            SettingsMultiRow();

            this.gridControl1.DataSource = CreateTable(7);
            this.gridView1.MouseDown += GridView1_MouseDown;
            this.simpleButton1.Click += simpleButton1_Click;
        }
        #region 테이블데이터생성
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
        #endregion

        #region 그리드전용 체크박스 사용
        private void SettingsDefaultCheckBox()
        {
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;

            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True; // 체크박스 전체 선택가능 헤더만들지 여부
            this.gridView1.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;  // 셀밖에 값을 눌러도 체크박스 온오프만 적용됨
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            //https://www.devexpress.com/Support/Center/Question/Details/T354790/return-only-gridmultiselectmode-checkboxrowselect-rows-without-looping
            ColumnView view = gridControl1.MainView as ColumnView;
            int[] selectedRowHandles = view.GetSelectedRows();
            if (selectedRowHandles.Length > 0)
            {
                // Move focus to the first selected row. 
                view.FocusedRowHandle = selectedRowHandles[0];
                for (int i = 0; i < selectedRowHandles.Length; i++)
                    MessageBox.Show(view.GetRowCellDisplayText(selectedRowHandles[i], "Age"));
            }

        }
        #endregion

        #region Grid MultiSelect (Without Ctrl)
        private void SettingsMultiRow()
        {
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;

            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True; // 체크박스 전체 선택가능 헤더만들지 여부
            this.gridView1.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;  // 셀밖에 값을 눌러도 체크박스 온오프만 적용됨
        }

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
            if (view.IsRowSelected(rh))
            {
                view.UnselectRow(rh);
            }
            else
            {
                view.SelectRow(rh);
            }
            this.gridView1.FocusedRowHandle = hi.RowHandle;
        }
        #endregion
    }
}
