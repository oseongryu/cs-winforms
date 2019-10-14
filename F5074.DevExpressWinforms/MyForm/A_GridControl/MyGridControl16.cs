using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;

namespace F5074.DevExpressWinforms.MyForm.A_GridControl
{
    public partial class MyGridControl16 : UserControl
    {
        public MyGridControl16()
        {
            InitializeComponent();

            gridControl1.DataSource = CreateTable(20);
            SimpleButton button = new SimpleButton();
            button.Dock = DockStyle.Top;
            button.Text = "Switch size";
            Controls.Add(button);
            button.Click += (s, e) => {
                if (layoutView1.CardMinSize.Height == 300)
                {
                    layoutView1.CardMinSize = new Size(100, 100);
                }
                else
                {
                    layoutView1.CardMinSize = new Size(300, 300);
                }
            };
            GridColumn unbound = layoutView1.Columns.AddVisible("unbound");
            unbound.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            RepositoryItemPictureEdit pictureEdit = new RepositoryItemPictureEdit();
            unbound.ColumnEdit = pictureEdit;
            layoutView1.CustomUnboundColumnData += LayoutView1_CustomUnboundColumnData;
        }

        private void LayoutView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "unbound")
            {
                e.Value = imageCollection1.Images[e.ListSourceRowIndex];
            }
        }

        private DataTable CreateTable(int rowCount)
        {
            Random rnd = new Random();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("String", typeof(string));
            tbl.Columns.Add("Value", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            tbl.Columns.Add("Checked", typeof(bool));
            for (int i = 0; i < rowCount; i++)
                tbl.Rows.Add(new object[] { i, String.Format("Name{0}", i), rnd.Next(10), DateTime.Now.Date.AddDays(rnd.Next(-250, 250)), rnd.Next(2) == 0 });
            return tbl;
        }
    }
}
