using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Winforms.TabFolder
{
    public partial class D_TreeNode : UserControl
    {
        public D_TreeNode()
        {
            InitializeComponent();
            InitializeTreeView();
        }

        // https://m.blog.naver.com/PostView.nhn?blogId=chsmanager&logNo=140209835137&proxyReferer=https%3A%2F%2Fwww.google.com%2F
        private void InitializeTreeView()
        {
            List<CodeValueEntity> menuFactorys = new List<CodeValueEntity>() { new CodeValueEntity() { Code = "A", Value = "A" }, new CodeValueEntity() { Code = "B", Value = "B" } };
            List<GroupCodeValueEntity> scanners = new List<GroupCodeValueEntity>() { new GroupCodeValueEntity() { Group = "A", Code = "AA", Value = "AA" }, new GroupCodeValueEntity() { Group = "A", Code = "AB", Value = "AB" } };
            TreeNode tNode = new TreeNode();
            foreach (CodeValueEntity menuFactory in menuFactorys)
            {
                if (menuFactory.Code == "") continue;
                TreeNode node = getNodeSecond(getNodeFirst(menuFactory), scanners.Where(x => x.Group == menuFactory.Code).ToList());
                treeView1.Nodes.Add(node);
            }
        }

        private TreeNode getNodeFirst(CodeValueEntity menuFactory)
        {
            TreeNode node = new TreeNode();
            node.Text = menuFactory.Value;
            node.Tag = menuFactory.Code;
            node.Name = "m" + menuFactory.Code;
            return node;
        }

        private TreeNode getNodeSecond(TreeNode parentNode, List<GroupCodeValueEntity> scanners)
        {
            foreach (GroupCodeValueEntity scanner in scanners)
            {
                TreeNode node = new TreeNode();
                node.Text = scanner.Value;
                node.Tag = scanner.Code;
                node.Name = "m" + scanner.Group + "_s" + scanner.Code;
                parentNode.Nodes.Add(node);
            }
            return parentNode;
        }


        public class CodeValueEntity
        {
            public string Code { get; set; }
            public string Value { get; set; }
        }

        public class GroupCodeValueEntity
        {
            public string Group { get; set; }
            public string Code { get; set; }
            public string Value { get; set; }
            public string Etc1 { get; set; }
        }
    }
}
