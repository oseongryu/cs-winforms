using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;

namespace F5074.Winforms.MyForm.G_WebBrowser
{
    public partial class MyWebBrowser01 : UserControl
    {
        public MyWebBrowser01()
        {
            InitializeComponent();
            SetBrowserFeatureControl();

            Refresh();

            treeView1.DoubleClick += TreeView1_DoubleClick;
            button1.Click += Button1_Click;
            this.webBrowser1.ScriptErrorsSuppressed = true;

            //webBrowser1.Url = new Uri("https://www.youtube.com/watch?v=Wb78U_-64NU");

            //this.richTextBox1.DoubleClick += RichTextBox1_DoubleClick;
            //string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //path = System.IO.Path.GetDirectoryName(path);
            //foreach (string line in File.ReadLines(path + "/MyResources/WebBrowserList.txt", Encoding.UTF8))
            //{
            //    //richTextBox1.Text = line;
            //    this.richTextBox1.Multiline = true;
            //    richTextBox1.AppendText(line + Environment.NewLine);
            //    richTextBox1.SelectionStart = richTextBox1.Text.Length;
            //    richTextBox1.ScrollToCaret();
            //}
        }

        public void Refresh()
        {
            treeView1.Nodes.Clear();
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = System.IO.Path.GetDirectoryName(path);
            foreach (string line in File.ReadLines(path + "/MyResources/WebBrowserList.txt", Encoding.UTF8))
            {
                TreeNode node = new TreeNode() { Text = line + Environment.NewLine, Tag = line, Name = line };
                treeView1.Nodes.Add(node);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)) return;
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = System.IO.Path.GetDirectoryName(path);
            string savePath = path + "/MyResources/WebBrowserList.txt";
            File.AppendAllText(savePath,textBox1.Text + Environment.NewLine, Encoding.Default);
            Refresh();
        }

        private void TreeView1_DoubleClick(object senader, EventArgs e)
        {
            try
            {
                webBrowser1.Url = new Uri(treeView1.SelectedNode.Text);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //private void RichTextBox1_DoubleClick(object sender, EventArgs e)
        //{
        //    string ab = richTextBox1.SelectedText;
        //}

        private static void SetBrowserFeatureControl()
        {
            // http://msdn.microsoft.com/en-us/library/ee330720(v=vs.85).aspx
            // WebBrowser Feature Control settings are per-process
            var fileName = System.IO.Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName);
            // make the control is not running inside Visual Studio Designer
            if (String.Compare(fileName, "devenv.exe", true) == 0 || String.Compare(fileName, "XDesProc.exe", true) == 0)
                return;
            SetBrowserFeatureControlKey("FEATURE_BROWSER_EMULATION", fileName, GetBrowserEmulationMode());
        }

        private static void SetBrowserFeatureControlKey(string feature, string appName, uint value)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(
                String.Concat(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\", feature),
                RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                key.SetValue(appName, (UInt32)value, RegistryValueKind.DWord);
            }
        }
        private static UInt32 GetBrowserEmulationMode()
        {
            int browserVersion = 7;
            using (var ieKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer",
                RegistryKeyPermissionCheck.ReadSubTree,
                System.Security.AccessControl.RegistryRights.QueryValues))
            {
                var version = ieKey.GetValue("svcVersion");
                if (null == version)
                {
                    version = ieKey.GetValue("Version");
                    if (null == version)
                        throw new ApplicationException("Microsoft Internet Explorer is required!");
                }
                int.TryParse(version.ToString().Split('.')[0], out browserVersion);
            }
            // Internet Explorer 10. Webpages containing standards-based !DOCTYPE directives are displayed in IE10 Standards mode. Default value for Internet Explorer 10.
            UInt32 mode = 10000;
            switch (browserVersion)
            {
                case 7:
                    // Webpages containing standards-based !DOCTYPE directives are displayed in IE7 Standards mode. Default value for applications hosting the WebBrowser Control.
                    mode = 7000;
                    break;
                case 8:
                    // Webpages containing standards-based !DOCTYPE directives are displayed in IE8 mode. Default value for Internet Explorer 8
                    mode = 8000;
                    break;
                case 9:
                    // Internet Explorer 9. Webpages containing standards-based !DOCTYPE directives are displayed in IE9 mode. Default value for Internet Explorer 9.
                    mode = 9000;
                    break;
                default:
                    // use IE10 mode by default
                    break;
            }
            return mode;
        }
    }
}
