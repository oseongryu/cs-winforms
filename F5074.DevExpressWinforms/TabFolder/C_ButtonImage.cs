using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.TabFolder
{
    public partial class C_ButtonImage : UserControl
    {
        public C_ButtonImage()
        {
            InitializeComponent();
            this.simpleButton1.Click += simpleButton1_Click;
        }

        // https://www.devexpress.com/Support/Center/Question/Details/Q512749/how-to-get-icons-from-the-dx-image-gallery-in-code
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //this.pictureEdit1.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("grayscale/actions/add_32x32.png");

            pictureEdit1.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_16x16.png");
        }
    }
}
