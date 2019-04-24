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

namespace F5074.DevExpressWinforms.MyForm.A_GridControl
{
    public partial class MyGridControl01 : UserControl
    {
        public MyGridControl01()
        {
            InitializeComponent();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.Name = "repositoryItemButtonEdit";
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
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Height", Caption = "Height", Visible = true, ColumnEdit = repositoryItemButtonEdit });

            this.gridControl1.DataSource = CreateTable(7);
        }
        void repositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //MessageBox.Show("");
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            string cellValue = gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Age").ToString();
            MessageBox.Show(cellValue);
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

        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}
