using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Winforms.MyUserControl
{
    public partial class TestUserControl : UserControl
    {
        public TestUserControl()
        {
            InitializeComponent();
            this.button1.Click += new EventHandler(this.button1_Click);
        }

        // 1. UserControl 
        // https://vitalholic.tistory.com/335
        // https://stackoverrun.com/ko/q/10859292
        // https://www.youtube.com/watch?v=l5L_q_jI494

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == string.Empty || label1.Text == "No")
            {
                label1.Text = "Yes";
            }
            else
            {
                label1.Text = "No";
            }
        }
    }
}
