using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.MyForm.G_CommonControls
{
    public partial class MyTextEdit01 : UserControl
    {
        public MyTextEdit01()
        {
            InitializeComponent();
            textEdit1.Enter += TextEdit_Enter;
            textEdit2.Enter += TextEdit_Enter;

            string test = "08-04 00:08~08-04 00:08(-),08-05 09:08~08-10 20:08(-),08-12 01:08~08-17 17:08(-),08-19 08:08~09-03 13:09(-)";
            MessageBox.Show(test.Replace(",", "\r\n"));
        }

        private void TextEdit_Enter(object sender, EventArgs e)
        {
            //TextEdit edit = sender as TextEdit;
            //BeginInvoke(new Action(() => edit.SelectAll()));
            //edit.Refresh();

            //(sender as TextEdit).SelectAll();

            var edit = ((DevExpress.XtraEditors.TextEdit)sender);
            BeginInvoke(new MethodInvoker(() =>
            {
                edit.SelectionStart = 0;
                edit.SelectionLength = edit.Text.Length;
            }));
        }
    }
}
