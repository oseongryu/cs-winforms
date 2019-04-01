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

namespace F5074.DevExpressWinforms.TabFolder
{
    public partial class GridCheckBoxInCell : UserControl
    {
        public GridCheckBoxInCell()
        {
            InitializeComponent();

            // https://www.devexpress.com/Support/Center/Question/Details/T228226/check-edit-in-xtragrid-column
            RepositoryItemCheckEdit repositoryItemCheckEdit = new RepositoryItemCheckEdit();
            repositoryItemCheckEdit.ValueChecked = "True";
            repositoryItemCheckEdit.ValueUnchecked = "False";
            repositoryItemCheckEdit.CheckedChanged += repositoryItemCheckEdit_CheckedChanged;
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Checked", Caption = "Checked", Visible = true, ColumnEdit = repositoryItemCheckEdit });
            //this.gridView1.Columns["Checked"].ColumnEdit = repositoryItemCheckEdit;
            this.gridControl1.DataSource = CreateTable(50);
            //this.gridView1.CellValueChanged += gridView1_CellValueChanged;
            this.gridView1.DoubleClick += gridView1_DoubleClick;

        }

        void gridView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("");

        }

        private void repositoryItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("c");
        }

        //void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    MessageBox.Show("");
        //}

        private DataTable CreateTable(int RowCount)

        {
            Random rnd = new Random();
            DataTable tbl = new DataTable();

            tbl.Columns.Add("Checked", typeof(string));



            //tbl.Columns.Add("Checked", typeof(bool));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { "True" });
            return tbl;
        }


    }
}
