using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static F5074.DevExpressWinforms.MyCommon.MyDirectory01;

namespace F5074.WinformsLauncher
{

    public partial class MyDashBoardForm : Form
    {
        private string programPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private List<MenuVo> resultList;
        Assembly assembly;
        public MyDashBoardForm()
        {
            InitializeComponent();

            string className = "";

            className = "F5074.DevExpressWinforms.MyForm.D_TileBar.MyTileBar05";
            assembly = Assembly.LoadFrom(programPath + "\\F5074.DevExpressWInforms.dll");

            Type t = assembly.GetType(className);
            string classNamespace = t.Namespace;
            Object obj = Activator.CreateInstance(t);
            Control tabControl = obj as Control;
            tabControl.Dock = DockStyle.Fill;
            string tabName = "생산 설비";
            XtraTabPage tabPage = new XtraTabPage() { Name = tabName, Text = tabName };
            tabPage.Controls.Add(tabControl);
            xtraTabControl1.TabPages.Add(tabPage);
            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
        }
    }
}
