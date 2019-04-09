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
    public partial class MyGridControl02 : UserControl
    {
        public MyGridControl02()
        {
            InitializeComponent();
            init();

        }
        void init()
        {
            //DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            //DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            //DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            //DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            //DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.Name = "repositoryItemButtonEdit1";
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit.ButtonClick += repositoryItemButtonEdit_ButtonClick;
            repositoryItemButtonEdit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            //editorButtonImageOptions1.Image = global::F5074.DevExpressWinforms.Properties.Resources.additem_16x16;
            //editorButtonImageOptions1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            //this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            //new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "조치 대기", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null)});
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Checked", Caption = "Checked", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Count", Caption = "Count", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Name", Caption = "Name", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Age", Caption = "Age", Visible = true });
            //this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Height", Caption = "Height", Visible = true, ColumnEdit = repositoryItemButtonEdit });
            //this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Thick", Caption = "Thick", Visible = true, ColumnEdit = repositoryItemButtonEdit });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Height", Caption = "Height", Visible = true});
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Thick", Caption = "Thick", Visible = true });


            this.gridView1.OptionsBehavior.Editable = true;
            this.gridView1.Columns["Checked"].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns["Count"].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns["Name"].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns["Name"].Visible = false;

            this.gridView1.Columns["Age"].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns["Age"].Visible = false;

            this.gridView1.RowCellStyle += GridView1_RowCellStyle;
            this.gridView1.CustomRowCellEdit += GridView1_CustomRowCellEdit;

            // gridControl 출력
            this.simpleButton1.Click += SimpleButton1_Click;

            //ActivceFilter
            //this.gridView1.ActiveFilterString = "[Age] < 15";
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            //this.gridControl1.ShowPrintPreview();
            this.gridControl1.DataSource = CreateTable(7);

        }

        RepositoryItemButtonEdit emptyEditor;
        private void GridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            //RepositoryItemButtonEdit emptyEditor = new RepositoryItemButtonEdit();
            //emptyEditor.Name = "repositoryItemButtonEdit";
            //emptyEditor.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            //emptyEditor.ButtonClick += repositoryItemButtonEdit_ButtonClick;
            //emptyEditor.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;

            //this.gridView1.OptionsEditForm.BeginUpdate();

            //if (e.Column.FieldName == "Height" && e.CellValue.ToString() == "76")
            //{
            //    // https://www.devexpress.com/Support/Center/Question/Details/A1487/how-to-hide-a-check-box-in-a-grid-cell
            //    // https://www.devexpress.com/Support/Center/Question/Details/T409091/hide-one-cell-in-column-gridview
            //    //e.Column.Visible = false;
            //    e.RepositoryItem = emptyEditor;

            //}
            //this.gridView1.OptionsEditForm.EndUpdate();



            //if (e.Column.FieldName == "Height" && e.CellValue.ToString() == "76")
            //{
            //    RepositoryItemButtonEdit cellButton = (RepositoryItemButtonEdit)e.Column.ColumnEdit;
            //    //cellButton.Buttons[0].Visible = false;
            //    RepositoryItemButtonEdit riB = e.RepositoryItem.Clone() as RepositoryItemButtonEdit;
            //    riB.Buttons[0].Visible = false;

            //}

            //this.gridView1.OptionsEditForm.BeginUpdate();

            //DevExpress.XtraGrid.Columns.GridColumn gc = new DevExpress.XtraGrid.Columns.GridColumn();
            //gc.ColumnEdit = null;

            RepositoryItemButtonEdit emptyEditor = new RepositoryItemButtonEdit();
            emptyEditor.Name = "repositoryItemButtonEdit";
            emptyEditor.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            emptyEditor.ButtonClick += repositoryItemButtonEdit_ButtonClick;
            emptyEditor.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //emptyEditor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "조치이상", -1, true, true, false, null) });
            emptyEditor.Buttons[0].Caption = "조치대기";
            emptyEditor.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;

            if (e.Column.FieldName == "Height" && e.CellValue.ToString() == "72")
            {
                // https://www.devexpress.com/Support/Center/Question/Details/A1487/how-to-hide-a-check-box-in-a-grid-cell
                // https://www.devexpress.com/Support/Center/Question/Details/T409091/hide-one-cell-in-column-gridview
                //e.Column.Visible = false;
                e.RepositoryItem = emptyEditor;
                //e.RepositoryItem = null;

            }

            //this.gridView1.OptionsEditForm.EndUpdate();
            //if (e.Column.FieldName == "Height" && e.CellValue.ToString() == "76")
            //{
            //    RepositoryItemButtonEdit cellButton = (RepositoryItemButtonEdit)e.Column.ColumnEdit;
            //    //cellButton.Buttons[0].Visible = false;
            //    RepositoryItemButtonEdit riB = e.RepositoryItem.Clone() as RepositoryItemButtonEdit;
            //    riB.Buttons[0].Visible = false;

            //}


        }

        private void GridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //GridView oCurrentView = sender as GridView;

            //string sCellValue = e.CellValue.ToString(); 
            //DataRow selectRow = gridView1.GetDataRow(e.RowHandle);

            //string focusedColumnFieldName = string.Empty;
            //if (oCurrentView.FocusedColumn != null) focusedColumnFieldName = oCurrentView.FocusedColumn.FieldName;





            //this.gridView1.Columns[2].Visible = false;


            ////전체 컬럼이 숨겨짐
            //if(oCurrentView.FocusedColumn.FieldName == "Age")
            //{
            //    oCurrentView.FocusedColumn.Visible = false;
            //}


            //e.Appearance.BackColor = Color.DeepSkyBlue;
            //if (e.Column.FieldName == "Age")
            //{
            //    e.Column.Visible = false;
            //}

        }

        void repositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ////this.gridView1.OptionsEditForm.BeginUpdate();

            DevExpress.XtraEditors.Controls.EditorButton temp = (DevExpress.XtraEditors.Controls.EditorButton)e.Button;
            //temp.Visible = false;
            System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            string cellValue = gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Height").ToString();
            MessageBox.Show(cellValue);
            ////this.gridView1.OptionsEditForm.EndUpdate();
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
            tbl.Columns.Add("Thick", typeof(int));

            //tbl.Columns.Add("Checked", typeof(bool));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { "False", i, "kim", (10 + i), (70 + i), (10 + i) });
            return tbl;
        }
        #endregion
    }
}
