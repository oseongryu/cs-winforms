using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using F5074.MyBatisDataMapper.Service.Automation;
using F5074.Selenium.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Selenium
{
    public partial class Form1 : RibbonForm
    {
        Color[] arrColor = new Color[] { Color.FromArgb(0x00, 0x87, 0x9C), Color.FromArgb(0x40, 0x40, 0x40), Color.FromArgb(0xCC, 0x6D, 0x00), Color.FromArgb(0x00, 0x73, 0xC4), Color.FromArgb(0x40, 0x40, 0x40), Color.FromArgb(0x3E, 0x70, 0x38), Color.FromArgb(0x40, 0x40, 0x40) };
        string[] arrImage = new string[] { "office2013/chart/bar_32x32.png", "office2013/chart/pie_32x32.png", "office2013/data/database_32x32.png", "office2013/actions/add_16x16.png", "office2013/actions/add_16x16.png", "office2013/actions/add_16x16.png" };
        DevExpress.XtraBars.Docking.DockPanel dockPanel;
        
        public Form1()
        {
            InitializeComponent();
            MakeTileBar();
            this.tileBar1.ItemClick += TileBar1_ItemClick;
        }
        private void TileBar1_ItemClick(object sender, TileItemEventArgs e)
        {

            //// 선택된 document가 없을 경우 추가
            //for (int x = 0; x < documentManager1.View.Documents.Count; x++)
            //{
            //    DevExpress.XtraBars.Docking2010.Views.BaseDocumentCollection ds = documentManager1.View.Documents;
            //    if (ds[x].Caption == e.Item.Text2)
            //    {
            //        Document document = documentManager1.View.Documents[x] as Document;
            //        documentManager1.View.ActivateDocument(ds[x].Control);
            //        return;
            //    }
            //}

            switch (e.Item.Text2)
            {
                case "Main":
                    dockPanel = new DevExpress.XtraBars.Docking.DockPanel() { Text = "Main" };
                    dockPanel.Controls.Add(new SeleniumUserControl() { Dock = DockStyle.Fill });
                    documentManager1.View.AddDocument(dockPanel);
                    documentManager1.View.ActivateDocument(dockPanel);
                    break;
            }


        }

        private void MakeTileBar()
        {
            // https://documentation.devexpress.com/WPF/DevExpress.Xpf.Navigation.TileBar.Orientation.property
            tileBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            tileBar1.AppearanceItem.Normal.BackColor = Color.FromArgb(65, 168, 207);
            tileBar1.AppearanceItem.Normal.ForeColor = Color.White;
            TileBarGroup group1 = new TileBarGroup();
            tileBar1.Groups.Add(group1);


            TileBarItem tile1 = new TileBarItem();
            tile1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            tile1.AppearanceItem.Normal.BackColor = arrColor[0];
            tile1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            tile1.Elements.Add(new TileItemElement() { Text = "", Image = DevExpress.Images.ImageResourceCache.Default.GetImage(arrImage[0]), ImageAlignment = TileItemContentAlignment.TopLeft });
            tile1.Elements.Add(new TileItemElement() { Text = "Main" , TextAlignment = TileItemContentAlignment.BottomLeft });

            group1.Items.Add(tile1);


        }
    }
}
