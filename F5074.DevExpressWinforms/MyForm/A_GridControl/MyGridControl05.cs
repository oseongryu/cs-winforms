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
using DevExpress.XtraGrid;

namespace F5074.DevExpressWinforms.MyForm.A_GridControl
{
    public partial class MyGridControl05 : UserControl
    {
        public MyGridControl05()
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
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "VOOS_OCCUR", Caption = "VOOS_OCCUR", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "VOOC_OCCUR", Caption = "VOOC_OCCUR", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "XOOS_OCCUR", Caption = "XOOS_OCCUR", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "XOOC_OCCUR", Caption = "XOOC_OCCUR", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "ROOC_OCCUR", Caption = "ROOC_OCCUR", Visible = true });

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
            this.gridView1.CustomRowCellEdit += GridView1_CustomRowCellEdit;
            this.gridView1.ShowingEditor += GridView1_ShowingEditor;

        }

        private void GridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView grid = sender as GridView;
            if(grid.FocusedColumn.ToString() == "VOOS_OCCUR" && grid.FocusedValue == "N") e.Cancel = true;
            if(grid.FocusedColumn.ToString() == "VOOC_OCCUR" && grid.FocusedValue == "N") e.Cancel = true;
            if(grid.FocusedColumn.ToString() == "XOOS_OCCUR" && grid.FocusedValue == "N") e.Cancel = true;
            if(grid.FocusedColumn.ToString() == "XOOC_OCCUR" && grid.FocusedValue == "N") e.Cancel = true;
            if(grid.FocusedColumn.ToString() == "ROOC_OCCUR" && grid.FocusedValue == "N") e.Cancel = true;
        }

        private void GridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            RepositoryItemButtonEdit buttonEditor = new RepositoryItemButtonEdit();
            buttonEditor.Name = "repositoryItemButtonEdit";
            buttonEditor.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            //buttonEditor.ButtonClick += repositoryItemButtonEdit1_ButtonClick;
            buttonEditor.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //buttonEditor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "조치이상", -1, true, true, false, null) });
            buttonEditor.Buttons[0].Caption = "조치대기";
            buttonEditor.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            buttonEditor.Buttons[0].Appearance.ForeColor = Color.Red;
            buttonEditor.Buttons[0].Appearance.BackColor = Color.LightGray;
            buttonEditor.Buttons[0].AppearanceHovered.ForeColor = Color.Red;

            if (e.Column.FieldName.Equals("VOOS_OCCUR") && e.CellValue.ToString() == "Y")
            {
                //RepositoryItemButtonEdit cellButton = (RepositoryItemButtonEdit)e.Column.ColumnEdit;
                //cellButton.Buttons[0].Visible = false;
                e.RepositoryItem = buttonEditor;

            }
            else if (e.Column.FieldName.Equals("VOOC_OCCUR") && e.CellValue.ToString() == "Y")
            {
                e.RepositoryItem = buttonEditor;

            }
            else if (e.Column.FieldName.Equals("XOOS_OCCUR") && e.CellValue.ToString() == "Y")
            {
                e.RepositoryItem = buttonEditor;

            }
            else if (e.Column.FieldName.Equals("XOOC_OCCUR") && e.CellValue.ToString() == "Y")
            {
                e.RepositoryItem = buttonEditor;

            }
            else if (e.Column.FieldName.Equals("ROOC_OCCUR") && e.CellValue.ToString() == "Y")
            {
                e.RepositoryItem = buttonEditor;

                //RepositoryItemButtonEdit riB = e.RepositoryItem.Clone() as RepositoryItemButtonEdit;
                //riB.Buttons[0].Visible = false;
            }
        }

        private void GridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName.Equals("VOOS_OCCUR") && e.CellValue.ToString() == "N")
            {
                e.Appearance.BackColor = Color.White;
                e.Appearance.ForeColor = Color.White;
            }
            else if (e.Column.FieldName.Equals("VOOC_OCCUR") && e.CellValue.ToString() == "N")
            {
                e.Appearance.BackColor = Color.White;
                e.Appearance.ForeColor = Color.White;
            }
            else if (e.Column.FieldName.Equals("XOOS_OCCUR") && e.CellValue.ToString() == "N")
            {
                e.Appearance.BackColor = Color.White;
                e.Appearance.ForeColor = Color.White;
            }
            else if (e.Column.FieldName.Equals("XOOC_OCCUR") && e.CellValue.ToString() == "N")
            {
                e.Appearance.BackColor = Color.White;
                e.Appearance.ForeColor = Color.White;
            }
            else if (e.Column.FieldName.Equals("ROOC_OCCUR") && e.CellValue.ToString() == "N")
            {
                e.Appearance.BackColor = Color.White;
                e.Appearance.ForeColor = Color.White;
            }

        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            //this.gridControl1.DataSource = CreateTable(7);


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
            tbl.Columns.Add("VOOS_OCCUR", typeof(string));
            tbl.Columns.Add("VOOC_OCCUR", typeof(string));
            tbl.Columns.Add("XOOS_OCCUR", typeof(string));
            tbl.Columns.Add("XOOC_OCCUR", typeof(string));
            tbl.Columns.Add("ROOC_OCCUR", typeof(string));


            for (int i = 0; i < RowCount; i++)
                if (i % 2 == 1)
                {
                    tbl.Rows.Add(new object[] { true, i, "kim", (10 + i), "Y", "N", "Y","N","Y","Y","N" });
                }
                else
                {
                    tbl.Rows.Add(new object[] { false, i, "kim", (10 + i), "N", "Y", "Y", "N", "Y", "Y", "N" });
                }
            return tbl;
        }
    }
}
