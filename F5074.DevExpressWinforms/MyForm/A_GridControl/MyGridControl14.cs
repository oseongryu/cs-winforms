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
    public partial class MyGridControl14 : UserControl
    {
        public MyGridControl14()
        {
            InitializeComponent();
            gridControl1.DataSource = GetData(10);
            repositoryItemGridLookUpEdit1.DataSource = GetLookData(10);
        }
        DataTable GetLookData(int rows)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            for (int i = 0; i < rows; i++)
            {
                dt.Rows.Add(i, "Name" + i);
            }
            return dt;
        }
        DataTable GetData(int rows)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Info", typeof(int));
            for (int i = 0; i < rows; i++)
            {
                dt.Rows.Add(i, i);
            }
            return dt;
        }
    }
}
