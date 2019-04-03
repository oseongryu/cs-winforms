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
    public partial class G_GridCheckBoxInCell : UserControl
    {
        public G_GridCheckBoxInCell()
        {
            InitializeComponent();

            // https://www.devexpress.com/Support/Center/Question/Details/T228226/check-edit-in-xtragrid-column
            RepositoryItemCheckEdit repositoryItemCheckEdit = new RepositoryItemCheckEdit();
            repositoryItemCheckEdit.ValueChecked = "True";
            repositoryItemCheckEdit.ValueUnchecked = "False";
            repositoryItemCheckEdit.CheckedChanged += repositoryItemCheckEdit_CheckedChanged;
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Checked", Caption = "Checked", Visible = true, ColumnEdit = repositoryItemCheckEdit });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Count", Caption = "Count", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Name", Caption = "Name", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Age", Caption = "Age", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Height", Caption = "Height", Visible = true });
            //this.gridView1.Columns["Checked"].ColumnEdit = repositoryItemCheckEdit;
            this.gridControl1.DataSource = CreateTable(50);
            //this.gridView1.CellValueChanged += gridView1_CellValueChanged;
            //this.gridView1.DoubleClick += gridView1_DoubleClick;

            this.gridView1.OptionsBehavior.Editable = true;
            this.gridView1.Columns["Checked"].OptionsColumn.AllowEdit = true;
            this.gridView1.Columns["Count"].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns["Name"].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns["Age"].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns["Height"].OptionsColumn.AllowEdit = false;

            this.gridView1.InitNewRow += gridView1_InitNewRow;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False; 

        }

        void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //gridView1.SetRowCellValue(e.RowHandle, "Checked", "True");
            //gridView1.SetRowCellValue(e.RowHandle, "Name", "Yes");
            //gridView1.SetRowCellValue(e.RowHandle, "Age", 50);
            //gridView1.CloseEditor();
            //gridView1.UpdateCurrentRow();


        }

        //void gridView1_DoubleClick(object sender, EventArgs e)
        //{
        //    MessageBox.Show("");

        //}

        private void repositoryItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("c");
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
            tbl.Columns.Add("Count", typeof(int));
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("Age", typeof(int));
            tbl.Columns.Add("Height", typeof(int));



            //tbl.Columns.Add("Checked", typeof(bool));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { "False", i,"kim", (10 + i), (70+i )});
            return tbl;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ////gridView1.AddNewRow();
            //DataRow drSelectRow = gridView1.GetFocusedDataRow();

            ////drSelectRow[DbColumnIndex.EQP_ID.ToString()].ToString();

            //MessageBox.Show(drSelectRow["Age"].ToString());


            // https://www.devexpress.com/Support/Center/Question/Details/Q180961/adding-new-row-at-specific-row-in-a-gridview
            DataTable dt = new DataTable();
            dt = gridControl1.DataSource as DataTable;
            DataRow dtRow = dt.NewRow();

            int pos = gridView1.GetDataSourceRowIndex(gridView1.FocusedRowHandle) + 1;

            dtRow["Checked"] = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Checked").ToString();
            dtRow["Name"] = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Name").ToString();
            dtRow["Age"] = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Age").ToString();
            dt.Rows.InsertAt(dtRow, pos);
            //dt.Rows.Add(dtRow);
            gridView1.FocusedRowHandle = gridView1.GetRowHandle(pos);
            gridControl1.DataSource = dt;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
            //gridView1.DeleteSelectedRows();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DataTable dt = gridControl1.DataSource as DataTable;

            for (int x = 0; x < dt.Rows.Count; x++)
            {
                MessageBox.Show(this.gridView1.GetRowCellValue(x, "Age").ToString());
                
            }




            //DataTable dt = gridControl1.DataSource as DataTable;

            //var selectedItem = dt.AsEnumerable().Where(x => x.Field<string>("Checked") == "True").ToList();
            //if (selectedItem == null || selectedItem.Count() == 0)
            //{
            //    MessageBox.Show("선택된 값이 없습니다.");
            //    return;
            //}
            //else 
            //{
            //    //MessageBox.Show(selectedItem.Count().ToString());
            //}

            //for (int x = 0; x < selectedItem.Count; x++)
            //{
            //    MessageBox.Show(selectedItem[x].ItemArray[3].ToString());
            //}

        }


    }
} 
