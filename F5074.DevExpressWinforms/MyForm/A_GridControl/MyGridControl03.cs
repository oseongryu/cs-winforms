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
    public partial class MyGridControl03 : UserControl
    {
        public MyGridControl03()
        {
            InitializeComponent();
            init();
        }
        void init()
        {
            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.Name = "repositoryItemButtonEdit1";
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit.ButtonClick += repositoryItemButtonEdit_ButtonClick;
            repositoryItemButtonEdit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Checked", Caption = "Checked", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Count", Caption = "Count", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Name", Caption = "Name", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Age", Caption = "Age", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Spec", Caption = "Spec", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Spec2", Caption = "Spec2", Visible = true });


            this.gridView1.OptionsBehavior.Editable = true;
            this.gridView1.Columns["Checked"].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns["Count"].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns["Name"].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns["Name"].Visible = false;

            this.gridView1.Columns["Age"].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns["Age"].Visible = false;

            this.gridView1.CustomRowCellEdit += GridView1_CustomRowCellEdit;
            this.gridView1.RowCellStyle += GridView1_RowCellStyle;

            this.simpleButton1.Click += SimpleButton1_Click;
            this.gridControl1.DataSource = CreateTable(50);

        }

        private void GridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "Spec" && e.CellValue.ToString() == "N")
            {
                //string prodCode = gridListView.GetRowCellValue(e.RowHandle, "PRODUCT.PROD_CD").ToString();
                e.Appearance.BackColor = Color.White;
                e.Appearance.ForeColor = Color.White;
                //e.Column.OptionsColumn.AllowEdit = false;
            }
            else if(e.Column.FieldName == "Spec" && e.CellValue.ToString() == "Y"){
                e.Column.OptionsColumn.AllowEdit = true;
            }


            if (e.Column.FieldName == "Spec2" && e.CellValue.ToString() == "N")
            {
                //e.RepositoryItem = emptyEditor;
                e.Appearance.BackColor = Color.White;
                e.Appearance.ForeColor = Color.White;
                e.Column.OptionsColumn.AllowEdit = false;

            }
            else if (e.Column.FieldName == "Spec2" && e.CellValue.ToString() == "Y")
            {
                e.Column.OptionsColumn.AllowEdit = true;
            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            //this.gridControl1.DataSource = CreateTable(7);

            string a = "NAME_BC".Split('_')[0];
            MessageBox.Show(a);

        }

        RepositoryItemButtonEdit emptyEditor;
        private void GridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            
            RepositoryItemButtonEdit visibleEditor = new RepositoryItemButtonEdit();
            visibleEditor.Name = "repositoryItemButtonEdit";
            visibleEditor.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            visibleEditor.ButtonClick += repositoryItemButtonEdit_ButtonClick;
            visibleEditor.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            visibleEditor.Buttons[0].Caption = "조치대기";

            RepositoryItemButtonEdit emptyEditor = new RepositoryItemButtonEdit();
            emptyEditor.Name = "repositoryItemButtonEdit2";
            emptyEditor.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            emptyEditor.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            if (e.Column.FieldName == "Spec" && e.CellValue.ToString() == "Y")
            {
                e.RepositoryItem = visibleEditor;
            }

            if (e.Column.FieldName == "Spec2" && e.CellValue.ToString() == "Y")
            {
                e.RepositoryItem = visibleEditor;
            }


        }

 

        void repositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //MessageBox.Show("");
            DevExpress.XtraEditors.Controls.EditorButton temp = (DevExpress.XtraEditors.Controls.EditorButton)e.Button;
            string b = temp.Caption;
            //System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            //string cellValue = gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Height").ToString();
            //MessageBox.Show(cellValue);

            string editInfo = this.gridView1.GetFocusedRowCellValue(gridView1.Columns[gridView1.FocusedColumn.FieldName]).ToString();
            editInfo = this.gridView1.GetFocusedRowCellDisplayText(gridView1.FocusedColumn.FieldName);
            //editInfo = ((RepositoryItem)gridView1.Columns[gridView1.FocusedColumn.FieldName].ColumnEdit).Name;
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
            tbl.Columns.Add("Spec", typeof(string));
            tbl.Columns.Add("Spec2", typeof(string));

            for (int i = 0; i < RowCount; i++)
                if(i%2 == 1)
                {
                    tbl.Rows.Add(new object[] { "False", i, "kim", (10 + i), "Y" ,"N"});
                }
                else
                {
                    tbl.Rows.Add(new object[] { "False", i, "kim", (10 + i), "N" ,"Y" });
                }
            return tbl;
        }
        #endregion
    }
}
