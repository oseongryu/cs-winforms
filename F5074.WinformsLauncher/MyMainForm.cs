using DevExpress.XtraTab;
using F5074.DevExpressWinforms.MyCommon;
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
    public partial class MyMainForm : Form
    {
        public XtraTabControl ParentTab { get; set; }
        private string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private List<MenuVo> resultList;
        private string programPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        Assembly assembly;
        public MyMainForm()
        {
            InitializeComponent();
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.DoubleClick += treeList1_DoubleClick;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] { new DevExpress.XtraTreeList.Columns.TreeListColumn() { Caption = "메뉴", FieldName = "메뉴", MinWidth = 34, Name = "treeListColumn1", Visible = true, VisibleIndex = 0, Width = 300 } });

            resultList = new MyDirectory01().SearchFile();
            resultList.Reverse();   // List Reversing https://stackoverflow.com/questions/3062513/how-can-i-sort-generic-list-desc-and-asc
            for (int x = 0; x < resultList.Count; x++)
            {
                this.treeList1.AppendNode(new object[] { Text = resultList[x].MenuName }, -1);
            }
            this.xtraTabControl1.TabPages.Add("Main");
            this.dockManager1.DockingOptions.ShowCloseButton = false;
        }

        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                object mainTab = new object();

                // https://lambdaexp.tistory.com/19
                // https://m.blog.naver.com/delight_gruv/130071915177
                //string className = "F5074.DevExpressWinforms.MyForm.D_TileBar.MyTileBar03";
                string className = "";
                //string[] arrSplit = Regex.Split(resultList[0].MenuFullPath, "\r\n\r\n");
                //string arrSplit = Path.GetDirectoryName(resultList[2].MenuFullPath).Split(Path.DirectorySeparatorChar).Last();

                for (int x = 0; x < resultList.Count; x++)
                {
                    if (resultList[x].AssemblyName == "F5074.DevExpressWinforms" && resultList[x].MenuFullPath.Contains(this.treeList1.FocusedValue.ToString()))
                    {
                        className = "F5074.DevExpressWinforms.MyForm." + resultList[x].ClassName + "." + resultList[x].MenuName;
                        //assembly = Assembly.GetExecutingAssembly();
                        assembly = Assembly.LoadFrom(programPath + "\\F5074.DevExpressWInforms.dll");

                        break;
                    }
                    else if (resultList[x].AssemblyName == "F5074.Winforms" && resultList[x].MenuFullPath.Contains(this.treeList1.FocusedValue.ToString()))
                    {
                        className = "F5074.Winforms.MyForm." + resultList[x].ClassName + "." + resultList[x].MenuName;
                        assembly = Assembly.LoadFrom(programPath + "\\F5074.WInforms.dll");
                        break;
                    }
                }

                Type t = assembly.GetType(className);
                string classNamespace = t.Namespace;
                Object obj = Activator.CreateInstance(t);
                Control tabControl = obj as Control;
                tabControl.Dock = DockStyle.Fill;
                string tabName = this.treeList1.FocusedValue.ToString();
                XtraTabPage tabPage = new XtraTabPage() { Name = tabName, Text = tabName };
                tabPage.Controls.Add(tabControl);
                xtraTabControl1.TabPages.Add(tabPage);
                xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
