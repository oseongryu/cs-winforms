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
using DevExpress.XtraGrid.Views.Base;

namespace F5074.DevExpressWinforms.TabFolder
{
    public partial class H_GridCheckBoxDefault : UserControl
    {
        public H_GridCheckBoxDefault()
        {
            InitializeComponent();
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Checked", Caption = "Checked", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Count", Caption = "Count", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Name", Caption = "Name", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Age", Caption = "Age", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Height", Caption = "Height", Visible = true });


            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;

            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True; // 체크박스 전체 선택가능 헤더만들지 여부
            this.gridView1.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;  // 셀밖에 값을 눌러도 체크박스 온오프만 적용됨
            this.gridControl1.DataSource = CreateTable(7);
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
    }
}
