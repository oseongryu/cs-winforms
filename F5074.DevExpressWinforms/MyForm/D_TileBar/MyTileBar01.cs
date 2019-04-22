using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace F5074.DevExpressWinforms.MyForm.D_TileBar
{
    public partial class MyTileBar01 : UserControl
    {
        Color[] arrColor = new Color[] { Color.FromArgb(0x00, 0x87, 0x9C), Color.FromArgb(0xCC, 0x6D, 0x00), Color.FromArgb(0x00, 0x73, 0xC4), Color.FromArgb(0x3E, 0x70, 0x38), Color.FromArgb(0x40, 0x40, 0x40), Color.FromArgb(0x40, 0x40, 0x40), Color.FromArgb(0x40, 0x40, 0x40) };
        string[] arrImage = new string[] { "office2013/chart/bar_32x32.png", "office2013/chart/pie_32x32.png", "office2013/data/database_32x32.png", "office2013/actions/add_16x16.png", "office2013/actions/add_16x16.png", "office2013/actions/add_16x16.png" };
        private DevExpress.XtraEditors.SearchControl searchControl = new DevExpress.XtraEditors.SearchControl();
        public MyTileBar01()
        {
            InitializeComponent();
            MakeTileBar();
            MakeButtonPanel();
            MakeSearchControl();
        }

        private void MakeSearchControl()
        {
            this.searchControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            //this.searchControl.Client = this.gridControl;
            //this.searchControl.Location = new System.Drawing.Point(669, 23);
            this.searchControl.Name = "searchControl";
            this.searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            //this.searchControl.Properties.Client = this.gridControl;
            this.searchControl.Size = new System.Drawing.Size(260, 100);
            this.searchControl.TabIndex = 9;
            this.windowsUIButtonPanel1.Controls.Add(this.searchControl);
            this.searchControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchControl.Properties.Appearance.Font = new System.Drawing.Font("consolas", 11F);
            this.searchControl.Properties.Appearance.Options.UseFont = true;

        }
        private void MakeTileBar()
        {
            // https://documentation.devexpress.com/WPF/DevExpress.Xpf.Navigation.TileBar.Orientation.property
            tileBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            tileBar1.AppearanceItem.Normal.BackColor = Color.FromArgb(65, 168, 207);
            tileBar1.AppearanceItem.Normal.ForeColor = Color.White;
            TileBarGroup group1 = new TileBarGroup();
            tileBar1.Groups.Add(group1);

            //TileBarItem tile1 = new TileBarItem();
            //tile1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            //tile1.Elements.Add(new TileItemElement() { Text = "", Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_16x16.png"), ImageAlignment = TileItemContentAlignment.TopLeft });
            //tile1.Elements.Add(new TileItemElement() { Text = "Sales", TextAlignment = TileItemContentAlignment.BottomLeft });

            for (int x = 0; x < 5; x++)
            {
                TileBarItem tile1 = new TileBarItem();
                tile1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
                tile1.AppearanceItem.Normal.BackColor = arrColor[x];
                tile1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
                tile1.Elements.Add(new TileItemElement() { Text = "", Image = DevExpress.Images.ImageResourceCache.Default.GetImage(arrImage[x]), ImageAlignment = TileItemContentAlignment.TopLeft });
                tile1.Elements.Add(new TileItemElement() { Text = "Sales", TextAlignment = TileItemContentAlignment.BottomLeft });
                group1.Items.Add(tile1);
            }


            //tileItemElement1.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_16x16.png");
            //tileItemElement1.ImageAlignment = TileItemContentAlignment.TopLeft;
            //tileItemElement1.Text = "";
            //tileItemElement5.Text = "<size=+4>Export and Mail";
            //tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
        }
        private void MakeButtonPanel()
        {
            WindowsUIButton btn1 = new WindowsUIButton("Btn1", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/chart/bar_32x32.png") });
            WindowsUIButton btn2 = new WindowsUIButton("Btn2", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_32x32.png") });
            WindowsUIButton btn3 = new WindowsUIButton("Btn3", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/apply_32x32.png") });
            WindowsUIButton btn4 = new WindowsUIButton("Btn4", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/cancel_32x32.png") });
            WindowsUISeparator separator = new DevExpress.XtraBars.Docking2010.WindowsUISeparator();

            this.windowsUIButtonPanel1.AllowGlyphSkinning = true;
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] { btn1, btn2, separator, btn3, btn4 });
            this.windowsUIButtonPanel1.ButtonClick += windowsUIButtonPanel1_ButtonClick;

            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(1213, 73);
            this.windowsUIButtonPanel1.TabIndex = 0;
            this.windowsUIButtonPanel1.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(130, 130, 130);
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(130, 130, 130);
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanel1.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanel1.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(159, 159, 159);
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(159, 159, 159);
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.Options.UseForeColor = true;
        }
        private void windowsUIButtonPanel1_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Caption != null && btn.Caption.Equals("Btn1"))
            {
                MessageBox.Show("Btn1");
            }
            else if (btn.Caption != null && btn.Caption.Equals("Btn2"))
            {
                MessageBox.Show("Btn2");
            }
        }

    }
}
