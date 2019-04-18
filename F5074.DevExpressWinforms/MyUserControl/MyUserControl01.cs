using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;

namespace F5074.DevExpressWinforms.MyUserControl
{
    public partial class MyUserControl01 : DevExpress.XtraEditors.XtraUserControl
    {
        public MyUserControl01()
        {
            InitializeComponent();
            tileBar1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            tileBar1.AppearanceItem.Normal.BackColor = Color.FromArgb(65, 168, 207);
            tileBar1.AppearanceItem.Normal.ForeColor = Color.White;
            TileBarGroup group1 = new TileBarGroup();
            tileBar1.Groups.Add(group1);
            tileBar1.WideTileWidth = 150;
            tileBar1.ItemSize = 120;
            TileBarItem tile1 = new TileBarItem();
            tile1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;

            tile1.AppearanceItem.Normal.BackColor = Color.DodgerBlue;
            tile1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            tile1.Elements.Add(new TileItemElement() { Text = "", Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/chart/kpi_32x32.png"), ImageAlignment = TileItemContentAlignment.BottomRight });
            tile1.Elements.Add(new TileItemElement() { Text = "<size=12>설비 1</size><br><size=8>Equipment<br>running rate</size>", TextAlignment = TileItemContentAlignment.TopLeft });
            group1.Items.Add(tile1);
        }
    }
}
