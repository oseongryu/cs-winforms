using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraGrid.Views.Grid;

namespace F5074.DevExpressWinforms.TabFolder
{
    public partial class Tab1 : Form
    {
        public Tab1()
        {
            InitializeComponent();
            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riteTextEditColumn = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();

            riteTextEditColumn.Mask.EditMask = "####-##-##"; // 0000-00-00
            riteTextEditColumn.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            //riteTextEditColumn.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            riteTextEditColumn.Mask.UseMaskAsDisplayFormat = true;
            riteTextEditColumn.BeforePopup += riteTextEditColumn_BeforePopup;



            this.gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "DateString", Caption = "DateString", Visible = true, ColumnEdit = riteTextEditColumn });
            this.gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            gridControl1.DataSource = CreateTable(50);


            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tab1));
            //windowsUIButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions1.Image")));
            windowsUIButtonImageOptions1.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("grayscale/actions/add_32x32.png");
            WindowsUIButton btn1 = new WindowsUIButton("Btn1", true, windowsUIButtonImageOptions1);
            WindowsUIButton btn2 = new WindowsUIButton("Btn2", true, windowsUIButtonImageOptions1);
            
            //this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            //new DevExpress.XtraBars.Docking2010.WindowsUIButton("Btn1", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton),
            //new DevExpress.XtraBars.Docking2010.WindowsUIButton("Btn2", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)});

            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {btn1,btn2});

        }

        void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gvCurrentView = sender as GridView;
            DataRow drFocusedRow = this.gridView1.GetDataRow(e.FocusedRowHandle);
            //MessageBox.Show(drFocusedRow["DateString"].ToString());
            this.textEdit1.EditValue = drFocusedRow["DateString"].ToString();
        }

        void riteTextEditColumn_BeforePopup(object sender, EventArgs e)
        {
            try
            {
                var dateEdit = sender as DevExpress.XtraEditors.DateEdit;

                if (dateEdit == null)
                    return;

                DateTime b = Convert.ToDateTime(dateEdit.Text);
                dateEdit.DateTime = b;
            }
            catch (Exception ex)
            { }
        }

        private DataTable CreateTable(int RowCount)
        {
            Random rnd = new Random();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            tbl.Columns.Add("DateString", typeof(string));
            //tbl.Columns.Add("Checked", typeof(bool));
            for (int i = 0; i < RowCount; i++)
                // null 값이 있을 경우 대비하여
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, rnd.Next(500), DateTime.Now.AddDays(rnd.Next(-250, 250)), "20181111" });
            return tbl;
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column != view.Columns["Name"])
                return;
            if (Convert.ToInt32(view.GetRowCellValue(e.RowHandle, view.Columns["Number"])) > 300)
            {
                e.Appearance.BackColor = Color.Red;
            }

        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, ButtonEventArgs e)
        {
                        WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Caption != null && btn.Caption.Equals("Btn1"))
            {
                MessageBox.Show(btn.Caption);
            }
        }
    }
}
