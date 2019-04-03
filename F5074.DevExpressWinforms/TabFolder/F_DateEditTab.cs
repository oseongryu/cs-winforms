using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.TabFolder
{
    public partial class F_DateEditTab : UserControl
    {
        public F_DateEditTab()
        {
            InitializeComponent();
            // 전기일 From,To
            DateTime dtNow = DateTime.Now;
            DateTime dtFromDate = new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 0, 0, 0);
            DateTime dtToDate = new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 23, 59, 59);
            this.calFromDate.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.calFromDate.Properties.Mask.UseMaskAsDisplayFormat = true;

            this.calToDate.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.calToDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            calFromDate.EditValue = dtFromDate;
            calToDate.EditValue = dtToDate;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime dtFromDt = Convert.ToDateTime(this.calFromDate.EditValue);
            DateTime dtToDt = Convert.ToDateTime(this.calToDate.EditValue);

            string fromDate = dtFromDt.ToString("yyyyMMdd");
            string toDate = dtToDt.ToString("yyyyMMdd");
            //string toDate = dtToDt.ToString("yyyyMMddHHmmss");
            textEdit1.EditValue = fromDate;
            textEdit2.EditValue = toDate;
        }
    }
}
