using F5074.Winforms.TabFolder;
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

namespace F5074.Winforms
{
    public partial class Form1 : Form
    {
        private TreeNode treeNode1 = new TreeNode("1.Enum활용");
        private TreeNode treeNode2 = new TreeNode("노드1");


        public Form1()
        {
            InitializeComponent();
            this.treeView1.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2 });
            this.tabControl1.Controls.Add(new TabPage("Main"));
            this.treeView1.DoubleClick += new EventHandler(this.treeView1_DoubleClick);
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            FormTab1 formTab1 = new FormTab1() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            this.tabControl1.TabPages[0].Controls.Add(formTab1);
            formTab1.Show();

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

        private void AddTabPage_2()
        {
            FormTab1 formTab1 = new FormTab1();
            formTab1.TopLevel = false;
            formTab1.TopMost = true;
            formTab1.Dock = DockStyle.Fill;

            TabPage tabPage = new TabPage("TabPage");
            formTab1.Parent = tabPage;
            tabPage.Controls.Add(formTab1);

            this.tabControl1.Controls.Add(tabPage);

            formTab1.Show();
        }


    }
}
