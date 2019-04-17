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
    public partial class MyGridControl06 : UserControl
    {
        public MyGridControl06()
        {
            InitializeComponent();
            this.init();
        }
        private void init()
        {
            RepositoryItemCheckEdit repositoryItemCheckEdit = new RepositoryItemCheckEdit();
            repositoryItemCheckEdit.ValueChecked = true;
            repositoryItemCheckEdit.ValueUnchecked = false;
            //repositoryItemCheckEdit.ValueGrayed = "False";

            // https://documentation.devexpress.com/WindowsForms/1498/Controls-and-Libraries/Editors-and-Simple-Controls/Simple-Editors/Editors-Features/Mask-Editors-Overview/Mask-Type-Numeric#custom
            RepositoryItemTextEdit riteTextEditColumn = new RepositoryItemTextEdit();
            riteTextEditColumn.Mask.EditMask = "n3";
            //riteTextEditColumn.Mask.EditMask = "0.0000";
            riteTextEditColumn.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            riteTextEditColumn.Mask.UseMaskAsDisplayFormat = true;
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Count", Caption = "Count", Visible = true, ColumnEdit = riteTextEditColumn });


            RepositoryItemTextEdit riteTextEditColumn2 = new RepositoryItemTextEdit();
            riteTextEditColumn2.Mask.EditMask = "#.#####";
            riteTextEditColumn2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            riteTextEditColumn2.Mask.UseMaskAsDisplayFormat = true;


            DevExpress.XtraGrid.Columns.GridColumn  column = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Checked", Caption = "Checked", Visible = true, ColumnEdit = repositoryItemCheckEdit });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Count", Caption = "Count", Visible = true, ColumnEdit = riteTextEditColumn });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Name", Caption = "Name", Visible = true, ColumnEdit = riteTextEditColumn2 });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Age", Caption = "Age", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Spec", Caption = "Spec", Visible = true });
            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Spec2", Caption = "Spec2", Visible = true });


            this.gridView1.OptionsBehavior.Editable = true;
            this.gridView1.Columns["Checked"].OptionsColumn.AllowEdit = true;
            this.gridView1.Columns["Count"].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns["Name"].OptionsColumn.AllowEdit = false;
            //this.gridView1.Columns["Name"].Visible = false;

            this.gridView1.Columns["Age"].OptionsColumn.AllowEdit = false;
            //this.gridView1.Columns["Age"].Visible = false;

            this.simpleButton1.Click += SimpleButton1_Click;
            this.gridControl1.DataSource = CreateTable(7);

        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            //System.Data.DataRow focusedRow = this.gridView1.GetDataRow(this.gridView1.FocusedRowHandle);
            groupControl2.Enabled = false;
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
