﻿using DevExpress.XtraTab;
using F5074.DevExpressWinforms.TabFolder;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms
{
    public partial class Form1 : Form
    {
        public XtraTabControl ParentTab { get; set; }
        private string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

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

            foreach (string line in File.ReadLines(System.IO.Path.GetDirectoryName(path) + "/MyResources/MenuTextFile.txt", Encoding.UTF8))
            {
                this.treeList1.AppendNode(new object[] { Text = line }, -1);
                //ClassType classType = line.ToEnum<ClassType>();
                //ClassType animal = (ClassType)Enum.Parse(typeof(ClassType), line,true);
            }

            //this.treeList1.AppendNode(new object[] { Text = "1_DataTable" }, -1);
            //this.treeList1.AppendNode(new object[] { Text = "2_TreeList" }, -1);
            //this.treeList1.AppendNode(new object[] { Text = "3_ButtonImage" }, -1);
            //this.treeList1.AppendNode(new object[] { Text = "4_GridControl" }, -1);
            //this.treeList1.AppendNode(new object[] { Text = "5_TabControl" }, -1);
            //this.treeList1.AppendNode(new object[] { Text = "6_ButtonEdit" }, -1);
            //this.treeList1.AppendNode(new object[] { Text = "7_DateEditTab" }, -1);
            //this.treeList1.AppendNode(new object[] { Text = "8_GridCheckBoxInCell" }, -1);
            this.xtraTabControl1.TabPages.Add("Main");

        }

        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                // https://stackoverflow.com/questions/10871565/how-to-make-winforms-usercontrol-fill-the-size-of-its-container/10871592
                //////MessageBox.Show(this.treeList1.FocusedValue.ToString());
                //this.xtraTabControl1.TabPages.Add(this.treeList1.FocusedValue.ToString());
                //Tab1 tab1 = new Tab1();
                //tab1.Show();


                //case "1.DataTable": xtraTabControl1.TabPages[0].Controls.Add(new Tab1() { TopLevel = false, WindowState = FormWindowState.Maximized }); break;

                object mainTab = new object();



                switch (this.treeList1.FocusedValue.ToString())
                {
                    case "A_DataTable":
                        {
                            //A_DataTable tabControl = new A_DataTable() { TopLevel = false, WindowState = FormWindowState.Maximized };
                            ////xtraTabControl1.TabPages[0].Controls.Add(tabControl);
                            //XtraTabPage tabPage = new XtraTabPage() { Name = "A_DataTable", Text = "A_DataTable" };
                            //tabPage.Controls.Add(tabControl);
                            //xtraTabControl1.TabPages.Add(tabPage);
                            //xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
                            //tabControl.Show();


                            XtraTabPage tabPage = new XtraTabPage() { Name = "A_DataTable", Text = "A_DataTable" };
                            tabPage.Controls.Add(new A_DataTable() { Dock = DockStyle.Fill });
                            xtraTabControl1.TabPages.Add(tabPage);
                            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
                            break;
                        }
                    case "B_TreeList":
                        {
                            //B_TreeList tabControl = new B_TreeList() { TopLevel = false, WindowState = FormWindowState.Maximized };
                            ////xtraTabControl1.TabPages[0].Controls.Add(tabControl);
                            //tabControl.Show();
                            //XtraTabPage tabPage = new XtraTabPage() { Name = "B_TreeList", Text = "B_TreeList" };
                            //tabPage.Controls.Add(tabControl);
                            //xtraTabControl1.TabPages.Add(tabPage);
                            //xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;

                            XtraTabPage tabPage = new XtraTabPage() { Name = "B_TreeList", Text = "B_TreeList" };
                            tabPage.Controls.Add(new B_TreeList() { Dock = DockStyle.Fill });
                            xtraTabControl1.TabPages.Add(tabPage);
                            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
                            break;
                        }

                    case "C_ButtonImage":
                        {
                            //ButtonImage tabControl = new ButtonImage() { TopLevel = false, WindowState = FormWindowState.Maximized };
                            ////xtraTabControl1.TabPages[0].Controls.Add(tabControl);
                            //tabControl.Show();

                            //XtraTabPage tabPage = new XtraTabPage() { Name = "C_ButtonImage", Text = "C_ButtonImage" };
                            //tabPage.Controls.Add(tabControl);
                            //xtraTabControl1.TabPages.Add(tabPage);
                            //xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
                            XtraTabPage tabPage = new XtraTabPage() { Name = "C_ButtonImage", Text = "C_ButtonImage" };
                            tabPage.Controls.Add(new C_ButtonImage() { Dock = DockStyle.Fill });
                            xtraTabControl1.TabPages.Add(tabPage);
                            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
                            break;

                        }

                    case "D_GridCalendarInCell":
                        {
                            //GridCalendarInCell tabControl = new GridCalendarInCell() { Dock = DockStyle.Fill };
                            //tab.Dock = DockStyle.Fill;
                            //tab.Size = Screen.PrimaryScreen.WorkingArea.Size;
                            //tab.Location = Screen.PrimaryScreen.WorkingArea.Location;
                            //xtraTabControl1.TabPages[0].Controls.Add(tabControl);
                            //tabControl.Show();
                            XtraTabPage tabPage = new XtraTabPage() { Name = "D_GridCalendarInCell", Text = "D_GridCalendarInCell" };
                            tabPage.Controls.Add(new D_GridCalendarInCell() { Dock = DockStyle.Fill });
                            xtraTabControl1.TabPages.Add(tabPage);
                            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
                            break;
                        }

                    case "E_ButtonEdit":
                        {
                            //ButtonEdit tabControl = new ButtonEdit() { Dock = DockStyle.Fill };
                            //tab.Dock = DockStyle.Fill;
                            //tab.Size = Screen.PrimaryScreen.WorkingArea.Size;
                            //tab.Location = Screen.PrimaryScreen.WorkingArea.Location;
                            //xtraTabControl1.TabPages[0].Controls.Add(tabControl);
                            //tabControl.Show();
                            XtraTabPage tabPage = new XtraTabPage() { Name = "E_ButtonEdit", Text = "E_ButtonEdit" };
                            tabPage.Controls.Add(new E_ButtonEdit() { Dock = DockStyle.Fill });
                            xtraTabControl1.TabPages.Add(tabPage);
                            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
                            break;
                        }
                    case "F_DateEditTab":
                        {
                            //DateEditTab tabControl = new DateEditTab() { Dock = DockStyle.Fill };
                            //tab.Dock = DockStyle.Fill;
                            //tab.Size = Screen.PrimaryScreen.WorkingArea.Size;
                            //tab.Location = Screen.PrimaryScreen.WorkingArea.Location;
                            //xtraTabControl1.TabPages[0].Controls.Add(tabControl);
                            //tabControl.Show();
                            XtraTabPage tabPage = new XtraTabPage() { Name = "F_DateEditTab", Text = "F_DateEditTab" };
                            tabPage.Controls.Add(new F_DateEditTab() { Dock = DockStyle.Fill });
                            xtraTabControl1.TabPages.Add(tabPage);
                            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
                            break;
                        }
                    case "G_GridCheckBoxInCell":
                        {
                            //GridCheckBoxInCell tabControl = new GridCheckBoxInCell() { Dock = DockStyle.Fill };
                            //tab.Dock = DockStyle.Fill;
                            //tab.Size = Screen.PrimaryScreen.WorkingArea.Size;
                            //tab.Location = Screen.PrimaryScreen.WorkingArea.Location;
                            //xtraTabControl1.TabPages[0].Controls.Add(tab);
                            //tab.Show();
                            XtraTabPage tabPage = new XtraTabPage() { Name = "G_GridCheckBoxInCell", Text = "G_GridCheckBoxInCell" };
                            tabPage.Controls.Add(new G_GridCheckBoxInCell() { Dock = DockStyle.Fill });
                            xtraTabControl1.TabPages.Add(tabPage);
                            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
                            break;
                        }
                    case "H_GridCheckBoxDefault":
                        {
                            XtraTabPage tabPage = new XtraTabPage() { Name = "H_GridCheckBoxDefault", Text = "H_GridCheckBoxDefault" };
                            tabPage.Controls.Add(new H_GridCheckBoxDefault() { Dock = DockStyle.Fill });
                            xtraTabControl1.TabPages.Add(tabPage);
                            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
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
