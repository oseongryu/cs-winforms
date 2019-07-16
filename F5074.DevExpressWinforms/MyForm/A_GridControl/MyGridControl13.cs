using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.DevExpressWinforms.MyCommon;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;

namespace F5074.DevExpressWinforms.MyForm.A_GridControl
{
    public partial class MyGridControl13 : UserControl
    {
        GridView gridView;
        GridControl gridControl;
        public MyGridControl13()
        {
            InitializeComponent();
            gridView = this.gridView1;
            gridControl = this.gridControl1;
            MyDevExpressFunctions.InitGridControl(this.gridView1, 0);
            gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Checked", Caption = "Checked", Visible = true, Width = 100 });
            gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Count", Caption = "Count", Visible = true, Width = 100 });
            gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Name", Caption = "Name", Visible = true, Width = 100 });
            gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Age", Caption = "Age", Visible = true, Width = 100 });
            gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Height", Caption = "Height", Visible = true, Width = 100 });
            gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "Date", Caption = "Date", Visible = true, Width = 200 });
            //this.gridView1.CustomColumnDisplayText += gridView1_CustomColumnDisplayText;
            this.gridView.FocusedRowChanged += GridView_FocusedRowChanged;

            // 정렬
            gridView.Columns["Name"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;


            // 숫자 포맷일 경우
            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            repositoryItemTextEditNumber.Mask.UseMaskAsDisplayFormat = true;
            repositoryItemTextEditNumber.Mask.EditMask = "N0"; //  1,234
            repositoryItemTextEditNumber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            gridView.Columns["Height"].ColumnEdit = repositoryItemTextEditNumber;
            gridView.Columns["Age"].ColumnEdit = repositoryItemTextEditNumber;



            //RepositoryItemDateEdit rDate = new RepositoryItemDateEdit();
            //rDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            //rDate.Mask.UseMaskAsDisplayFormat = true;
            //rDate.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            //rDate.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            //gridView.Columns["Date"].ColumnEdit = rDate;

            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteTextEditColumn = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            riteTextEditColumn.Mask.EditMask = "####-##-## ##:##:##"; // 0000-00-00 00:00:00
            riteTextEditColumn.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            riteTextEditColumn.Mask.UseMaskAsDisplayFormat = true;
            riteTextEditColumn.Mask.IgnoreMaskBlank = true;
            riteTextEditColumn.Mask.ShowPlaceHolders = false;

            riteTextEditColumn.NullText = " ";
            riteTextEditColumn.NullValuePrompt = string.Empty;
            riteTextEditColumn.NullValuePromptShowForEmptyValue = false;
            //riteTextEditColumn.ShowNullValuePromptWhenFocused = false;
            gridView.Columns["Date"].ColumnEdit = riteTextEditColumn;
            this.gridView.CustomColumnDisplayText += gridView1_CustomColumnDisplayText;

            //gridView.Columns["Date"].DisplayFormat.FormatType = FormatType.Custom;
            //gridView.Columns["Date"].DisplayFormat.FormatType = FormatType.Custom;
            //gridView.Columns["Date"].DisplayFormat.FormatString = "{0:####-##-## ##:##:##}";

            //gridView.Columns["Date"].DisplayFormat.FormatString = "{0:####}";
            //gridView.Columns["Date"].DisplayFormat.FormatString = DateTime.ParseExact("{0}", "yyyyMMdd", null).ToString("yyyy-MM-dd");




            gridControl.DataSource = CreateTable(10);
        }

        private void CellCopy()
        {
            gridView = this.gridView1;
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsBehavior.ReadOnly = true;
            //gridView.OptionsCustomization.AllowColumnMoving = false;
            ////this.gvExtenderProdOrderView.OptionsCustomization.AllowColumnResizing = false;
            //gridView.OptionsCustomization.AllowFilter = false;
            //gridView.OptionsView.ShowGroupPanel = false;
            //gridView.OptionsView.ShowAutoFilterRow = false;
            //gridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True; // 컬럼 헤더 두줄 적용위해
            gridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = true;
            gridView.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.PlainText;
            gridView.OptionsClipboard.CopyColumnHeaders = DefaultBoolean.False;
            //gridView.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = false;
            //gridView.OptionsBehavior.EditorShowMode = EditorShowMode.MouseDown;
            //gridView.OptionsBehavior.Editable = false;
            //gridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True; // 컬럼 헤더 두줄 적용위해

            //gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DefaultBoolean.False;
            //gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;
            //gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            gridView.CopyToClipboard();
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            // https://www.devexpress.com/Support/Center/Question/Details/T162738/display-null-for-null-values-in-the-database-in-the-grid-control
            object value = e.Value;
            if (value == null || string.IsNullOrEmpty(value.ToString()) || string.IsNullOrWhiteSpace(value.ToString())) e.DisplayText = null;
        }
        private static bool IsNullValue(object value)
        {
            return value == null || String.IsNullOrEmpty(value.ToString()) || String.IsNullOrWhiteSpace(value.ToString());
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //MessageBox.Show("Test");

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
            tbl.Columns.Add("Date", typeof(string));

            //tbl.Columns.Add("Checked", typeof(bool));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { "False", i, "kim", (1000000 + i), (70000 + i), "20181112 132406000" });
            tbl.Rows.Add(new object[] { "False", 5, "kim", (1000000), (70000), null });
            tbl.Rows.Add(new object[] { "False", 5, "kim", (1000000), (70000), "" });
            tbl.Rows.Add(new object[] { "False", 5, "kim", (1000000), (70000), " " });

            return tbl;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Test");
        }


    }
}
