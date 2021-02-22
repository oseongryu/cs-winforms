using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.MyForm.A_GridControl
{
    public partial class MyGridControl20 : UserControl
    {
        public MyGridControl20()
        {
            InitializeComponent();
            gridControl1.DataSource = GetData(10);
            gridView1.Columns["ID"].GroupIndex = 0;
            gridView1.Columns["Name"].GroupIndex = 1;
            gridView1.Columns["Info"].GroupIndex = 2;
            this.simpleButton1.Click += SimpleButton1_Click;
            this.gridView1.StartGrouping += GridView1_StartGrouping;
        }

        private void GridView1_StartGrouping(object sender, EventArgs e)
        {
            if (gridView1.GroupedColumns[0] != null
            && (gridView1.GroupedColumns[0].FieldName == "ID"))
            {
                gridView1.ClearGrouping();
                return;
            }

            if (gridView1.GroupedColumns[1] != null)
            {
                String fieldName = gridView1.GroupedColumns[1].FieldName;
                gridView1.ClearGrouping();
                gridView1.Columns[fieldName].GroupIndex = 0;
            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            if (!gridView1.IsGroupRow(gridView1.FocusedRowHandle))
                return;
            int index = gridView1.GetRowLevel(gridView1.FocusedRowHandle);
            string fieldName = gridView1.GroupedColumns[index].FieldName;
            XtraMessageBox.Show(fieldName);

            DataTable dt = GetFilteredData(gridView1).ToTable();

        }

        DataTable GetData(int count)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Info", typeof(string));
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                dt.Rows.Add(i, "Name" + i, r.Next(100), "Info" + i);
            }
            return dt;
        }


        /// <summary>
        /// GetFilteredData
        /// </summary>
        /// <param name="view"></param>
        /// <returns></returns>
        public static DataView GetFilteredData(ColumnView view)
        {
            if (view == null) return null;
            if (view.ActiveFilter == null || !view.ActiveFilterEnabled
                || view.ActiveFilter.Expression == "")
                return view.DataSource as DataView;

            DataTable table = ((DataView)view.DataSource).Table;
            DataView filteredDataView = new DataView(table);
            filteredDataView.RowFilter = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(view.ActiveFilterCriteria);
            return filteredDataView;
        }
    }
}
