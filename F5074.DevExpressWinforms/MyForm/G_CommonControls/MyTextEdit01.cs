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
