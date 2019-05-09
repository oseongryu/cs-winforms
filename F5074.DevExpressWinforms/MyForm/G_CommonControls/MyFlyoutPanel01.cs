using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.MyForm.G_CommonControls
{
    public partial class MyFlyoutPanel01 : UserControl
    {
        public MyFlyoutPanel01()
        {
            InitializeComponent();
            //flyoutPanel1.ShowPopup();
            // https://www.devexpress.com/Support/Center/Question/Details/T333871/flyoutpanel-sample
            //flyoutPanel1.OwnerControl = this.simpleButton1;

            this.flyoutPanel2.OwnerControl = this;
            this.flyoutPanel2.Showing += FlyoutPanel2_Showing;
            this.flyoutPanel2.Hidden += FlyoutPanel2_Hidden;
        }

        private void FlyoutPanel2_Hidden(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            MessageBox.Show("");
        }

        private void FlyoutPanel2_Showing(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            MessageBox.Show("");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            flyoutPanel2.ShowPopup();
        }
    }
}
