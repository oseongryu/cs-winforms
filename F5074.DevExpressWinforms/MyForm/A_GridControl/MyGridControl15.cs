using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.MyForm.A_GridControl
{
    public partial class MyGridControl15 : UserControl
    {
        public MyGridControl15()
        {
            InitializeComponent();
            gridControl1.DataSource = GetData();
            this.layoutView1.CustomUnboundColumnData += layoutView1_CustomUnboundColumnData;


        }
        private BindingList<Custom> GetData()
        {
            BindingList<Custom> list = new BindingList<Custom>();
            for (int i = 0; i < 10; i++)
                list.Add(new Custom() { ID = i, Image = imageCollection1.Images[0] });
            return list;
        }

        private void layoutView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = imageCollection1.Images[0];
        }
    }
    public class Custom
    {
        public int ID { get; set; }
        public Image Image { get; set; }
    }
}
