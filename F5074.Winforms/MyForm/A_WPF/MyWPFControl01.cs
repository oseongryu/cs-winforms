using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Winforms.MyForm.A_WPF
{
    public partial class MyWPFControl01 : UserControl
    {
        public MyWPFControl01()
        {
            InitializeComponent();

            // https://shine10e.tistory.com/70
            //this.elementHost1.Child = new F5074.WPF.MainWindow();
        }
    }
}
