using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.NativeMdi;

namespace F5074.DevExpressWinforms.MyForm.J_DocumentManager
{
    public partial class MyDocumentManager01 : UserControl
    {
        DevExpress.XtraBars.Docking.DockPanel dockPanel;
        public MyDocumentManager01()
        {
            InitializeComponent();
            //Form2 f = new Form2();
            //f.Text = "Test";
            //documentManager1.View.AddDocument(f);
            //Form2 f2 = new Form2();

            //UserControl1 f2 = new UserControl1();
            //f2.Name = "eee";

            dockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel.Text = "Yes";
            dockPanel.Controls.Add(new UserControl());
            documentManager1.View.AddDocument(dockPanel);

            dockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel.Text = "Yes2";
            dockPanel.Controls.Add(new UserControl());
            documentManager1.View.AddDocument(dockPanel);

            this.simpleButton1.Click += SimpleButton1_Click;
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {

            // 선택된 document가 없을 경우 추가
            for (int x = 0; x < documentManager1.View.Documents.Count; x++)
            {
                DevExpress.XtraBars.Docking2010.Views.BaseDocumentCollection ds = documentManager1.View.Documents;
                if (ds[x].Caption == "Yes3")
                {
                    Document document = documentManager1.View.Documents[x] as Document;
                    //tabbedView1.Controller.Activate(document);
                    //documentManager1.View.ActivateDocument(tabbedView1.ActiveDocument.Control);
                    //documentManager1.View.ActivateDocument(document.Control);
                    documentManager1.View.ActivateDocument(ds[x].Control);
                    return;
                }
            }

            dockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel.Text = "Yes3";
            dockPanel.Controls.Add(new UserControl());
            documentManager1.View.AddDocument(dockPanel);



        }
    }
}
