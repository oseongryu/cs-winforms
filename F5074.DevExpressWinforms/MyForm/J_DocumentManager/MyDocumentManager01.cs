using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.MyForm.J_DocumentManager
{
    public partial class MyDocumentManager01 : UserControl
    {
        public MyDocumentManager01()
        {
            InitializeComponent();
            //Form2 f = new Form2();
            //f.Text = "Test";
            //documentManager1.View.AddDocument(f);
            //Form2 f2 = new Form2();

            //UserControl1 f2 = new UserControl1();
            //f2.Name = "eee";

            DevExpress.XtraBars.Docking.DockPanel dockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel.Text = "Yes";
            dockPanel.Controls.Add(new UserControl());
            documentManager1.View.AddDocument(dockPanel);
        }
    }
}
