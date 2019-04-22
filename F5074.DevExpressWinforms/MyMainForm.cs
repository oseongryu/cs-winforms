using DevExpress.XtraTab;
using F5074.DevExpressWinforms.LayoutFolder;
using F5074.DevExpressWinforms.MyCommon;
using F5074.DevExpressWinforms.MyForm.A_GridControl;
using F5074.DevExpressWinforms.MyForm.B_SpreadsheetControl;
using F5074.DevExpressWinforms.MyForm.C_ChartControl;
using F5074.DevExpressWinforms.MyForm.D_TileBar;
using F5074.DevExpressWinforms.MyForm.E_WindowsUIView;
using F5074.DevExpressWinforms.TabFolder;
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

namespace F5074.DevExpressWinforms
{
    public partial class MyMainForm : Form
    {
        public XtraTabControl ParentTab { get; set; }
        private string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private List<MenuVo> resultList;

        public MyMainForm()
        {
            InitializeComponent();

            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.DoubleClick += treeList1_DoubleClick;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] { new DevExpress.XtraTreeList.Columns.TreeListColumn() { Caption = "메뉴", FieldName = "메뉴", MinWidth = 34, Name = "treeListColumn1", Visible = true, VisibleIndex = 0, Width = 300 } });

            resultList = new MyDirectory01().SearchFile();
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

                //string className = "F5074.DevExpressWinforms.MyForm.D_TileBar.MyTileBar03";
                string className = "";
                for (int x = 0; x < resultList.Count; x++)
                {
                    if (resultList[x].MenuFullPath.Contains("A_GridControl") && resultList[x].MenuFullPath.Contains(this.treeList1.FocusedValue.ToString()))
                    {
                        className = "F5074.DevExpressWinforms.MyForm.A_GridControl." + resultList[x].MenuName;
                        break;
                    }
                    else if (resultList[x].MenuFullPath.Contains("B_SpreadsheetControl") && resultList[x].MenuFullPath.Contains(this.treeList1.FocusedValue.ToString()))
                    {
                        className = "F5074.DevExpressWinforms.MyForm.B_SpreadsheetControl." + resultList[x].MenuName;
                        break;
                    }
                    else if (resultList[x].MenuFullPath.Contains("C_ChartControl") && resultList[x].MenuFullPath.Contains(this.treeList1.FocusedValue.ToString()))
                    {
                        className = "F5074.DevExpressWinforms.MyForm.C_ChartControl." + resultList[x].MenuName;
                        break;
                    }
                    else if (resultList[x].MenuFullPath.Contains("D_TileBar") && resultList[x].MenuFullPath.Contains(this.treeList1.FocusedValue.ToString()))
                    {
                        className = "F5074.DevExpressWinforms.MyForm.D_TileBar." + resultList[x].MenuName;
                        break;
                    }
                    else if (resultList[x].MenuFullPath.Contains("E_WindowsUIView") && resultList[x].MenuFullPath.Contains(this.treeList1.FocusedValue.ToString()))
                    {
                        className = "F5074.DevExpressWinforms.MyForm.E_WindowsUIView." + resultList[x].MenuName;
                        break;
                    }

                }
                Assembly assembly = Assembly.GetExecutingAssembly();
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
