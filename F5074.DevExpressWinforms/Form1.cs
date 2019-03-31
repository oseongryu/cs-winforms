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

            this.treeList1.AppendNode(new object[] { Text = "1.DataTable" }, -1);
            this.treeList1.AppendNode(new object[] { Text = "2.TreeList" }, -1);
            this.treeList1.AppendNode(new object[] { Text = "3.ButtonImage" }, -1);
            this.treeList1.AppendNode(new object[] { Text = "4.GridControl" }, -1);
            this.treeList1.AppendNode(new object[] { Text = "5.TabControl" }, -1);
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
                    case "1.DataTable":
                        {
                            Tab1 tab1 = new Tab1();
                            tab1.TopLevel = false;
                            xtraTabControl1.TabPages[0].Controls.Add(tab1);
                            tab1.WindowState = FormWindowState.Maximized;
                            tab1.Show();
                            break;
                        }
                    case "2.TreeList":
                        {
                            Tab2 tab2 = new Tab2();
                            tab2.TopLevel = false;
                            xtraTabControl1.TabPages[0].Controls.Add(tab2);
                            tab2.WindowState = FormWindowState.Maximized;
                            tab2.Show();
                            break;
                        }

                    case "3.ButtonImage":
                        {
                            ButtonImage tab3 = new ButtonImage();
                            tab3.TopLevel = false;
                            xtraTabControl1.TabPages[0].Controls.Add(tab3);
                            tab3.WindowState = FormWindowState.Maximized;
                            tab3.Show();
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
