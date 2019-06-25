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
using F5074.MyBatisDataMapper.Service.Dashboard;

namespace F5074.DevExpressWinforms.MyForm.J_DocumentManager
{
    public partial class MyDocumentManager02 : UserControl, IVisible
    {
        public MyDocumentManager02()
        {
            InitializeComponent();
            Init(new DashboardDTO());
        }


        public void Init(DashboardDTO _dto)
        {
            // 1. 뷰에추가 https://www.devexpress.com/Support/Center/Question/Details/T262503/widgetview-document-how-to-add-a-control
            // https://www.devexpress.com/Support/Center/Question/Details/T121157/change-widgetview-document-s-control
            this.widgetView1.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.widgetView1_QueryControl);
            for (int x = 0; x < 30; x++)
            {
                DevExpress.XtraBars.Docking2010.Views.Widget.Document document = new DevExpress.XtraBars.Docking2010.Views.Widget.Document();
                document.Caption = "document" + x;
                document.ControlName = "UserControl" + x;
                document.Width = 50;
                document.Height = 50;

                //if (x % 2 == 1) document.ControlTypeName = "WindowsFormsApp1.UserControl1";
                //else document.ControlTypeName = "WindowsFormsApp1.UserControl2";
                if (x % 2 == 1) document.ControlTypeName = "F5074.DevExpressWinforms.MyUserControl.MyUserControl01";
                else document.ControlTypeName = "F5074.DevExpressWinforms.MyUserControl.MyUserControl01";

                //document.Properties.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
                //document.Properties.ShowMaximizeButton = DevExpress.Utils.DefaultBoolean.False;
                this.widgetView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] { document });
                //this.widgetView1.FlowLayoutProperties.FlowLayoutItems.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.Document[] { document });
                //this.stackGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.Document[] { document });


                // 2번 방법
                //var control = Activator.CreateInstance(Type.GetType(document.ControlTypeName)) as Control;
                //documentManager1.View.AddDocument(control);

            }
            //this.widgetView1.QueryMaximizedControl += WidgetView1_QueryMaximizedControl;
            this.widgetView1.DocumentProperties.ShowCloseButton = false;
            this.widgetView1.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FlowLayout;
            this.widgetView1.RootContainer.Element = null;
            this.widgetView1.RootContainer.Orientation = System.Windows.Forms.Orientation.Vertical;
        }

        private void WidgetView1_QueryMaximizedControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            e.Control = new UserControl();
        }

        //Random r = new Random();
        private void widgetView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {


            e.Control = Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)) as Control;
            //e.Document.Caption = "AA";


            //if (e.Document.ControlTypeName == "DevExpress.ApplicationUI.Demos.ucCardWidget")
            //{
            //    var smallWidget = new UserControl1();
            //    //smallWidget.Price = r.Next(100, 1000);
            //    //smallWidget.PPrice = r.NextDouble() - r.NextDouble();
            //    //smallWidget.Delta = r.Next(-50, 100) + r.NextDouble();
            //    e.Control = smallWidget;
            //    return;
            //}





            //if (!string.IsNullOrEmpty(e.Document.ControlTypeName))
            //{
            //    var control = Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)) as Control;
            //    e.Control = control;
            //}
        }

    }
}
