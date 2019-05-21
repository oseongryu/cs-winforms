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
using F5074.DevExpressWinforms.MyDialog;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace F5074.DevExpressWinforms.MyUserControl
{
    public partial class MyUserControl02 : UserControl
    {
        public string eqpId = "";
        public string eqpDesc = "";
        public string workCenter = "";
        public string prodOrderNumber = "";
        string backColor = "";
        enum DbColumnIndex
        {
            DUE_DATE,
            PROD_ORDER_NUMBER,
            PART_NUMBER,
            PROCESS_SEQ
        }

        string[] oHeaderText =
        {
             "완료예정일"
            ,"생산오더번호"
            ,"형번"
            , "생산순서"
        };
        int[] HeaderWidth = { 40, 50, 40, 50 };
        public MyUserControl02()
        {
            InitializeComponent();
        }

        private void GridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView testView = gridView1 as GridView;
                //MessageBox.Show(testView.FocusedRowHandle.ToString());
                //this.gridControl1.DataSource = new MyDatabaseConnect01().connection8(test.eqpNumber, "");
                //DataRow drFocusedRow = testView.GetDataRow(testView.FocusedRowHandle);

                if (testView.SelectedRowsCount <= 0) return;
                //MyDialog01 dialog = new MyDialog01(eqpId, testView.GetRowCellValue(testView.FocusedRowHandle, "PROCESS_SEQ").ToString(), testView.GetRowCellValue(testView.FocusedRowHandle, "PROD_ORDER_NUMBER").ToString());
                //dialog.Show();

                FlyoutProperties properties = new FlyoutProperties();
                properties.ButtonSize = new Size(100, 10);
                properties.Style = FlyoutStyle.Popup;
                FlyoutDialog.Show(this.FindForm(), "", new MyDialog01(eqpId, testView.GetRowCellValue(testView.FocusedRowHandle, "PROCESS_SEQ").ToString(), testView.GetRowCellValue(testView.FocusedRowHandle, "PROD_ORDER_NUMBER").ToString()), properties, 0, 0);
                //FlyoutDialog.Show(this.FindForm(), new MyButtonEdit01());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

            if (backColor == "Run") e.Appearance.BackColor = Color.Green;
            else if (backColor == "Idle" || backColor == "Ready") e.Appearance.BackColor = Color.Gray;
            else if (backColor == "Down") e.Appearance.BackColor = Color.Red;
            else if (backColor == "Setup") e.Appearance.BackColor = Color.Blue;
        }

        public MyUserControl02(string _eqpDesc, string _eqpId, string _workCenter, string _state)
        {
            InitializeComponent();
            try
            {
                this.gridControl1.DoubleClick += GridControl1_DoubleClick;
                //this.gridControl1.Click += GridControl1_Click;
                //this.gridView1.RowCellStyle += GridView1_RowCellStyle;
                this.labelControl1.Text = _eqpDesc;
                this.labelControl2.Text = _eqpId;
                eqpDesc = _eqpDesc;
                eqpId = _eqpId;
                workCenter = _workCenter;
                backColor = _state;
                MyDevExpressFunctions.InitGridControl(this.gridView1, 1);

                int iColumnCount = oHeaderText.Length;

                DevExpress.XtraGrid.Columns.GridColumn[] cCols = new DevExpress.XtraGrid.Columns.GridColumn[iColumnCount];
                for (int i = 0; i < iColumnCount; i++)
                {
                    cCols[i] = new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = Enum.GetNames(typeof(DbColumnIndex))[i].ToString(), Name = Enum.GetNames(typeof(DbColumnIndex))[i], Caption = oHeaderText[i], Visible = true, Width = HeaderWidth[i] };
                    if (oHeaderText[i] == "생산순서") cCols[i].Visible = false;

                    this.gridView1.Columns.Add(cCols[i]);
                    MyDevExpressFunctions.SetHeaderAlignmentGridView(this.gridView1, gridView1.Columns.Count - 1);
                    MyDevExpressFunctions.SetCellAlignmentGridView(this.gridView1, gridView1.Columns.Count - 1);
                }
                this.gridControl1.DataSource = new MyDatabaseConnect01().connection7(_eqpId, _workCenter);
                this.labelControl5.Text = "오더수량 : " + gridView1.RowCount.ToString();

                if (_state == "Run") { this.panel1.BackColor = Color.DarkGreen; this.panel2.BackColor = Color.Green; }
                else if (_state == "Idle" || _state == "Ready") { this.panel1.BackColor = Color.DarkGray; this.panel2.BackColor = Color.Gray; }
                else if (_state == "Down") { this.panel1.BackColor = Color.DarkRed; this.panel2.BackColor = Color.Red; }
                else if (_state == "Setup") { this.panel1.BackColor = Color.DarkBlue; this.panel2.BackColor = Color.Blue; ; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void GridControl1_Click(object sender, EventArgs e)
        //{

        //    GridView testView = this.gridView1 as GridView;
        //    ProcessComparenceDialog dialog = new ProcessComparenceDialog(testView.GetRowCellValue(testView.FocusedRowHandle, "PART_NUMBER").ToString());
        //    //dialog.Width = 1300;
        //    //dialog.Height = 350;
        //    dialog.ShowDialog();
        //}

        private void DelegateClickEvent(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, e);
        }
    }
}
