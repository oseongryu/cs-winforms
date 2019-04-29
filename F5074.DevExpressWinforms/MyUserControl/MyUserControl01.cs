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
using DevExpress.XtraCharts;
using DevExpress.Utils;
using F5074.DevExpressWinforms.MyForm.C_ChartControl;
using F5074.DevExpressWinforms.MyForm;

namespace F5074.DevExpressWinforms.MyUserControl
{
    public partial class MyUserControl01 : XtraUserControl
    {
        Random r2 = new Random();
        Series series1 = new Series("Series 1", ViewType.Point);
        public MyUserControl01()
        {
            InitializeComponent();
        }

        public MyUserControl01(string eqp, Color eqlColor, string la1, string la2, string la3, int chartSize)
        {
            InitializeComponent();
            string eqpName = eqp;
            labelControl1.Text = la1;
            labelControl2.Text = la2;
            labelControl3.Text = la3;


            tileBar1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            tileBar1.AppearanceItem.Normal.BackColor = Color.FromArgb(65, 168, 207);
            tileBar1.AppearanceItem.Normal.ForeColor = Color.White;
            TileBarGroup group1 = new TileBarGroup();
            tileBar1.Groups.Add(group1);
            tileBar1.WideTileWidth = 120;
            tileBar1.ItemSize = 65;
            tileBar1.Padding = new Padding() { All = 0, Left = 10 };
            tileBar1.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            tileBar1.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            TileBarItem tile1 = new TileBarItem();
            tile1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            tile1.AppearanceItem.Normal.BackColor = eqlColor;
            tile1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            tile1.Elements.Add(new TileItemElement() { Text = "", Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/gauges/gaugestylethreeforthcircular_32x32.png"), ImageAlignment = TileItemContentAlignment.BottomRight });
            tile1.Elements.Add(new TileItemElement() { Text = string.Format("<size=8>{0}</size>", eqpName), TextAlignment = TileItemContentAlignment.TopLeft });
            //tile1.Elements.Add(new TileItemElement() { Text = string.Format("<size=8>{0}</size><br><size=8>Equipment<br>running rate</size>", eqpName), TextAlignment = TileItemContentAlignment.TopLeft });
            group1.Items.Add(tile1);

            tile1.ItemClick += Tile1_ItemClick;

            var series = new Series(" ", ViewType.FullStackedArea);
            series.ArgumentScaleType = ScaleType.Auto;
            series.LabelsVisibility = DefaultBoolean.True;
            chartControl1.Series.Add(series);
            this.chartControl1.Legend.TextVisible = false;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            Random r = new Random();
            for (int x = 0; x < chartSize; x++)
            {
                if(x % 4 == 1)
                {
                    CreateSeries(x + r.Next(0, 100), Color.LightGreen);
                }
                else if (x % 4 == 2)
                {
                    CreateSeries(x + r.Next(0, 10), Color.PaleGoldenrod);
                }
                else if (x % 4 == 3)
                {
                    CreateSeries(x + r.Next(0, 5), Color.Gainsboro);
                }
                else if (x % 4 == 0)
                {
                    CreateSeries(x + r.Next(0, 20), Color.LightPink);
                }


            }
            SecondaryAxisY secondaryAxisY1 = new SecondaryAxisY();

            secondaryAxisY1.VisibleInPanesSerializable = "-1";
            secondaryAxisY1.WholeRange.Auto = false;
            secondaryAxisY1.WholeRange.MaxValueSerializable = "24";
            secondaryAxisY1.WholeRange.MinValueSerializable = "1";



            //((XYDiagram)chartControl1.Diagram).AxisX.Range.SideMarginsEnabled = false;
            ((XYDiagram)chartControl1.Diagram).Rotated = true;
            ((XYDiagram)chartControl1.Diagram).AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            ((XYDiagram)chartControl1.Diagram).AxisX.VisibleInPanesSerializable = "-1";
            ((XYDiagram)chartControl1.Diagram).AxisX.VisualRange.Auto = false;
            ((XYDiagram)chartControl1.Diagram).AxisX.VisualRange.MaxValueSerializable = "200";
            ((XYDiagram)chartControl1.Diagram).AxisX.VisualRange.MinValueSerializable = "1";
            ((XYDiagram)chartControl1.Diagram).AxisX.WholeRange.Auto = false;
            ((XYDiagram)chartControl1.Diagram).AxisX.WholeRange.MaxValueSerializable = "200";
            ((XYDiagram)chartControl1.Diagram).AxisX.WholeRange.MinValueSerializable = "1";
            ((XYDiagram)chartControl1.Diagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            ((XYDiagram)chartControl1.Diagram).AxisY.VisibleInPanesSerializable = "-1";
            ((XYDiagram)chartControl1.Diagram).SecondaryAxesY.AddRange(new SecondaryAxisY[] { secondaryAxisY1 });

            //XYDiagram xyDiagram1 = new XYDiagram();
            //xyDiagram1.Rotated = true;
            //chartControl1.Diagram = xyDiagram1;
            MakePointChart();

        }



        private void Tile1_ItemClick(object sender, TileItemEventArgs e)
        {
            MyChartControl05 dialog = new MyChartControl05();
            dialog.Width = 1200;
            dialog.Height = 700;
            dialog.ShowDialog();

        }

        private void MakePointChart()
        {
            series1.ArgumentScaleType = ScaleType.Numerical;

            for (int x = 1; x < 100; x++)
            {
                series1.Points.Add(new SeriesPoint(x, 10 + r2.Next(-1, 1)));

            }
            chartControl2.Series.Add(series1);

            PointSeriesView myView1 = (PointSeriesView)series1.View;
            myView1.PointMarkerOptions.Kind = MarkerKind.Circle;
            myView1.PointMarkerOptions.StarPointCount = 20;
            myView1.PointMarkerOptions.Size = 3;

            ((XYDiagram)chartControl2.Diagram).EnableAxisXZooming = true;

            chartControl2.Legend.Visible = false;

            chartControl2.Titles.Add(new ChartTitle());
            chartControl2.Titles[0].Text = "";

        }

        private void CreateSeries(int yes, Color color)
        {
            var series = new Series("series1", ViewType.StackedBar);
            series.Points.Add(new SeriesPoint(" ", yes));
            series.View.Color = color;
            series.Label.TextPattern = "{V}";
            chartControl1.Series.Add(series);

        }

    }
}
