using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using F5074.Winforms.MyUserControl;
using F5074.Winforms.MyForm;
using F5074.Winforms.MyForm.B_CefSharp;

namespace F5074.Winforms
{
    public partial class Form1 : Form
    {
        private TreeNode[] treeNodeArray = { new TreeNode("A_Enum"), new TreeNode("B_UserControl"), new TreeNode("C_ReadTextFile"), new TreeNode("D_TreeNode"), new TreeNode("MyCefSharp01") };

        private TabPage myTabPage;

        public Form1()
        {
            InitializeComponent();
            this.treeView1.Nodes.AddRange(treeNodeArray);
            //this.tabControl1.Controls.Add(new TabPage("Main"));
            this.treeView1.DoubleClick += new EventHandler(this.treeView1_DoubleClick);
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            switch (this.treeView1.SelectedNode.Text)
            {
                case "MyCefSharp01":

                    myTabPage = new TabPage() { Name = this.treeView1.SelectedNode.Text, Text = this.treeView1.SelectedNode.Text };
                    myTabPage.Controls.Add(new MyCefSharp01() { Dock = DockStyle.Fill });
                    tabControl1.TabPages.Add(myTabPage);
                    this.tabControl1.SelectedTab = myTabPage;
                    this.tabControl1.SelectedIndex = this.tabControl1.TabPages.Count - 1;
                    break;
                //case "1_Enum":
                //    FormTab1 formTab = new FormTab1() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
                //    this.tabControl1.TabPages[0].Controls.Add(formTab);
                //    formTab.Show();
                //    break;
                //case "2_UserControl":
                //    FormTab2 formTab2 = new FormTab2() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
                //    this.tabControl1.TabPages[0].Controls.Add(formTab2);
                //    formTab2.Show();
                //    break;

                //case "A_Enum":
                //    //FormTab1 formTab = new FormTab1() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
                //    //tabPage = new TabPage() { Name = this.treeView1.SelectedNode.Text, Text = this.treeView1.SelectedNode.Text };
                //    //tabPage.Controls.Add(formTab);
                //    //this.tabControl1.Controls.Add(tabPage);
                //    //this.tabControl1.SelectedTab = tabPage;
                //    ////this.tabControl1.TabPages[0].Controls.Add(formTab);
                //    //formTab.Show();

                //    myTabPage = new TabPage() { Name = this.treeView1.SelectedNode.Text, Text = this.treeView1.SelectedNode.Text };
                //    myTabPage.Controls.Add(new A_Enum() { Dock = DockStyle.Fill });
                //    this.tabControl1.TabPages.Add(myTabPage);
                //    this.tabControl1.SelectedTab = myTabPage;
                //    this.tabControl1.SelectedIndex = this.tabControl1.TabPages.Count - 1;
                //    break;

                //case "B_UserControl":
                //    //FormTab2 formTab2 = new FormTab2() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
                //    //tabPage = new TabPage() { Name = this.treeView1.SelectedNode.Text, Text = this.treeView1.SelectedNode.Text };
                //    //tabPage.Controls.Add(formTab2);
                //    //this.tabControl1.Controls.Add(tabPage);
                //    //this.tabControl1.SelectedTab = tabPage;
                //    ////this.tabControl1.TabPages[0].Controls.Add(formTab);
                //    //formTab2.Show();

                //    myTabPage = new TabPage() { Name = this.treeView1.SelectedNode.Text, Text = this.treeView1.SelectedNode.Text };
                //    myTabPage.Controls.Add(new B_UserControl() { Dock = DockStyle.Fill });
                //    tabControl1.TabPages.Add(myTabPage);
                //    this.tabControl1.SelectedIndex = this.tabControl1.TabPages.Count - 1;
                //    break;

                //case "C_ReadTextFile":
                //    //C_ReadTextFile formTab3 = new C_ReadTextFile() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
                //    //tabPage = new TabPage() { Name = this.treeView1.SelectedNode.Text, Text = this.treeView1.SelectedNode.Text };
                //    //tabPage.Controls.Add(formTab3);
                //    //this.tabControl1.Controls.Add(tabPage);
                //    //this.tabControl1.SelectedTab = tabPage;
                //    ////this.tabControl1.TabPages[0].Controls.Add(formTab);
                //    //formTab3.Show();

                //    myTabPage = new TabPage() { Name = this.treeView1.SelectedNode.Text, Text = this.treeView1.SelectedNode.Text };
                //    myTabPage.Controls.Add(new C_ReadTextFile() { Dock = DockStyle.Fill });
                //    tabControl1.TabPages.Add(myTabPage);
                //    this.tabControl1.SelectedTab = myTabPage;
                //    this.tabControl1.SelectedIndex = this.tabControl1.TabPages.Count - 1;
                //    break;
                //case "D_TreeNode":

                //    myTabPage = new TabPage() { Name = this.treeView1.SelectedNode.Text, Text = this.treeView1.SelectedNode.Text };
                //    myTabPage.Controls.Add(new D_TreeNode() { Dock = DockStyle.Fill });
                //    tabControl1.TabPages.Add(myTabPage);
                //    this.tabControl1.SelectedTab = myTabPage;
                //    this.tabControl1.SelectedIndex = this.tabControl1.TabPages.Count - 1;
                //    break;
            }

        }

        private void AddTabPage_1()
        {
            TabPage tabPage = new TabPage();
            tabPage.Location = new Point(4, 22);
            tabPage.Name = this.treeView1.SelectedNode.Text;
            tabPage.Padding = new Padding(3);
            tabPage.Size = new Size(592, 424);
            tabPage.TabIndex = 0;
            tabPage.Text = this.treeView1.SelectedNode.Text;
            tabPage.UseVisualStyleBackColor = true;

            this.tabControl1.Controls.Add(tabPage);
        }

        //private void AddTabPage_2()
        //{
        //    FormTab1 formTab1 = new FormTab1();
        //    formTab1.TopLevel = false;
        //    formTab1.TopMost = true;
        //    formTab1.Dock = DockStyle.Fill;

        //    TabPage tabPage = new TabPage("TabPage");
        //    formTab1.Parent = tabPage;
        //    tabPage.Controls.Add(formTab1);

        //    this.tabControl1.Controls.Add(tabPage);

        //    formTab1.Show();
        //}
    }
}
