using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace F5074.Winforms.MyForm.D_Common
{
    public partial class MyPrivateFontCollection01 : UserControl
    {
        public MyPrivateFontCollection01()
        {
            InitializeComponent();
            // http://www.free-barcode-font.com/
            // https://blog.ntils.com/entry/%EC%9A%B4%EC%98%81%EC%B2%B4%EC%A0%9C%EC%97%90-%EB%93%B1%EB%A1%9D%EB%90%98%EC%A7%80-%EC%95%8A%EC%9D%80-%ED%8F%B0%ED%8A%B8-%EC%82%AC%EC%9A%A9%ED%95%98%EA%B8%B0
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddFontFile("free3of9.ttf");
            Font font = new Font(privateFontCollection.Families[0], 50f);
            label1.Text = "*U44444*";
            label1.Font = font;
        }
    }
}
