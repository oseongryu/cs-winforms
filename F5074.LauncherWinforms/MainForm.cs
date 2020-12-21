using DevExpress.XtraBars.Docking2010.Views.NoDocuments;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.LauncherWinforms
{
    public partial class MainForm : Form
    {
        public XtraTabControl ParentTab { get; set; }
        private string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private List<DevExpressWinforms.MyCommon.MyDirectory01.MenuVo> resultList;
        private string programPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        Assembly assembly;
        DevExpress.XtraBars.Docking.DockPanel dockPanel;
        public MainForm()
        {
            InitializeComponent();

            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.DoubleClick += treeList1_DoubleClick;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] { new DevExpress.XtraTreeList.Columns.TreeListColumn() { Caption = "메뉴", FieldName = "메뉴", MinWidth = 34, Name = "treeListColumn1", Visible = true, VisibleIndex = 0, Width = 300 } });

            resultList = new DevExpressWinforms.MyCommon.MyDirectory01().SearchAssembly();
            resultList.Reverse();   // List Reversing https://stackoverflow.com/questions/3062513/how-can-i-sort-generic-list-desc-and-asc
            for (int x = 0; x < resultList.Count; x++)
            {
                this.treeList1.AppendNode(new object[] { Text = resultList[x].Name }, -1);
                //this.treeList1.AppendNode(new object[] { Text = resultList[x].MenuName }, -1);
            }
            //this.xtraTabControl1.TabPages.Add("Main");
            this.dockManager1.DockingOptions.ShowCloseButton = false;
            documentManager1.DocumentActivate += DocumentManager1_DocumentActivate;

            // TrayIcon https://m.blog.naver.com/PostView.nhn?blogId=nersion&logNo=140141051503&proxyReferer=https%3A%2F%2Fwww.google.com%2F
            this.Resize += MainForm_Resize;
            notifyIcon1.DoubleClick += NotifyIcon1_DoubleClick;
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            //Notify Icon을 더블클릭했을시 일어나는 이벤트.
            this.Visible = true;
            this.ShowIcon = true;
            notifyIcon1.Visible = false; //트레이 아이콘을 숨긴다.
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //윈도우 상태가 Minimized일 경우
            if (this.WindowState == FormWindowState.Minimized)

            {
                this.Visible = false; //창을 보이지 않게 한다.
                this.ShowIcon = false; //작업표시줄에서 제거.
                notifyIcon1.Visible = true; //트레이 아이콘을 표시한다.
            }
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

                //for (int x = 0; x < resultList.Count; x++)
                //{
                //    if (resultList[x].AssemblyName == "F5074.DevExpressWinforms" && resultList[x].MenuFullPath.Contains(this.treeList1.FocusedValue.ToString()))
                //    {
                //        className = "F5074.DevExpressWinforms.MyForm." + resultList[x].ClassName + "." + resultList[x].MenuName;
                //        //assembly = Assembly.GetExecutingAssembly();
                //        assembly = Assembly.LoadFrom(programPath + "\\F5074.DevExpressWInforms.dll");

                //        break;
                //    }
                //    else if (resultList[x].AssemblyName == "F5074.Winforms" && resultList[x].MenuFullPath.Contains(this.treeList1.FocusedValue.ToString()))
                //    {
                //        className = "F5074.Winforms.MyForm." + resultList[x].ClassName + "." + resultList[x].MenuName;
                //        assembly = Assembly.LoadFrom(programPath + "\\F5074.WInforms.dll");
                //        break;
                //    }
                //}

                for (int x = 0; x < resultList.Count; x++)
                {
                    if (resultList[x].FullName.Contains("F5074.DevExpressWinforms") && resultList[x].Name.Contains(this.treeList1.FocusedValue.ToString()))
                    {
                        className = resultList[x].FullName;
                        //assembly = Assembly.GetExecutingAssembly();
                        assembly = Assembly.LoadFrom(programPath + "\\F5074.DevExpressWInforms.dll");
                        break;
                    }
                    else if (resultList[x].FullName.Contains("F5074.Winforms") && resultList[x].Name.Contains(this.treeList1.FocusedValue.ToString()))
                    {
                        className = resultList[x].FullName;
                        //assembly = Assembly.GetExecutingAssembly();
                        assembly = Assembly.LoadFrom(programPath + "\\F5074.WInforms.dll");
                        break;
                    }
                    else if (resultList[x].FullName.Contains("F5074.MVVM") && resultList[x].Name.Contains(this.treeList1.FocusedValue.ToString()))
                    {
                        className = resultList[x].FullName;
                        //assembly = Assembly.GetExecutingAssembly();
                        assembly = Assembly.LoadFrom(programPath + "\\F5074.MVVM.dll");
                        break;
                    }
                }

                // XtraTabControl 사용
                //Type t = assembly.GetType(className);
                //string classNamespace = t.Namespace;
                //Object obj = Activator.CreateInstance(t);
                //Control tabControl = obj as Control;
                //tabControl.Dock = DockStyle.Fill;
                //string tabName = this.treeList1.FocusedValue.ToString();
                //XtraTabPage tabPage = new XtraTabPage() { Name = tabName, Text = tabName };
                //tabPage.Controls.Add(tabControl);
                //xtraTabControl1.TabPages.Add(tabPage);
                //xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;



                // 선택된 document가 없을 경우 추가
                // https://www.devexpress.com/Support/Center/Question/Details/Q335155/how-to-programmatically-select-a-documentmanager-tab-without-focusing-it
                for (int x = 0; x < documentManager1.View.Documents.Count; x++)
                {
                    DevExpress.XtraBars.Docking2010.Views.BaseDocumentCollection ds = documentManager1.View.Documents;
                    if (ds[x].Caption == this.treeList1.FocusedValue.ToString())
                    {
                        Document document = documentManager1.View.Documents[x] as Document;
                        //tabbedView1.Controller.Activate(document);
                        //documentManager1.View.ActivateDocument(tabbedView1.ActiveDocument.Control);
                        //documentManager1.View.ActivateDocument(document.Control);
                        documentManager1.View.ActivateDocument(ds[x].Control);
                        return;
                    }
                }
                // DocumentManager 사용
                Type t = assembly.GetType(className);
                string classNamespace = t.Namespace;
                Object obj = Activator.CreateInstance(t);
                Control userControl = obj as Control;
                userControl.Dock = DockStyle.Fill;
                string tabName = this.treeList1.FocusedValue.ToString();
                dockPanel = new DevExpress.XtraBars.Docking.DockPanel() { Text = tabName };
                dockPanel.Controls.Add(userControl);
                documentManager1.View.AddDocument(dockPanel);
                //documentManager1.View.ActivateDocument(dockPanel);
                dockPanel.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DocumentManager1_DocumentActivate(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
            
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("user32.dll")]
        public static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, int wParam, int lParam);


        public void RefreshTrayArea()
        {
            IntPtr systemTrayContainerHandle = FindWindow("Shell_TrayWnd", null);
            IntPtr systemTrayHandle = FindWindowEx(systemTrayContainerHandle, IntPtr.Zero, "TrayNotifyWnd", null);
            IntPtr sysPagerHandle = FindWindowEx(systemTrayHandle, IntPtr.Zero, "SysPager", null);
            IntPtr notificationAreaHandle = FindWindowEx(sysPagerHandle, IntPtr.Zero, "ToolbarWindow32", "Notification Area");
            if (notificationAreaHandle == IntPtr.Zero)
            {
                notificationAreaHandle = FindWindowEx(sysPagerHandle, IntPtr.Zero, "ToolbarWindow32", "User Promoted Notification Area");
                IntPtr notifyIconOverflowWindowHandle = FindWindow("NotifyIconOverflowWindow", null);
                IntPtr overflowNotificationAreaHandle = FindWindowEx(notifyIconOverflowWindowHandle, IntPtr.Zero, "ToolbarWindow32", "Overflow Notification Area");
                RefreshTrayArea(overflowNotificationAreaHandle);
            }
            RefreshTrayArea(notificationAreaHandle);
        }

        private static void RefreshTrayArea(IntPtr windowHandle)
        {
            const uint wmMousemove = 0x0200;
            RECT rect;
            GetClientRect(windowHandle, out rect);
            for (var x = 0; x < rect.right; x += 5)
                for (var y = 0; y < rect.bottom; y += 5)
                    SendMessage(windowHandle, wmMousemove, 0, (y << 16) + x);
        }

    }
}
