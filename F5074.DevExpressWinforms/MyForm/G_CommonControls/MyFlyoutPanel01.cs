using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Customization;
using F5074.DevExpressWinforms.MyCommon;

namespace F5074.DevExpressWinforms.MyForm.G_CommonControls
{
    public partial class MyFlyoutPanel01 : UserControl
    {
        public MyFlyoutPanel01()
        {
            InitializeComponent();
            //flyoutPanel1.ShowPopup();
            // https://www.devexpress.com/Support/Center/Question/Details/T333871/flyoutpanel-sample
            // https://documentation.devexpress.com/WindowsForms/114578/Controls-and-Libraries/Messages-Notifications-and-Dialogs/Flyout-Panel#beak
            //flyoutPanel1.OwnerControl = this.simpleButton1;

            this.flyoutPanel2.OwnerControl = this.simpleButton1;
            this.flyoutPanel2.Showing += FlyoutPanel2_Showing;
            this.flyoutPanel2.Hidden += FlyoutPanel2_Hidden;
            // https://www.devexpress.com/Support/Center/Question/Details/T258043/how-to-use-flyoutdialog-with-usercontrol-from-a-usercontrol-not-from-windowsform
            FlyoutAction action = new FlyoutAction();
            action.Commands.Add(FlyoutCommand.OK);
            action.Commands.Add(FlyoutCommand.Cancel);
            FlyoutDialog.Show(this.FindForm(), action, new MyButtonEdit01());


            FlyoutProperties properties = new FlyoutProperties();
            properties.ButtonSize = new Size(100, 10);
            properties.Style = FlyoutStyle.Popup;
            FlyoutDialog.Show(this.FindForm(), "", new MyButtonEdit01(), properties, 0, 0);
            //FlyoutDialog.Show(this.FindForm(), new MyButtonEdit01());

            //FlyoutDialog.Show(this.FindForm(), MyDevExpressFunctions.CreateCloseAction(), properties);





        }

        private void FlyoutPanel2_Hidden(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            //MessageBox.Show("");
        }

        private void FlyoutPanel2_Showing(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            //MessageBox.Show("");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //flyoutPanel2.ShowPopup();
            this.flyoutPanel2.ShowBeakForm();
        }
    }
}
