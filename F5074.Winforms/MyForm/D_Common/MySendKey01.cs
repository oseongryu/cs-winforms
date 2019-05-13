using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Winforms.MyForm.D_Common
{
    public partial class MySendKey01 : UserControl
    {
        public MySendKey01()
        {
            InitializeComponent();
            this.button1.Click += Button1_Click;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // https://stackoverflow.com/questions/15621147/how-simulate-ctrlv-keystrokes-paste-using-c-sharp
            // https://11cc.tistory.com/8
            this.textBox1.Focus();
            SendKeys.Send("aaaaa");
            SendKeys.Send("^(a)");
            SendKeys.Send("^(c)");
            SendKeys.Send("^(v)");
            SendKeys.Send("^(v)");
        }
    }
}
