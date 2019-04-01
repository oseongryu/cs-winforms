using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTab;
using F5074.DevExpressWinforms.TabFolder;

namespace F5074.DevExpressWinforms
{
    public partial class Form1 : Form
    {
        public XtraTabControl ParentTab { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.DoubleClick += treeList1_DoubleClick;

            //first method 
            //treeList1.FocusedNode.SetValue(0, "new value");
            //second method
            //treeList1.FocusedNode[0] = "new value";

            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] { new DevExpress.XtraTreeList.Columns.TreeListColumn() { Caption = "메뉴", FieldName = "메뉴", MinWidth = 34, Name = "treeListColumn1", Visible = true, VisibleIndex = 0, Width = 300 } });

            this.treeList1.AppendNode(new object[] { Text = "1_DataTable" }, -1);
            this.treeList1.AppendNode(new object[] { Text = "2_TreeList" }, -1);
            this.treeList1.AppendNode(new object[] { Text = "3_ButtonImage" }, -1);
            this.treeList1.AppendNode(new object[] { Text = "4_GridControl" }, -1);
            this.treeList1.AppendNode(new object[] { Text = "5_TabControl" }, -1);
            this.treeList1.AppendNode(new object[] { Text = "6_ButtonEdit" }, -1);
            this.treeList1.AppendNode(new object[] { Text = "7_DateEditTab" }, -1);
            this.treeList1.AppendNode(new object[] { Text = "8_GridCheckBoxInCell" }, -1);
            this.xtraTabControl1.TabPages.Add("Main");
        }

        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //////MessageBox.Show(this.treeList1.FocusedValue.ToString());
                //this.xtraTabControl1.TabPages.Add(this.treeList1.FocusedValue.ToString());
                //Tab1 tab1 = new Tab1();
                //tab1.Show();


                //case "1.DataTable": xtraTabControl1.TabPages[0].Controls.Add(new Tab1() { TopLevel = false, WindowState = FormWindowState.Maximized }); break;

                object mainTab = new object();

                switch (this.treeList1.FocusedValue.ToString())
                {
                    case "1_DataTable":
                        {
                            Tab1 tab = new Tab1() { TopLevel = false, WindowState = FormWindowState.Maximized };
                            xtraTabControl1.TabPages[0].Controls.Add(tab);
                            tab.Show();
                            break;
                        }
                    case "2_TreeList":
                        {
                            Tab2 tab = new Tab2() { TopLevel = false, WindowState = FormWindowState.Maximized };
                            xtraTabControl1.TabPages[0].Controls.Add(tab);
                            tab.Show();
                            break;
                        }

                    case "3_ButtonImage":
                        {
                            ButtonImage tab = new ButtonImage() { TopLevel = false, WindowState = FormWindowState.Maximized };
                            xtraTabControl1.TabPages[0].Controls.Add(tab);
                            tab.Show();
                            break;
                        }

                    case "4_GridControl":
                        {
                            GridCalendarInCell tab = new GridCalendarInCell();
                            tab.Dock = DockStyle.Fill;
                            //tab.Size = Screen.PrimaryScreen.WorkingArea.Size;
                            //tab.Location = Screen.PrimaryScreen.WorkingArea.Location;
                            xtraTabControl1.TabPages[0].Controls.Add(tab);
                            tab.Show();
                            break;
                        }

                    case "6_ButtonEdit":
                        {
                            ButtonEdit tab = new ButtonEdit();
                            tab.Dock = DockStyle.Fill;
                            //tab.Size = Screen.PrimaryScreen.WorkingArea.Size;
                            //tab.Location = Screen.PrimaryScreen.WorkingArea.Location;
                            xtraTabControl1.TabPages[0].Controls.Add(tab);
                            tab.Show();
                            break;
                        }
                    case "7_DateEditTab":
                        {
                            DateEditTab tab = new DateEditTab();
                            tab.Dock = DockStyle.Fill;
                            //tab.Size = Screen.PrimaryScreen.WorkingArea.Size;
                            //tab.Location = Screen.PrimaryScreen.WorkingArea.Location;
                            xtraTabControl1.TabPages[0].Controls.Add(tab);
                            tab.Show();
                            break;
                        }
                    case "8_GridCheckBoxInCell":
                        {
                            GridCheckBoxInCell tab = new GridCheckBoxInCell();
                            tab.Dock = DockStyle.Fill;
                            //tab.Size = Screen.PrimaryScreen.WorkingArea.Size;
                            //tab.Location = Screen.PrimaryScreen.WorkingArea.Location;
                            xtraTabControl1.TabPages[0].Controls.Add(tab);
                            tab.Show();
                            break;
                        }

                }


                //Tab1 mainTab = new Tab1();
                //mainTab.TopLevel = false;
                //xtraTabControl1.TabPages[0].Controls.Add(mainTab);
                //mainTab.WindowState = FormWindowState.Maximized;
                //mainTab.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
