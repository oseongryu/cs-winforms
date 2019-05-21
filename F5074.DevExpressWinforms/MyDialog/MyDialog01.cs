using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using F5074.DevExpressWinforms.MyCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static F5074.DevExpressWinforms.MyCommon.MyDatabaseConnect01;

namespace F5074.DevExpressWinforms.MyDialog
{

    public partial class MyDialog01 : UserControl
    {
        Timer timer1 = new Timer();
        SimpleButton currentButton = new SimpleButton();
        public MyDialog01(string _eqpId, string _processSeq, string _prodOrderNumber)
        {
            InitializeComponent();

            try
            {


                // 시간 이벤트
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000;
                timer1.Enabled = true;

                List<DataSevenVo> resultList = new MyDatabaseConnect01().connection9(_prodOrderNumber, "");

                if (resultList.Count > 1 && resultList.Count <= 5)
                {
                    tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[1].Height = 100;
                    this.Width = 770;
                    this.Height = 400;
                }
                else if (resultList.Count > 5 && resultList.Count <= 10)
                {
                    tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[1].Height = 200;
                    this.Width = 770;
                    this.Height = 500;
                    this.Update();
                }
                else
                {
                    tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[1].Height = 300;
                    this.Width = 770;
                    this.Height = 600;
                }

                for (int x = 0; x < resultList.Count; x++)
                {

                    SimpleButton simpleButton1 = new SimpleButton();
                    simpleButton1.Appearance.Font = new System.Drawing.Font("맑은 고딕", 7F);
                    simpleButton1.Appearance.Options.UseFont = true;
                    simpleButton1.Appearance.Options.UseTextOptions = true;
                    simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                    simpleButton1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
                    simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                    //if (resultList[x].PROCESS_SEQ.ToString() == _processSeq) simpleButton1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
                    //else simpleButton1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
                    simpleButton1.Appearance.BackColor = Color.DimGray;
                    simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
                    if (resultList[x].PROCESS_SEQ.ToString() == _processSeq)
                    {
                        simpleButton1.Appearance.BackColor = Color.Blue;
                        simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                        simpleButton1.ImageOptions.ImageUri.Uri = "Apply;Size32x32;Office2013";
                        simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
                        simpleButton1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
                        currentButton = simpleButton1;
                    }

                    simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomRight;
                    simpleButton1.ImageOptions.ImageToTextIndent = 5;
                    //simpleButton1.ImageOptions.ImageUri.Uri = "Apply;Size32x32;Office2013";
                    simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
                    //simpleButton1.Name = "simpleButton1";
                    simpleButton1.Size = new System.Drawing.Size(89, 60);
                    simpleButton1.Text = string.Format("{1}{0}{2}", Environment.NewLine, resultList[x].PROCESS_SEQ.ToString(), resultList[x].PROCESS_DESC.ToString());

                    SimpleButton simpleButton2 = new SimpleButton();
                    simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                    simpleButton2.ImageOptions.ImageUri.Uri = "Forward;GrayScaled";
                    simpleButton2.Location = new System.Drawing.Point(252, 176);
                    //simpleButton2.Name = "simpleButton1";
                    simpleButton2.Size = new System.Drawing.Size(45, 60);


                    this.flowLayoutPanel1.Controls.Add(simpleButton1);
                    if (x + 1 != resultList.Count) this.flowLayoutPanel1.Controls.Add(simpleButton2);

                }

                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentButton.Appearance.BackColor == Color.DarkBlue)
            {
                SetControlBackColor(Color.Blue);
            }
            else
            {
                SetControlBackColor(Color.DarkBlue);
            }
        }

        private void SetControlBackColor(Color color)
        {
            if (currentButton is SimpleButton)
            {
                ((SimpleButton)currentButton).Appearance.BackColor = color;
                ((SimpleButton)currentButton).Refresh();
            }
        }

        private void MakeTileBar()
        {
            //tileBar1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //tileBar1.AppearanceItem.Normal.BackColor = Color.FromArgb(65, 168, 207);
            //tileBar1.AppearanceItem.Normal.ForeColor = Color.White;
            //TileBarGroup group1 = new TileBarGroup();
            //tileBar1.Groups.Add(group1);

            ////PictureEdit pictureEdit1 = new PictureEdit() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_16x16.png") };

            ////this.flowLayoutPanel1.Controls.Add(new PictureEdit() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_16x16.png") });
            ////this.flowLayoutPanel1.Controls.Add(new PictureEdit() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_16x16.png") });
            ////this.flowLayoutPanel1.Controls.Add(new PictureEdit() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_16x16.png") });
            ////this.flowLayoutPanel1.Controls.Add(new PictureEdit() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_16x16.png") });
            ////this.flowLayoutPanel1.Controls.Add(new PictureEdit() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_16x16.png") });
            ////this.flowLayoutPanel1.Controls.Add(new PictureEdit() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_16x16.png") });

            //List<DataSevenVo> resultList = new MyDatabaseConnect01().connection8(_eqpId, "");

            //for (int x = 0; x < resultList.Count; x++)
            //{
            //    TileBarItem tile1 = new TileBarItem();
            //    tile1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            //    tile1.AppearanceItem.Normal.BackColor = Color.Gray;
            //    if (resultList[x].PROCESS_SEQ.ToString() == _processSeq)
            //    {
            //        tile1.AppearanceItem.Normal.BackColor = Color.Blue;
            //    }
            //    tile1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            //    tile1.Elements.Add(new TileItemElement() { Text = "", Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/setup/properties_32x32.png"), ImageAlignment = TileItemContentAlignment.MiddleRight });
            //    //tile1.Elements.Add(new TileItemElement() {5 Text = "", Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/navigation/forward_32x32.png"), ImageAlignment = TileItemContentAlignment.MiddleRight });
            //    //tile1.Elements.Add(new TileItemElement() { Text = "Sales", TextAlignment = TileItemContentAlignment.BottomLeft });
            //    //tile1.Elements.Add(new TileItemElement() { Text = resultList[x].PROCESS_SEQ.ToString() +resultList[x].PROCESS_DESC.ToString(), TextAlignment = TileItemContentAlignment.TopLeft });
            //    tile1.Elements.Add(new TileItemElement() { Text = string.Format("<size= 8>{0}</size><br><size = 5>{1}</size>", resultList[x].PROCESS_SEQ.ToString(), resultList[x].PROCESS_DESC.ToString()), TextAlignment = TileItemContentAlignment.TopLeft });
            //    group1.Items.Add(tile1);
            //}
        }
    }


}
